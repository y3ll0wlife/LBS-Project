<!-- 
Skapa ett program som bygger vidare på dem matematiska funktionerna 
som visas i filmen. Lägg till funktioner för division och subtraktion.
-->
<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Task 4</title>
</head>

<body>
  <?php
  function sum($t1, $t2)
  {
    return $t1 + $t2;
  }
  function diff($t1, $t2)
  {
    return $t1 - $t2;
  }
  function div($t1, $t2)
  {
    return $t1 / $t2;
  }
  function multi($t1, $t2)
  {
    return $t1 * $t2;
  }

  $calc1 = sum(2, 5);
  $calc2 = diff(2, 5);
  $calc3 = div(2, 5);
  $calc4 = multi(2, 5);

  echo $calc1 . "<br/>";
  echo $calc2 . "<br/>";
  echo $calc3 . "<br/>";
  echo $calc4 . "<br/>";

  ?>
</body>

</html>