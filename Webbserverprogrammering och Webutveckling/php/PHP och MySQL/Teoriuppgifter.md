> Vad är en SQL-injektion.
En SQL injektion är när en angripare kan exekvera SQL kod på servern utan tillåtelse från server ägaren. Detta kan leda till att angriparen får lösenord och användarnamn som angriparen inte bör ha tillgång till. 

> Hur kan man skydda sig mot SQL.injektioner?
Det finns ett par sätt att skydda sig mot SQL injektioner, det viktigaste är att hantera och skydda ställen där det finns möjliga ställen för att användaren kan skicka in SQL i koden. Det går även att använda sig av parameterized statements för att skicka in SQL koden på ett mer säkert sätt