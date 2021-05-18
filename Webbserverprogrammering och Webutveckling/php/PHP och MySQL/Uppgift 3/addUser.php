<?php
if (isset(
    $_POST['firstname'],
    $_POST['surname'],
    $_POST['username'],
    $_POST['password']
)) {
    include_once('inc/db.inc.php');

    $fname = filter_input(INPUT_POST, 'firstname', FILTER_SANITIZE_STRING);
    $sname = filter_input(INPUT_POST, 'surname', FILTER_SANITIZE_STRING);
    $user = filter_input(INPUT_POST, 'username', FILTER_SANITIZE_FULL_SPECIAL_CHARS);
    $pwd = password_hash($_POST['password'], PASSWORD_DEFAULT);

    $stmt = $db->prepare("INSERT INTO user(firstname, surname, username, password) VALUES(:fn, :sn,:user,:pwd)");

    $stmt->bindValue(":fn", $fname);
    $stmt->bindValue(":sn", $sname);
    $stmt->bindValue(":user", $user);
    $stmt->bindValue(":pwd", $pwd);

    if ($stmt->execute()) {
        header('Location: index.html');
    } else {
        header('Content-Type: text/html; charset=utf-8');
        echo "<p>Kunde inte lägga till användaren. Kontrollera användarnamnet</p>";
        echo "<a href = 'index.html'>Försök igen</a>";
    }
}
