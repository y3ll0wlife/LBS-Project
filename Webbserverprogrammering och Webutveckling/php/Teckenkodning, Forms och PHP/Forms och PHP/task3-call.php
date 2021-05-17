<!DOCTYPE html>
<html lang="sv">
<head>
    <meta charset="utf-8">
    <title>Task 3 call page</title>
</head>
<body>
<?php
    $n1 = $_POST['n1'];
    $n2 = $_POST["n2"];
    $sum = $n1 + $n2;
    
    echo "<p>Summan av $n1 + $n2 är $sum</p>";
   
?>
</body>
</html>
