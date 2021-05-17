<section>
    <?php

    mb_internal_encoding("UTF-8");

    if (isset($_POST["password"])) {
        if ($_POST['password'] == 'admin' && $_POST['username'] == 'admin') {
            session_regenerate_id(true);

            $_SESSION['CSRFToken'] = bin2hex(random_bytes(32));
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