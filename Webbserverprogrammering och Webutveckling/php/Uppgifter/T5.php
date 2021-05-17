<!DOCTYPE html>
<html>
    <body>
    <?php
        date_default_timezone_set("Europe/Stockholm");
        $t = strval(date("H"));
        echo "$t <br>";

        if($t > "10") echo "Have a wonderful wonderful morning <br>";
        elseif ($t > "22") echo "Have a good day <br>";
        else echo "Go to sleep"

        
    ?>
    </body>
</html>