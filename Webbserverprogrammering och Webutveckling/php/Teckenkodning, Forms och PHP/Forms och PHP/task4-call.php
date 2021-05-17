<!DOCTYPE html>
<html lang="sv">
<head>
    <meta charset="utf-8">
    <title>Task 4 call page</title>
</head>
<body>
<?php
    $name = $_POST['name'];
    $yearnBorn = $_POST["yearnBorn"];
    $age = date("Y") - $yearnBorn;
    
    echo "<p>Hej $name, du är $age år gammal</p>";
?>
</body>
</html>
