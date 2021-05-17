<section>
    <hgroup>
        <h1>Välkommen till Webbserverprogrammering 1</h1>
        <h2>Moment 3</h2>
    </hgroup>

    <?php

    if (isset($_SESSION['inLoggad'])) {;
        echo "<br> <h5>Välkommen tillbaka " . $_SESSION['loggedUsername'] . "</h5>";
    }

    ?>

</section>