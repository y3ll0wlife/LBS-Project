<!DOCTYPE html>
<html lang="sv">
<head>
    <meta charset="utf-8">
    <title>Task 5 call page</title>
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

    if($q1 == $q1Answer) $correct++;
    if($q2 == $q2Answer) $correct++;
    if($q3 == $q3Answer) $correct++;
    if($q4 == $q4Answer) $correct++;

    echo "<p>Du fick $correct / 4 rätt</p>";
?>
</body>
</html>
