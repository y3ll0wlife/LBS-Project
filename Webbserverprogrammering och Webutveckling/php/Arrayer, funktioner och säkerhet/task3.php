<!-- 

$page["head"] = "<h1>Välkommen</h1>";
$page["main"] = "<p>Detta är innehållet på min sida</p>";
$page["footer"] = "<hr><p>Min sidfoot</p>";

Ta koden ovan och skapa en PHP-sida som skriver ut allt innehåll i den 
associativa arrayen med en foreach-loop.
-->
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Task 3</title>
</head>

<body>
    <?php
    $page = array();
    $page["head"] = "<h1>Välkommen</h1>";
    $page["main"] = "<p>Detta är innehållet på min sida</p>";
    $page["footer"] = "<hr><p>Min sidfoot</p>";

    foreach ($page as $x => $x_value) {
        echo $x_value;
        echo "<br>";
    }
    ?>
</body>

</html>