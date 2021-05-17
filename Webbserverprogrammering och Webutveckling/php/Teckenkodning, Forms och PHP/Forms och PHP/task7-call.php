<!DOCTYPE html>
<html lang="sv">
<head>
    <meta charset="utf-8">
    <title>Task 7 call page</title>
</head>
<body>
<?php
    $q1 = $_POST['q1'];
    $q2 = $_POST["q2"];
    $q3 = $_POST['q3'];
    $q4 = $_POST["q4"];

   
   
    $q1Answer = "<?php PHP kod ?>";
    $q2Answer = "Ett formulär är ett dokument (skriftligt eller elektronisk) med områden där man kan skriva data.";
    $q3Answer = "index.php
    <form action=\"myActionPage.php\" method=\"post\">
        <p>
            <label for=\"inputName\">Name: </label>
            <input type=\"text\" name=\"name\">
        </p>
        <input type=\"submit\" value=\"Submit\">
    </form>
    ";
    $q4Answer = "<?php \$foo = 12.5; ?>";

    $correct = 0;

    $q5a = isset($_POST["q5a"]);
    $q5b = isset($_POST["q5b"]);
    $q5c = isset($_POST["q5c"]);
    $q5d = isset($_POST["q5d"]);
    $q5e = isset($_POST["q5e"]);

    if($q5a == 1 && $q5b == 1) {
        if($q5c != 1 && $q5d != 1 && $q5e != 1){
            $correct++;
        }
    }
    
    echo "<p>Du fick $correct / 5 rätt</p>";
    if($correct >= 0 && $correct <= 2) echo "Läs på mer och försök igen";
    else if($correct >= 3 && $correct <= 4) echo "Godkänd";
    else if($correct >= 5) echo "Bra, du behärskar det mesta.";
?>
</body>
</html>
