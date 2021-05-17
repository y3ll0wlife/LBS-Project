<!DOCTYPE html>
<html lang="sv">
<head>
    <meta charset="utf-8">
    <title>Valuta</title>
</head>
<body>
<h1>Valutan i kronor</h1>
<?php
    $dollar = $_POST['currency'];
    $sek = $dollar * 9.7;
    
    echo "<p>$dollar $  =  $sek kr</p>";
?>
</body>
</html>
