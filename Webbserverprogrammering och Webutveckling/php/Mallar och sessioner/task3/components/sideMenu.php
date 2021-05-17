<nav>
    <?php
    include("./inc/count.php");
    echo "<h5> Besökare: " . getCount() . "</h5>";
    ?>
    <h1>Innehåll</h1>
    <ul>
        <li><a href="index.php">Hem</a></li>
        <li><a href="index.php?page=blogg">Blogg</a></li>
        <li><a href="index.php?page=bilder">Bilder</a></li>
        <li><a href="index.php?page=kontakt">Kontakt</a></li>

        <?php
        if (isset($_SESSION['inLoggad'])) {
            echo '<li><a href="index.php?page=logout">Logga ut</a></li>';
        } else {
            echo '<li><a href="index.php?page=login">Logga in</a></li>';
            echo '<li><a href="index.php?page=signup">Skapa ett konto</a></li>';
        }

        ?>



    </ul>
</nav>