<!doctype html>
<html lang="sv">

<head>
	<meta charset="utf-8">
	<title>Länka in sidor med PHP</title>
	<link href="css/styleSheet.css" rel="stylesheet" type="text/css">
</head>

<body>
	<div id="wrapper">
		<?php include("./components/header.php") ?>

		<!-- header -->

		<section id="leftColumn">
			<?php include("./components/sideMenu.php") ?>
			<?php include("./components/sideName.php") ?>
		</section>
		<!-- End leftColumn -->

		<main role="main">
			<?php
			include_once("./inc/count.php");


			$page = "home";
			if (isset($_GET["page"])) {
				$page = $_GET["page"];
			}

			if (file_exists("./pages/" . $page . ".php"))
				include("./pages/" . $page . ".php");
			else
				include("./pages/home.php");
			?>
		</main>
		<!-- End main -->

		<?php include("./components/footer.php") ?>
		<!-- End footer -->
	</div>
	<!-- End wrapper -->
</body>

</html>