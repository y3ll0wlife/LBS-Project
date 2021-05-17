<!-- På lättaste sätt, skriv ut innehållet och längden på följande array:

$testArray = Array(“Snart”, “är”, “det”, “Jullov”);
 -->
<?php

$testArray = Array("Snart", "är", "det", "Jullov");

echo join(' ', $testArray);
echo "<br>";
echo count($testArray);

?>