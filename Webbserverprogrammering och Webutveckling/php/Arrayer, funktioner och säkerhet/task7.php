<!-- 
Gör om samma sida som i uppgift 5/6, men nu skall php-koden ligga på samma sida som 
formuläret. När man klickar på skicka-knappen skall sidan anropa sig själv. 
Självklart skall du fortfarande includera funktionen cleanData. 
Tips!
Om man i form taggen inte anger action, så anropar sidan sig självt.

-->
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Task 7</title>
</head>

<body>
    <form method="GET">
        First name: <input type="text" name="firstName"> <br />
        Last name: <input type="text" name="lastName"><br />
        Username: <input type="text" name="username"><br />
        Password: <input type="password" name="password"><br />

        <input type="submit" value="Sign up">
    </form>

    <?php
    mb_internal_encoding("UTF-8");

    if (isset($_GET["password"])) {
        function cleanData($s)
        {
            return str_replace(" ", "", str_replace("\\", "", strip_tags($s)));
        }


        $firstName = cleanData($_GET["firstName"]);
        $lastName = cleanData($_GET["lastName"]);
        $username = cleanData($_GET["username"]);
        $password = cleanData($_GET["password"]);


        echo " <br/> Data from form: <br/>";
        echo $firstName . " " . $lastName . "<br/>";
        echo $username . " " . $password . "<br/>";
    }

    ?>
</body>

</html>