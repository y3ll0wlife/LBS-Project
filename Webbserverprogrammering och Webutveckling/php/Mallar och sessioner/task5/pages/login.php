<section>
    <?php

    mb_internal_encoding("UTF-8");

    if (isset($_POST["password"])) {
        if ($_POST['password'] == '12345' && $_POST['username'] == 'admin') {
            $_SESSION['inLoggad'] = true;
            $_SESSION["loggedUsername"] = $_POST['username'];
            $_SESSION['loggedPassword'] = $_POST['password'];

            header("Location: index.php");
        } else {
            echo "Fel lösenord eller användarnamn";
        }
    }
    ?>

    <form method="POST">
        Username: <input type="text" name="username" required><br />
        Password: <input type="password" name="password" required><br />
        <input type="submit" value="Login">
    </form>

</section>