<!-- 
Placera filen med användare utanför webbroten (htdocs).

Vidareutveckla så att ny användare kan läggas till i filen. 
Detta sker med ett formulär där nya användare kan skrivas in. PHP-koden skall därefter ta information från formuläret och lägga till användaren i filen.

-->
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Extra Extra Task</title>
</head>

<body>
    <form method="GET">
        Username: <input type="text" name="username" required> <br />
        Favorite Color: <input type="text" name="favoriteColor" required><br />
        Password: <input type="password" name="password" required><br />
        <input type="submit" value="Sign in">
    </form>

    <?php
    mb_internal_encoding("UTF-8");

    class User
    {
        public $username;
        public $password;
        public $favColor;

        function __construct($uN, $psw, $color)
        {
            $this->username = $uN;
            $this->password = $psw;
            $this->favColor = $color;
        }
    }

    $users = fopen("users.txt", "r") or die("Unable to open file!");
    $accounts = array();

    while (!feof($users)) {
        list($username, $password, $favColor) = explode(" ", fgets($users));

        $user = new User($username, $password, $favColor);
        $accounts[$username] = $user;
    }
    fclose($users);




    if (isset($_GET["password"])) {
        $user = $accounts[$_GET["username"]] ?? "";
        if ($user == "") {
            echo "<br/> Welcome <b>" . $_GET["username"] . "</b> <br/>";
            $userDoc = fopen("users.txt", "a") or die("Unable to open file!");
            fwrite($userDoc, "\n" . $_GET["username"] . " " . md5($_GET["password"]) . " " . $_GET["favoriteColor"]);
            fclose($userDoc);
        } else {
            echo "That username already exists. Please choice another one";
        }
    } else echo "Something went wrong, please try to reload the website";


    ?>
</body>

</html>