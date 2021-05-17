<!-- 
Gör ett program i PHP som skriver ut talen 1.0 till 5.0 i steg om 0.1. D v s 1.0, 1.1, 1.2, …, 5.0.
Använd for och while loopen. D.v.s. samma sak två gånger!
-->
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Task 2</title>
</head>

<body>
    <?php
    $start = 1.0;
    $end = 5.0;
    $x = $start;

    echo "For loop" . "<br/>";
    for ($i = $start; $i < $end; $i += 0.1) echo $i . "<br/>";

    echo "<br/>" . "While loop" . "<br/>";
    while ($x < $end) {
        echo $x . "<br/>";
        $x += 0.1;
    }
    ?>
</body>

</html>