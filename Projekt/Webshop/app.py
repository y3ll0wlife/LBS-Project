# Python module imports
from flask import Flask, render_template, request, g, url_for, abort, flash, jsonify, redirect, session
from flask_sqlalchemy import SQLAlchemy
import base64
import os
from datetime import timedelta
import datetime
from cryptography.fernet import Fernet
import random
import string

APP_ROOT = os.path.dirname(os.path.abspath(__file__))
UPLOAD_FOLDER_IMAGE = os.path.join(APP_ROOT, 'static', 'images')


app = Flask(__name__)  # Create new flask instance


# Flask secret
app.secret_key = "uJgYAT2TyoT3BUsnlxTt9vL4QZW0EfOAUxO4iCqmAnnj8Dmjt3OLJ8FrY3cQvbNqHFclpkdvqvObwxYz13WNGn3r8dotPWtb3zK"
# Databse uri
app.config["SQLALCHEMY_DATABASE_URI"] = "sqlite:///Database.sqlite3"
# Removes some weird errors
app.config["SQLALCHEMY_TRACK_MODIFICATIONS"] = False
# Place where all the images go
app.config['UPLOAD_FOLDER_IMAGE'] = UPLOAD_FOLDER_IMAGE
# Max upload limit 1 gb
app.config['MAX_CONTENT_LENGTH'] = 1 * 1024 * 1024 * 1024
# Stores the session for 365 days
app.permanent_session_lifetime = timedelta(days=365)

# The secret for the encryption
cipher_suite = Fernet(b'Odcg2RpFYxDpIq-NQicG4y06Db-2VhkGCSwhVnY8YvU=')
# Initialises the database
db = SQLAlchemy(app)

# Table for products


class Products(db.Model):
    # ID of the product
    _id = db.Column("id", db.Integer, primary_key=True)
    # Name of the product (MAX 100 CHARCS)
    itemName = db.Column(db.String(100))
    # Description  of the product (MAX 1000 CHARCS)
    itemDescription = db.Column(db.String(1000))
    # The price of the product
    itemPrice = db.Column(db.Integer)
    # The PATH to the image
    itemImagePath = db.Column(db.String(1000))

    def __init__(self, itemName, itemDescription, itemPrice, itemImagePath):
        self.itemName = itemName
        self.itemDescription = itemDescription
        self.itemPrice = itemPrice
        self.itemImagePath = itemImagePath

# User table


class User(db.Model):
     # ID of the user
    _id = db.Column("id", db.Integer, primary_key=True)
    # Username (MAX 100 CHARCS)
    username = db.Column(db.String(100))
    # Password (MAX 100 CHARCS)
    password = db.Column(db.String(100))
    # Basket items stored as string (MAX 1000)
    # Will be stored as ITEM, ITEM2, ITEM3
    basket = db.Column(db.String(1000))
    account_level = db.Column(db.Integer)  # account level
    # 0 = Normal User
    # 1 = Manager
    # 2 = Admin
    # How many times has the user loaded a page
    loaded = db.Column(db.Integer)

    def __init__(self, username, password, basket, account_level, loaded):
        self.username = username
        self.password = password
        self.basket = basket
        self.account_level = account_level
        self.loaded = loaded

# Create a custom coupon code
# @param the length of the code


def CreateCouponCode(length):
    characters = string.ascii_letters
    coupon = ""
    for x in range(length):
        char = random.choice(characters)
        coupon = coupon + char

    return coupon

# Called each time a user loades one part of the part site
# used when we track analytics regaridng how many times a user has loaded the site
# see loaded in the user table
@app.before_request
def load_before_request():
    if "user" in session:
        user = session["user"]
        user = User.query.filter_by(username=user).first()
        
        if not user:
            return

        user.loaded += 1
        db.session.commit()

        if random.randint(0, 15) is 0:
            flash(
                f"Congratulations you are the one millionth visitor, use the coupon code {CreateCouponCode(6)} at checkout for {random.randint(1, 100)} % off.")

# localhost/
# main part of the website
@app.route("/")
def index():
    return render_template("index.html")


# localhost/melons/
# used to list all the melons that exist on the website
@app.route("/melons/")
def melons():
     # Gets all the products in the database
    products = Products.query.all()
    return render_template("melons.html", products=products)


# localhost/view/<product_id>
# used to view a certain product we use the _id for this
@app.route("/view/<string:_id>")
def view(_id):
    pro = Products.query.filter_by(_id=_id).first()
    if not pro:
        abort(404)
    else:
        return render_template("viewProduct.html", id=_id, name=pro.itemName, desc=pro.itemDescription, price=pro.itemPrice, img=pro.itemImagePath)

