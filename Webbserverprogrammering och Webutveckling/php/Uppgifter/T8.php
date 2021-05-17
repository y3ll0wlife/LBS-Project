<!-- Skapa en metod som tar emot en int och skickar tillbaka talet + 1 -->
<?php

$num = 12;
echo $num."<br>";

function AddOne(&$num){
    $num ++;
}

AddOne($num);
echo $num;

?>