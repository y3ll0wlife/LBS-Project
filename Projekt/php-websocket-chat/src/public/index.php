<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Gloogle Choot</title>
    <link rel="stylesheet" href="./css/main.css">
</head>

<body>
    <?php include("./components/navbar.php") ?>
    <h2 style="text-align: center;">You need a username to chat</h2>
    <form method="POST" action="chat-call.php">
        <p>
            <input type="text" name="username" id="fname" placeholder="Username">
            <input type="submit" value="Submit">
        </p>
    </form>
</body>

</html>