<!-- 
När man klickar på skicka knappen skall all information skickas till en PHP-sida som.
    Säkrar att anropet av PHP-sidan anropas från rätt sida (sidan med formuläret). Använd isset().
    Skyddar mot skadlig kod (strip_tags eller htmlspecialchars) och filtrera bort mellanslag och backslash-tecken.
    Omdirigeras tillbaka till sidan med formuläret om något går fel. header("location: ...");
    Skriver ut förnamn, efternamn, användarnamn och lösenord
-->
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Task 5 - Call</title>
</head>

<body>
    <?php
    mb_internal_encoding("UTF-8");

    if (isset($_POST["password"])) {
        function strTreatment($s)
        {
            return str_replace(" ", "", str_replace("\\", "", strip_tags($s)));
        }


        $firstName = strTreatment($_POST["firstName"]);
        $lastName = strTreatment($_POST["lastName"]);
        $username = strTreatment($_POST["username"]);
        $password = strTreatment($_POST["password"]);

        if (!mb_check_encoding($password)) header("Location: http://127.0.0.1:1337/task5.php");

        echo $firstName . " " . $lastName . "<br/>";
        echo $username . " " . $password . "<br/>";
    } else {
        header("Location: http://127.0.0.1:1337/task5.php");
    }


    ?>
</body>

</html>