<!-- 
Använd klassen Person eller egen klass. Dock skall användarnamn och lösenord ingå som egenskaper

Skapa en fil med ett antal användare, se exemplet i slutet av teorin. 
Om detta blir för svårt kan du skapa en php-fil där ett antal instanser av klassen skapas i en array, se filmen Login med PHP.

Skapa ett formulär som gör det möjligt att man kan logga in med användarnamn och lösen.

Formulärets användarnamn och lösenord skall testas. 
Om användare med rätt lösenord finns i filen skall du skriva ut all information om den användaren. 
I annat fall skall man omdirigeras till formuläret.

Beakta olika säkerhetsaspekter.

-->
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Extra Task</title>
</head>

<body>
    <form method="GET">
        Username: <input type="text" name="username" required> <br />
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
        if ($user != "" && $user->password == md5($_GET["password"])) {
            echo "<br/> Welcome back <b>" . $user->username .  "</b> <br/>";
            echo "Your password is <b>" . $user->password .  "</b> <br/>";
            echo "Your favorite color is <b>" . $user->favColor .  "</b> <br/>";
        } else {
            echo "That user does not exist, or you typed the passsword wrong";
        }
    } else echo "That user does not exist, or you typed the passsword wrong";


    ?>
</body>

</html>