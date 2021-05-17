<!-- Visa hur funktionen strip_tags fungerar om du vill tillåta vissa taggar. Exempel > https://www.w3schools.com/php/func_string_strip_tags.asp -->
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Task 1</title>
</head>

<body>
    <?php
    echo strip_tags("Hello <h1><b>world</b>!</h1>", "<b>");
    ?>
</body>

</html>