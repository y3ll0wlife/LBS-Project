<?php

$_SESSION = array();
session_destroy();
session_regenerate_id(true);

header("Location: index.php");
