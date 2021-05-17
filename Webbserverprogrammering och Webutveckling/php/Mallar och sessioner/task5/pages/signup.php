<section>
    <?php

    mb_internal_encoding("UTF-8");

    if (isset($_POST["password"])) {
        function strTreatment($s)
        {
            return str_replace(" ", "", str_replace("\\", "", strip_tags($s)));
        }

        $username = strTreatment($_POST["username"]);
        $password = strTreatment($_POST["password"]);

        echo "Välkommen till hemsidan";
    }
    ?>

    <form method="POST">
        Username: <input type="text" name="username" required><br />
        Password: <input type="password" name="password" required><br />
        <input type="submit" value="Sign up">
    </form>

</section>