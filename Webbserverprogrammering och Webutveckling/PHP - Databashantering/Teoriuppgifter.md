> Ge exempel på 3 andra databashanterare förutom MySQL.

- PostgreSQL
- Microsoft Access
- Oracle Database

> Vad är en relationsdatabas?

En relationsdatabas är en databas typ som gör det möjligt att dela upp fält och poster i andra tabeller istället för att ha en lång. Man accessoarer detta med hjälp två nycklar. En främmande nyckel som kopplas till en annan tabell genom deras primärnyckel. Detta gör det möjligt att organisera en databas och strukturerar den på ett lätt sätt.

> Vad är en post?

Post även känd som varje rad i en tabell, posten innehåller information som kallas fält.

> Vad är ett fält

Ett fält är information som du sparar i databasen, varje fält har olika attribut som varchar och int.

> Förklara begreppen primärnyckel och främmande nyckel. Hur används dessa för att koppla ihop data i olika tabeller?

Primärnyckeln är ett värde som skapar ett unikt värde för varje post i en tabell. Exempelvis post 1 kommer ha primärnyckeln 1 och post 2 kommer ha primärnyckeln 2 och så vidare. Primärnyckeln kan ses som indexet för alla poster som stoppas in i en tabell.

Den främmande nyckeln är ett värde på en primärnyckel i en annan tabell. Som kan användas för att koppla ihop två tabeller för att skapa en relation.

> Vad är fördelar respektive nackdelar med att tilldela fält index?

Att ge ett fält index kan göra det lättare att söka i tabellen och kan ge dig det du söker efter snabbare, dock om du har många index i en tabell kan det däremot gör att sökning blir långsammare och tar längre tid. Det är därför viktigt att bara indexa delar som är nödvändiga.
