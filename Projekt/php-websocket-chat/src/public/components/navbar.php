<?php

echo '<ul>';

if ($_GET["username"] ?? false) echo '
<li><a href="./chat.php">Chat</a></li>
<li><a href="./logout.php">Logout</a></li>
';
else {
  echo '
  <li><a class="active" href="./index.php">Sign in</a></li>
  ';
}

echo '</ul>';
