Hej.

Lite instruktioner till programmet:

Börja med att starta apache i XAMPP.
Sedan i huvud delen av projeket (där du ser bin, src, vendor mapparna)
Skriv:
> php ./bin/server.php

Då borde servern skriva tillbaka
> Server started....

Om inte testa att köra kommandon (om du inte har composer installerat går det att ladda ner här https://getcomposer.org/download/)
> composer install 
> composer update

Navigera sedan till din 127.0.0.1:PORT/src/public (där PORT är din apache port). Där du kan välja ett användarnamn och sedan kan du börja chatta.

Om du inte server något i chatten när du skickar ett medelande i chatten, öppna din webläsares konsol och kolla om du ser ett medelande som säger.
> Connection Established...

Om inte så lyckades hemsidan inte kopplas till din server :( , har inte stött på detta problemet själv med vet att det kan hända.

Hoppas detta hjälper
/ Philip