# localhost/basket/
# renders the entire basket for the user
# if not logged in send them to the login page
@app.route("/basket/")
def basket():
    if "user" in session:
        user = session["user"]
        user = User.query.filter_by(username=user).first()

        basketId = user.basket.split(', ')[:-1]

        bName = []
        bPrice = []
        bIcon = []
        bId = []

        for _id in basketId:
            melon = Products.query.filter_by(_id=_id).first()
            bName.append(melon.itemName)
            bPrice.append(melon.itemPrice)
            bIcon.append(f"../{melon.itemImagePath}")
            bId.append(melon._id)

        return render_template("basket.html",
                               user=user,
                               bPrice=bPrice,
                               bName=bName,
                               bIcon=bIcon,
                               basketLen=len(bName),
                               totalPrice=sum(bPrice),
                               bId=bId
                               )
    else:
        flash("Please log in before accessing the basket")
        return redirect(url_for("login"))

# localhost/basket/order [POST]
# called whenever a user presses the checkout button on the basket page
# removes all the items in the users basket and flashs a success message
# if not logged in abort as 404
@app.route("/basket/order/", methods=["POST"])
def make_order():
    if "user" in session:
        user = session["user"]

        user = User.query.filter_by(username=user).first()
        user.basket = ""
        db.session.commit()

        flash("Order successful!")
        return redirect(url_for("index"))
    else:
        flash("Please log in before accessing the basket")
        return redirect(url_for("login"))


# localhost/basket/add/<the id of the item> [POST]
# called wheenver a user addes a new item to a basket
# if not logged in abort as 404
@app.route("/basket/add/<string:_id>", methods=["POST"])
def add_new_item(_id):
    if "user" in session:
        user = session["user"]

        foundItem = Products.query.filter_by(_id=_id).first()

        user = User.query.filter_by(username=user).first()
        user.basket += f"{_id}, "
        db.session.commit()

        flash(f"Added {foundItem.itemName} to the shopping cart")
        return redirect(url_for("melons"))
    else:
        flash("Please log in before accessing the basket")
        return redirect(url_for("login"))

# localhost/basket/remove/<id of the item to remove> [POST]
# called whenever a user removes an item from the basket
# if not logged in abort as 404
@app.route("/basket/remove/<string:item>", methods=["POST"])
def remove_item(item):
    if "user" in session:

        user = session["user"]

        user = User.query.filter_by(username=user).first()
        user.basket = user.basket.replace(f"{item},", "", 1)
        db.session.commit()

        flash(f"Removed item from the shopping cart")
        return redirect(url_for("basket"))
    else:
        flash("Please log in before accessing the basket")
        return redirect(url_for("login"))

# localhost/login [POST, GET]
# if the request is a post request the user tried to login
    # match the username and password to the database and if correct log the user in
# if the user just tried to access the site render the login site
# if the user is already logged in send them to the profile page
@app.route("/login/", methods=["POST", "GET"])
def login():
    if request.method == "POST":
        usr = request.form["urs"]
        psw = request.form["psw"]

        foundUser = User.query.filter_by(username=usr).first()

        if foundUser == None:
            flash("Incorrect username or password, please try again.")
            return render_template("login.html")
        else:
            decryptPSW = cipher_suite.decrypt(foundUser.password)
            if psw == decryptPSW.decode("utf-8"):
                session["user"] = usr
                return redirect(url_for("profile"))
            else:
                flash("Incorrect username or password, please try again.")
                return render_template("login.html")

    else:
        if "user" in session:
            user = session["user"]
            return redirect(url_for("profile"))
        else:
            return render_template("login.html")

# localhost/signup [POST, GET]
# if the request is a post request the user tried to signup
    # if the psw and the confirmed psw is the same create an account for the user
    # and log them into the site and send them to the profile page
# if the user just tried to access the site render the signup site
# if the user is already logged in send them to the profile page
@app.route("/signup/", methods=["POST", "GET"])
def signup():
    if request.method == "POST":
        session.permanent = True
        usr = request.form["urs"]
        psw = request.form["psw"]
        pswConfirm = request.form["pswConfirm"]
        session["user"] = usr

        if psw != pswConfirm:
            flash(
                "Your password and the confirmed password is not the same please try again.")
            return render_template("signup.html")

        if len(psw) >= 100:
            flash("Your password is more than 100 characters. Please make it shorter.")
            return render_template("signup.html")

        if len(usr) >= 100:
            flash("Your username is more than 100 characters. Please make it shorter.")
            return render_template("signup.html")

        if bool(User.query.filter_by(username=usr).first()) == False:
            byteText = bytes(psw, "utf-8")
            encryptedPSW = cipher_suite.encrypt(byteText)

            newFile = User(username=usr, password=encryptedPSW,
                           basket="", account_level=0, loaded=0)
            db.session.add(newFile)
            db.session.commit()
            flash("Successfully created an account")
            return redirect(url_for("profile"))
        else:
            flash("That username is already taken")
            return render_template("signup.html")

    else:
        if "user" in session:
            user = session["user"]
            return redirect(url_for("profile"))
        else:
            return render_template("signup.html")

