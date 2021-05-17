<?php

include_once("./treatMessage.php");
session_start();


if ($_SESSION['CSRFToken'] != $_POST['CSRFToken']) return header("Location: index.php?page=login");
if (!isset($_SESSION['inLoggad'])) return header("Location: index.php?page=login");

$name = "<hr><p>Från: " . treatMessage($_POST['name']) . "</p>";
$msg = "<p>" . treatMessage($_POST['message']) . "</p>";

file_put_contents("./message.dat", $name . $msg, FILE_APPEND);

header("Location: ../index.php?page=klotterplank");
