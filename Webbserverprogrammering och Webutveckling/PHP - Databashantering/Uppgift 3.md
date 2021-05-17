> Skriv en fråga som filtrerar ut alla länder som slutar med ”land”.

```sql
SELECT * FROM `country`
WHERE NOT Name LIKE "%land"
```

> Skriv en fråga som beräknar hur många länder som slutar med ”land”.

```sql
SELECT COUNT(*) FROM `country`
WHERE Name LIKE "%land"
```

> Skriv en fråga som beräknar summan av alla länders invånare.

```sql
SELECT SUM(Population) FROM `country`
```

> Skriv en fråga som sorterar alla städer i sverige och finland i bokstavsordning.

Ser ut som att dem tror att Ö är ett O för i datan man får tillbaka är det Norrköping, Örebro, Oulu.

```sql
SELECT * FROM `city`
WHERE CountryCode = "SWE" or CountryCode = "FIN"
ORDER By Name ASC
```

> Skriv en fråga som visar alla länder med en yta mellan 500 och 1000 sorterade i storleksordning.

```sql
SELECT * FROM `country`
WHERE SurfaceArea > 500 AND SurfaceArea < 1000
ORDER By Name ASC
```

> Vad gör följande fråga? Kör INTE frågan om du inte gjort uppgift 3.

```sql
DELETE FROM country WHERE Name LIKE 'A%'
```

DELETE = säger att vi ska ta bort en eller flera poster  
FROM = säger att från denna tabell i detta fallet country tabellen  
WHERE = är våran sök del, i detta fallet där värdet på fältet Namn är likt `'A%'`  
A% = Säger alla värden som börjar på bokstaven A  

I detta fallet hade frågan tagit bort alla poster i tabellen country där deras fält Name börjar på bokstav A.  
