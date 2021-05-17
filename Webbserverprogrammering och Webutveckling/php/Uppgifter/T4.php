<!DOCTYPE html>
<html>
    <body>
    <?php
     $age = 166;

     if ($age >= 18 && $age <= 25) echo "Grattis du är över 18 år";
     else if($age > 25) echo "Wow, du är över 25!";
     else   echo "Du är under 18 år, kom tillbaka om några år.";
    ?>
    </body>
</html>