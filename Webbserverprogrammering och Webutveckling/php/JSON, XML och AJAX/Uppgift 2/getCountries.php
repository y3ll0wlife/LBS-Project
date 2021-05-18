<?php

$servername = "localhost";  # phpmyadmin host
$username = "root";         # phpmyadmin username
$password = "";             # phpmyadmin password
$dbname = "world";

class Country
{
    public $name;
    public $code;
    public $continent;
    public $region;
    public $surfaceArea;
    public $population;
    public $headOfState;
}

// Create connection
$conn = mysqli_connect($servername, $username, $password, $dbname);

if (!$conn) die("Connection failed: " . mysqli_connect_error());

$country = $_GET['country'];

$sql = "SELECT * FROM country WHERE Name LIKE \"" . $country . "%\" ORDER BY Name";
$result = $conn->query($sql);

$data = array();

if ($result) {
    while ($row = mysqli_fetch_assoc($result)) {
        $country = new Country();
        $country->name = $row["Name"];
        $country->code = $row["Code"];
        $country->continent = $row["Continent"];
        $country->region = $row["Region"];
        $country->surfaceArea = $row["SurfaceArea"];
        $country->population = $row["Population"];
        $country->headOfState = $row["HeadOfState"];


        array_push($data, $country);
    }
}
echo json_encode($data);

$conn->close();
