<section>
    <?php
    if (isset($_SESSION['inLoggad'])) {
        echo "<h1>Bilder</h1>";
    } else {
        echo "Du behöver ett konto för att se denna sidan";
    }
    ?>

</section>