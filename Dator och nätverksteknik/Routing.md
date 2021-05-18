> Hur många IP-adresser har vanligtvis en **router**?
Två stycken, en mot WAN (wide area network) och en mot LAN (local area network)
 
> Hur vet en **router** vilka datapaket som den skall transportera vidare och var den skall skicka dem?
Den vet detta med hjälp av routingtabellen som är lagrad i routerns minne, denna tabell innehåller IP-adresser som då routern kommunicerar med.
 
> Förklara i 5 steg hur kommunikationen inom nätverk och routrar går till?
1. En host försöker kommunicera med en annan host, kontrolleras först om paket ska till någon på det lokala nätverket eller om det ska ut på det externa nätet.
2. Om det är en lokal adress skickas den dit, annars om det är en extern adress så skickas den till en angiven default gateway (routern).
3. Routern kontrollerar sedan om destinationen finns i routingtabellen för att se om det finns en väg till denna remote host.
4. Om den inte hittar en väg (route) i routingtabellen så skickas den istället till routerns default gateway (en annan router).
5. Sedan upprepas steg 3 och 4 på den nya routern tills paket har nått sin mottagare.
 
> Vad kallas det när en router vidarebefordrar paket till en annan router?
Hop (metric)
 
> Förklara vad som menas med TTL?
TTL står för time to live och det är antalet hop som oaktat kan göra mellan varje routerhopp innan det förstörs.
 
> Vad kallas routing metoden där routingtabellerna måste konfigureras manuellt?
Statisk routing
 
> Vad kallas routing metoden där routingtabellerna uppdateras automatiskt? 
Dynamisk IP-routing

