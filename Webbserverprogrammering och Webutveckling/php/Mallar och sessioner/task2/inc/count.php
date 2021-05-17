
<?php
function countUp()
{
    $hit = 0;
    if (file_exists("./inc/hit.dat")) $hit = file_get_contents("./inc/hit.dat");
    $hit++;
    file_put_contents("./inc/hit.dat", $hit);
}

function getCount()
{
    $hit = 0;
    if (file_exists("./inc/hit.dat")) $hit = file_get_contents("./inc/hit.dat");

    return $hit;
}


?>

