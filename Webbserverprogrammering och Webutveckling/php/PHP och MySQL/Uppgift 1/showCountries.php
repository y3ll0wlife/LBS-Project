<?php
include_once('inc/db.inc.php');
$sqlkod = "SELECT Name 
           FROM city 
           WHERE Name 
           LIKE 'Z%'
           ORDER BY Name";

$stmt = $db->prepare($sqlkod);
$stmt->execute();

header('Content-Type: text/html; charset=utf-8');

while ($row = $stmt->fetch(PDO::FETCH_ASSOC)) {
    echo "<strong>Stad: </strong>" . $row['Name'];
    echo "<br /><hr />";
}
