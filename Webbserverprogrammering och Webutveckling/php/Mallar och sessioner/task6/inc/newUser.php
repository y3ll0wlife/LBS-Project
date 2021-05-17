<?php
mb_internal_encoding("UTF-8");
include_once("./treatMessage.php");

class User
{
    public $username;
    public $password;

    function __construct($uN, $psw)
    {
        $this->username = $uN;
        $this->password = $psw;
    }
}

$users = fopen("./users.dat", "r") or die("Unable to open file!");
$accounts = array();

while (!feof($users)) {
    list($username, $password) = explode(" ", fgets($users));

    $user = new User($username, $password);
    $accounts[$username] = $user;
}
fclose($users);


if (isset($_POST["password"])) {
    $user = $accounts[$_POST["username"]] ?? "";
    if ($user == "") {
        $userDoc = fopen("./users.dat", "a") or die("Unable to open file!");
        fwrite($userDoc, "\n" . $_POST["username"] . " " . md5($_POST["password"]));
        fclose($userDoc);

        session_start();
        $_SESSION['inLoggad'] = true;
        $_SESSION["loggedUsername"] = treatMessage($_POST['username']);

        header("Location: ../index.php");
    } else {
        header("Location: ../index.php?page=signup&message=That username already exists. Please choice another one");
    }
} else header("Location: ../index.php?page=signup&message=Something went wrong, please try to reload the website");
