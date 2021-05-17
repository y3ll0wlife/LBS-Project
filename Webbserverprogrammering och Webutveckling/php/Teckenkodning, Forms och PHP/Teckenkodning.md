### Beskriv likheter och skillnader mellan UTF-8 och ASCII.
ASCII är alla karaktär, alla siffor och symbol som spelar roll. Alltså (a-Z, A-Z, +, +, -, /, “, !) som representeras som ett nummer mellan 32 och 127 och är en gammal teknik.

UTF-8 är en standards där varje kod del mellan 0 och 127 är sparat i en byte, över 128 är 2, 3 bytes upp till 6 bytes.

Den största skillnaden är hur karaktärerna är kodat, ASCII använder sig av ett 8 bit kodning sätt medans UTF-8 använder sig av en variable bit. UTF-8 är standiserat medans ASCII är inte. UTF-8 har stöd för de flesta skriva språken i världen medans ASCII har inte det. 

Det som gör dem lika är att båda är sätt att spara text som sedan kan visas för användaren.


### Vad är mb_-funktioner i PHP?
MB funktioner eller också känt som multibyte string functions är funktioner som gör det möjligt att kunna använda strings som är flera bytes. Detta är något som PHPs vanliga string funktioner inte har stöd för. 

### Om jag endast skall skriva ut siffror, behöver jag då ange vilken teckenkodning som används? Motivera! Här får du undersöka och tänka, alternativt använda google.
I dagens samhälle, där programmen oftast automatisk ändrar vilken teckenkodning som används (det är vanligast att dem använder UTF då det är standiserat) så skulle jag säga nej till att om det behöver ange i för handen vilken som ska användas. Dock så kan det i detta fallet vara bättre att använda ASCII om vi enbart vill skriva ut siffror då alla siffror från 0-9 finns i ASCII. Att använda ASCII istället för UTF-8 kan vara effektivt då om vi behöver bokstaven `C` i stringen `str="ABC"` så kan man i de flesta språken bara kalla på `C` genom att skriva `c=str[2]`, vilket hade om stringen är inkodad i ASCII, hade bara hämtat den tredje biten från den stringen. Detta är något som inte är möjligt i UTF-8 där man måste kolla alla karaktär om dem är 1 eller 2 bytes vilket tar längre tid än att bara hämta den tredje biten.