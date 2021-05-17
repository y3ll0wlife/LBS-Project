<section>
    <?php
    include_once("./inc/treatMessage.php");

    echo "<h3>" . softTreatMessage($_GET["message"] ?? "") . "</h3> <br>";
    ?>
    <form action="./inc/newUser.php" method="POST">
        Username: <input type="text" name="username" required><br />
        Password: <input type="password" name="password" required><br />
        <input type="submit" value="Sign up">
    </form>

</section>