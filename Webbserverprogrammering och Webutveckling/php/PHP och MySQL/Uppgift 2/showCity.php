<?php
include_once('inc/db.inc.php');

if (isset($_POST['city'])) {
    $city = filter_input(INPUT_POST, 'city', FILTER_SANITIZE_STRING);

    $stmt = $db->prepare("SELECT Name,Population FROM city WHERE Name LIKE ? ORDER BY Name");
    $stmt->bindValue(1, "$city%", PDO::PARAM_STR);
    $stmt->execute();

    header('Content-Type: text/html; charset=utf-8');

    while ($row = $stmt->fetch(PDO::FETCH_ASSOC)) {
        echo "<strong>Land: </strong>" . $row['Name'];
        echo "<strong>Antal invånare: </strong>" . $row['Population'];
        echo "<br /><hr />";
    }
}
