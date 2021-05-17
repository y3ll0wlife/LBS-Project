### Vad är ett formulär?
Ett formulär är ett dokument (skriftligt eller elektronisk) med områden där man kan skriva data.

### Med vilka metoder kan man skicka data från ett formulär?
Inom HTML + PHP så kan man skicka data genom att säga i `<form>` taggen som skrivs i början, vilken mod samt eventuell sida som datan ska skickas. `<form action="/myActionPage.php" method="post"`, detta skicka en HTTP post request till den php sidan som kan hantera requesten. Det går även att göra en `GET` request med denna metoden genom att byta ut `post` till `get` i form taggen.

### Mellan vilka taggar skriver man php-kod? 
`<?php` PHP kod `?>`

### Visa hur man deklarerar och tilldelar en variabel värdet 12,5.
```
<?php
$foo = 12.5;
?>
```

### Hur tar en php-sida emot data från ett formulär.
index.php
```
<form action="myActionPage.php" method="post">
    <p>
        <label for="inputName">Name: </label>
        <input type="text" name="name">
    </p>
    <input type="submit" value="Submit">
</form>
```

myActionPage.php
```
<h1>Name: <?php echo $_POST["name"]?></h1>
```

### Hur anger man till vilken sida ett formulärs data skall skickas?
Du väljer detta i action attributet på form taggen `<form action="/myActionPage.php" method="post"`, i detta fallet skulle sidan skicka datan till `myActionPage.php`

### Ge exempel på hur man kan skicka värdena “Stig” och 10,6 till en php-sida m.h.a en länk?
index2.php
``` 
<a href="phpUrl.php?foo=Stig&bar=10.6"> Click me $GET </a>  
```

phpUrl.php
```
<h1>Foo: <?php echo $_GET["foo"]?></h1> <br>
<h1>Bar: <?php echo $_GET["bar"]?></h1>
```

### Med vilken metod tar en php-sida emot data från en länk?
```
[URL: https://mycoolwebsite.gov?foo=hello&bar=world]
<?php
echo $_GET['foo'] . " " . $_GET['bar']; // hello world
?>
```
