<!--Skapa en funktion som tar emot 2 tal. Programmet skriver sedan ut differensen och summan av talen. -->
<?php 
function minFunktion($num1, $num2){
    $sum = $num1 + $num2;
    $diff = $num1 - $num2;

    echo "=> $sum <br>";
    echo "=> $diff <br>";
    
}
minFunktion(180, 20)
?>