# localhost/profile
# view the current logged in users profile
# if the user is not logged in redirect them to the login page
@app.route("/profile/")
def profile():
    if "user" in session:
        user = User.query.filter_by(username=session["user"]).first()
        return render_template("profile.html", user=user)

    else:
        flash("You are not logged in!")
        return redirect(url_for("login"))

# localhost/signout
# if a user is logged in log them out and clear the session
# if the are not logged in send them to the login screen with a flashed message
@app.route("/signout/")
def sign_out():
    if "user" in session:
        flash("You have been logged out!")
        session.pop("user", None)
        return redirect(url_for("index"))
    else:
        flash("You cant log out if you are currently not logged in ;)")
        return redirect(url_for("login"))


# Main admin page
# localhost/admin/
# check if a user is logged in (if not 404)
# check if logged in user has the correct account level to view the site (if not 404)
# then render the admin page
@app.route("/admin/")
def admin():
    if "user" in session:
        user = session["user"]
        foundUser = User.query.filter_by(username=user).first()
        if foundUser.account_level >= 2:
            products = Products.query.all()  # Gets all the products in the database
            users = User.query.all()  # Gets all the users in the database
            return render_template("admin.html", products=products, users=users)
        else:
            abort(404)
    else:
        abort(404)


# localhost/admin/add [POST]
# Called when adding a new product to the webshop
# check if a user is logged in (if not 404)
# check if logged in user has the correct account level to view the site (if not 404)
@app.route("/admin/add", methods=["POST"])
def adminadd():
    if "user" in session:
        user = session["user"]
        foundUser = User.query.filter_by(username=user).first()
        if foundUser.account_level >= 2:
            # Gets the product name from the form
            productName = request.form["productName"]
            # Gets the product description from the form
            productDescription = request.form["productDescription"]
            # Gets the product price from the form
            productPrice = request.form["productPrice"]
            # Gets the product image from the form
            productImage = request.files["productImage"]

            imageName = os.path.join(
                app.config['UPLOAD_FOLDER_IMAGE'], productName + '.png')
            productImage.save(imageName)

            newProduct = Products(itemName=productName, itemDescription=productDescription,
                                  # Adds all this data into one new object called newProduct
                                  itemPrice=productPrice, itemImagePath=f"static/images/{productName}.png")
            db.session.add(newProduct)  # Adds that to the current DB session
            db.session.commit()         # Commits that to the database

            flash(
                f"Successfully added a new product: {productName}")  # We flash a short message telling the admin that the product was added successfully
            # Redirct to the admin page again
            return redirect(url_for("admin"))
        else:
            abort(404)
    else:
        abort(404)

# localhost/admin/modify/id [POST]
# Called when we want to modify a item in the shop
# check if a user is logged in (if not 404)
# check if logged in user has the correct account level to view the site (if not 404)
@app.route("/admin/modify/<string:_id>", methods=["POST"])
def modify_item(_id):
    if "user" in session:
        user = session["user"]
        foundUser = User.query.filter_by(username=user).first()
        if foundUser.account_level >= 2:
            prod = Products.query.filter_by(_id=_id).first()

            db.session.commit()

            flash(
                f"Successfully updated: {prod.itemName}")
            return redirect(url_for("admin"))
        else:
            abort(404)
    else:
        abort(404)


# localhost/admin/remove/<item name> [POST]
# Called when remvoing a new product to the webshop
# check if a user is logged in (if not 404)
# check if logged in user has the correct account level to view the site (if not 404)
@app.route("/admin/remove/<string:name>", methods=["POST"])
def adminremove(name):
    if "user" in session:
        user = session["user"]
        foundUser = User.query.filter_by(username=user).first()
        if foundUser.account_level >= 2:
            obj = Products.query.filter_by(itemName=name).first()
            db.session.delete(obj)
            db.session.commit()
            os.remove(f"./static/images/{name}.png")

            flash(
                f"Successfully removed: {name}")    # We flash a short message telling the admin that the product was removed successfully
            # Redirct to the admin page again
            return redirect(url_for("admin"))
        else:
            abort(404)
    else:
        abort(404)


# If the user gets an 404 error render the 404 template
# also print the error message to the console
@app.errorhandler(404)
def page_not_found(err):
    print(f"[404] {err}")
    return render_template('404.html'), 404

# if the user gets an 405 error render the 404 template
# also prin the erorr message to the console
@app.errorhandler(405)
def method_not_allowed(err):
    print(f"[405] {err}")
    return render_template('404.html'), 405


# Main function of the operation
# we call this when the program is first ran and start everything
if __name__ == "__main__":
    # Create the Database and all its tables
    db.create_all()
    # Start flask application
    # debug=True (this is so the site autoreloads each time a change is made)m
    app.run(debug=True)
