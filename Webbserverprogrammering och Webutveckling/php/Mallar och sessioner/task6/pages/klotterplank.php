<section>
    <h3>Klotterplanket</h3>
    <?php
    if (!isset($_SESSION['inLoggad'])) header("Location: index.php?page=login");
    ?>

    <form action="./inc/saveMessage.php" method="POST">
        <label>Meddelande</label><br>
        <textarea name="message" cols="45" rows="5"></textarea><br />
        <input type="submit" value="Skicka">
    </form>

    <?php
    if (file_exists("./inc/message.dat")) echo file_get_contents("./inc/message.dat");
    ?>

</section>