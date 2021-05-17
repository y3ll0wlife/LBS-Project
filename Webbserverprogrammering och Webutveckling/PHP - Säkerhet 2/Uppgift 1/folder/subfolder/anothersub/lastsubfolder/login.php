<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
</head>
<form method="GET">
    <input type="password" name="psw" id="psw">
    <button type="submit">Submit </button>
</form>

<?php
include("../../../../very-secret.php");
$hashCode = password_hash($_GET["psw"], PASSWORD_DEFAULT);
echo $hashCode;
?>

<body>

</body>

</html>