<!DOCTYPE html>
<html lang="sv">
<head>
    <meta charset="utf-8">
    <title>Task 2a3 call page</title>
</head>
<body>
<?php
    $name = $_POST['name'];
    $age = $_POST["age"];
    $yearsUntil65 = 65-$age;
    
    echo "<p>Hej $name, $age år gammal</p>";
    echo "$yearsUntil65 år innan du går i pension"
?>
</body>
</html>
