<?php
include 'inc/db.inc.php';
echo "<p>user: " . $_SESSION['firstname'] . "," . $_SESSION['surname'] . "</p>";
echo "<p>username: " . $_SESSION['username'] . "</p>";
echo "<p>user_id: " . $_SESSION['user_id'] . "</p>";
