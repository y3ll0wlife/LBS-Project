from flask import Flask, render_template, request, g, url_for, abort, flash, jsonify, redirect, session
from flask_sqlalchemy import SQLAlchemy
from base64 import b64encode
import os
import uuid
from datetime import timedelta
import datetime
from cryptography.fernet import Fernet

APP_ROOT = os.path.dirname(os.path.abspath(__file__))
UPLOAD_FOLDER_VIDEO = os.path.join(APP_ROOT, 'static', 'videos')
UPLOAD_FOLDER_IMAGE = os.path.join(APP_ROOT, 'static', 'images')

app = Flask(__name__)
app.secret_key = "uJgYAT2TyoT3BUsnlxTt9vL4QZW0EfOAUxO4iCqmAnnj8Dmjt3OLJ8FrY3cQvbNqHFclpkdvqvObwxYz13WNGn3r8dotPWtb3zK"  # Database
app.config["SQLALCHEMY_DATABASE_URI"] = "sqlite:///Simpeo.sqlite3"  # Databse uri
app.config["SQLALCHEMY_TRACK_MODIFICATIONS"] = False
# Folder where we store videos
app.config['UPLOAD_FOLDER_VIDEO'] = UPLOAD_FOLDER_VIDEO
# Folder where we store the thumbnails
app.config['UPLOAD_FOLDER_IMAGE'] = UPLOAD_FOLDER_IMAGE
app.config['MAX_CONTENT_LENGTH'] = 1 * 1024 * \
    1024 * 1024  # Max upload limit 1 gb
app.permanent_session_lifetime = timedelta(
    days=365)  # Stores the session for 365 days

# Encryption key for the passwords
cipher_suite = Fernet(b'Odcg2RpFYxDpIq-NQicG4y06Db-2VhkGCSwhVnY8YvU=')

db = SQLAlchemy(app)


class FileContent(db.Model):  # Table for vidoes
    _id = db.Column("id", db.Integer, primary_key=True)
    uploaderUUID = db.Column(db.String(1000))
    videoUUID = db.Column(db.String(200))
    uploadTime = db.Column(db.String(200))
    uploadName = db.Column(db.String(100))
    videoPATH = db.Column(db.String(1000))
    videoName = db.Column(db.String(200))
    videoDesc = db.Column(db.String(500))
    thumbnailPATH = db.Column(db.String(1000))

    def __init__(self, uploadName, videoPATH, videoUUID, videoName, uploadTime, videoDesc, thumbnailPATH, uploaderUUID):
        self.uploadName = uploadName
        self.videoPATH = videoPATH
        self.videoUUID = videoUUID
        self.videoName = videoName
        self.uploadTime = uploadTime
        self.videoDesc = videoDesc
        self.thumbnailPATH = thumbnailPATH
        self.uploaderUUID = uploaderUUID


class User(db.Model):  # Table for users
    _id = db.Column("id", db.Integer, primary_key=True)
    userUUID = db.Column(db.String(200))
    username = db.Column(db.String(100))
    password = db.Column(db.String(100))

    def __init__(self, username, password, userUUID):
        self.username = username
        self.password = password
        self.userUUID = userUUID


@app.route("/", methods=["POST", "GET"])  # Home page
def index():
    if request.method == "POST":
        vidName = request.form["videoNameSearch"]
        search = "%{}%".format(vidName)
        foundContent = FileContent.query.filter(
            FileContent.videoName.like(search)).all()  # SELECT * FROM table WHERE tags LIKE "%searchTAG%";

        if len(foundContent) == 0:
            flash("No videos found")

        return render_template("search.html", values=foundContent)
    else:
        return render_template("index.html")


@app.route("/list/")  # List of all files
def list():
    foundVals = FileContent.query.all()
    return render_template("list.html", values=foundVals)


@app.route("/login/", methods=["POST", "GET"])  # Login page
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


@app.route("/signup/", methods=["POST", "GET"])  # Sign up page
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

            newFile = User(userUUID=str(uuid.uuid4()),
                           username=usr, password=encryptedPSW)
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


@app.route("/profile/")  # Profile page
def profile():
    if "user" in session:
        user = session["user"]

        usr = User.query.filter_by(username=session["user"]).first()
        foundVals = FileContent.query.filter(
            FileContent.uploaderUUID.like(usr.userUUID)).all()

        return render_template("profile.html", username=user, values=foundVals)

    else:
        flash("You are not logged in!")
        return redirect(url_for("login"))


@app.route("/signout/")
def sign_out():
    flash("You have been logged out!")
    session.pop("user", None)
    return redirect(url_for("index"))


@app.route("/purchase/")
def purchase():
    return render_template("purchase.html")


@app.route("/videoPlayer/<string:_id>")  # Route to the correct video
def videoUpload(_id):
    foundContent = FileContent.query.filter_by(videoUUID=_id).first()

    if foundContent is None:
        return redirect(url_for("index"))
    else:
        return render_template("videoPlayer.html", value=foundContent)


@app.route("/upload/", methods=["POST", "GET"])  # Upload
def upload():
    if "user" in session:
        if request.method == "POST":
            file = request.files["inputFile"]
            thumbnail = request.files["thumbnail"]
            vidName = request.form["vidName"]
            vidDesc = request.form["vidDesc"]

            if file.filename.split('.')[-1] == "mp4":
                videoUUID = str(uuid.uuid4())

                if vidName == "":
                    vidName = str(uuid.uuid4())

                latestfile = request.files['inputFile']
                full_filename = os.path.join(
                    app.config['UPLOAD_FOLDER_VIDEO'], videoUUID + '.mp4')
                latestfile.save(full_filename)

                tn = request.files['thumbnail']
                full_filename = os.path.join(
                    app.config['UPLOAD_FOLDER_IMAGE'], videoUUID + '.png')
                tn.save(full_filename)

                usr = User.query.filter_by(username=session["user"]).first()

                newFile = FileContent(
                    uploaderUUID=usr.userUUID, uploadName=file.filename, videoPATH=f"static/videos/{videoUUID}.mp4", videoUUID=videoUUID, videoName=vidName, uploadTime=datetime.datetime.now(), videoDesc=vidDesc, thumbnailPATH=f"static/images/{videoUUID}.png")
                db.session.add(newFile)
                db.session.commit()

                flash("Video was successfully uploaded")
                return redirect(f"/videoPlayer/{videoUUID}")

            else:
                flash("Only .mp4 files are allowed")
                return redirect(f"/upload")

        else:
            return render_template("upload.html")
    else:
        flash("You are not logged in!")
        return redirect(url_for("login"))


# Error pages
@app.errorhandler(404)
def page_not_found(e):
    return render_template("404.html"), 404


@app.errorhandler(405)
def method_not_allowed(e):
    return render_template("404.html"), 405


if __name__ == "__main__":
    db.create_all()
    app.run(debug=True)
