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
    </ul>
</nav>