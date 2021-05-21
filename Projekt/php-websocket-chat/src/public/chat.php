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
    <?php include("./components/navbar.php");
    if (!$_GET["username"]) header("Location: ./");
    #echo "<h2 style='text-align: center;'> Welcome back " . $_GET["username"] . "</h2>";
    ?>


    <div id="chat-container"></div>
    <input type="text" id="chatText"> <input type="submit" value="Send message" onClick="transmitMessage()">

    <script src="./js/handleSockets.js"></script>

</body>

</html>