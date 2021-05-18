<?php

$servername = "localhost";  # phpmyadmin host
$username = "root";         # phpmyadmin username
$password = "";             # phpmyadmin password
$dbname = "world";

// Create connection
$conn = mysqli_connect($servername, $username, $password, $dbname);

if (!$conn) die("Connection failed: " . mysqli_connect_error());

$country = $_GET['country'];
$city = $_GET["city"];

$sql = "SELECT * FROM `city` WHERE CountryCode LIKE \" . SWE \" . ";
$result = $conn->query($sql);


$json = array();
$total_records = mysqli_num_rows($result);

if ($total_records > 0) {
    while ($row = mysqli_fetch_assoc($result)) {
        $json[] = $row;
    }
}

echo json_encode($json);

$conn->close();

 
# SELECT city.*
# FROM country JOIN city ON country.Code = city.CountryCode
# WHERE country.Name = "Sweden"
