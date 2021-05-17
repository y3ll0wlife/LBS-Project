<!-- Skapa en metod som tar emot ett heltal i minuter och skickar tillbaka talet i sekunder
ex: Metod(5) => 5 minuter motsvarar 300 sekunder
 -->
<?php

function AddOne($mins){
    return $mins * 60;
}

echo AddOne(5)

?>