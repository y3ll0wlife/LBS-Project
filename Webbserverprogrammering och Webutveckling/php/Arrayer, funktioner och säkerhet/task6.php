<!-- 
Skapa i en separat fil en funktion med namnet cleanData($data) som tar emot 
 parametern $data. Funktionen skall rensa $data från skadlig kod och ta bort eventuella 
 mellanslag och backslash-tecken. Därefter returneras den nya datan.
Tips: Använd str_replace()
Du skall nu använda funktionen i uppgift 5 istället för att rensa den skadlig kod direkt i koden.
-->
<?php
function cleanData($data)
{
    return str_replace(" ", "", str_replace("\\", "", strip_tags($data)));
}
?>