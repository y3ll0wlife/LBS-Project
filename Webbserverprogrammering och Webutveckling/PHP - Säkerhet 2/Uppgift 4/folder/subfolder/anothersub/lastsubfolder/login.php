<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
</head>
<form method="GET">
    <input type="text" name="name" id="name">
    <input type="password" name="psw" id="psw">
    <button type="submit">Submit </button>
</form>

<?php
include("../../../../very-secret.php");

if (empty($_GET['name'])) return;
$key = $_GET['name'];
if (!isset($user[$key])) return;


if (!password_verify($_GET["psw"], $user[$key])) return;

echo $_GET['name'] . "<br/>";
echo $user[$key];
?>

<body>

</body>

</html>