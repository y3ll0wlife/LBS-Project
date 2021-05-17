<!-- 
Utveckla uppgift 4 genom att skapa en formulär med 
två fält för tal och ett fält för räknesätt. 
Programmet ska ta dessa värden och spara dem i lokala variabler i PHP-filen. 
Programmet räknar sedan ut resultatet med angivet räknesätt och visar det 
snyggt på sidan.

-->
<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Task 4.1</title>
</head>

<body>

  <form method="GET">
    Number 1: <input type="number" name="n1">
    Operator 2:
    <select name="op">
      <option value="+">+</option>
      <option value="-">-</option>
      <option value="/">/</option>
      <option value="*">*</option>
    </select>
    Number 2: <input type="number" name="n2">
    <input type="submit" value="Calculate">
  </form>
  <? echo "hi" ?>

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

  $n1 = $_GET['n1'];
  $n2 = $_GET['n2'];
  $op = $_GET['op'];


  if ($op == '+') $res = sum($n1, $n2);
  else if ($op == '-') $res = diff($n1, $n2);
  else if ($op == '/') $res = div($n1, $n2);
  else if ($op == '*') $res =  multi($n1, $n2);

  echo "<h1> " . $n1 . "  "  . $op . "  " . $n2 . " = " . $res . "</h1>"


  ?>

</body>

</html>