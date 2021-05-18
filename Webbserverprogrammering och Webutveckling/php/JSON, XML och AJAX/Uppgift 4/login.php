<?php
session_start();

if ($_SESSION["loggedIn"]) {
    $username = $_SESSION["username"];
    $password = $_SESSION["password"];
} else {
    $username = $_GET['username'];
    $password = $_GET["password"];
}

$data = array(
    "status" => false,
);

if ($username == "admin" && $password == "root") {
    $_SESSION['loggedIn'] = true;
    $_SESSION["username"] = $username;
    $_SESSION["password"] = $password;


    $favoriteColor = "gul";

    $data = array(
        "status" => true,
        "username" => $username,
        "password" => $password,
        "color" => $favoriteColor,

    );
}

echo json_encode($data);
