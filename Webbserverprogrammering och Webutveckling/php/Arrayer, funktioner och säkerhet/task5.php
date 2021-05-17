<!-- 
Skapa ett formulär som läser in användardata om en 
person som skall ha ett tänkt konto på er webbplats.

Följande data är lämplig
    Förnamn
    Efternamn
    Användarnamn
    Lösenord

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
    <title>Task 5</title>
</head>

<body>
    <form method="POST" action="task5-call.php">
        First name: <input type="text" name="firstName"> <br />
        Last name: <input type="text" name="lastName"><br />
        Username: <input type="text" name="username"><br />
        Password: <input type="password" name="password"><br />

        <input type="submit" value="Sign up">
    </form>
</body>

</html>