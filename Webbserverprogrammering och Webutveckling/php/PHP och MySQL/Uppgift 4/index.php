<?php session_start(); ?>
<!DOCTYPE html>
<html lang="sv">

<head>
  <meta charset="utf-8">
  <title>Sessioner</title>
</head>

<body>
  <?php
  if (isset($_SESSION['user_id'])) include 'private.php';
  else include 'public.php';
  ?>
</body>

</html>