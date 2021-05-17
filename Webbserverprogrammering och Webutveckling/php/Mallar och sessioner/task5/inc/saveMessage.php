<?php

include_once("./treatMessage.php");
session_start();

if (!isset($_SESSION['inLoggad'])) header("Location: index.php?page=login");

$name = "<hr><p>Från: " . treatMessage($_SESSION["loggedUsername"]) . "</p>";
$msg = "<p>" . treatMessage($_POST['message']) . "</p>";

file_put_contents("./message.dat", $name . $msg, FILE_APPEND);

header("Location: ../index.php?page=klotterplank");
