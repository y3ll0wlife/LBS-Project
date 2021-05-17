### Förklara vad en brandvägg (firewall) är och vad den gör

En brandvägg kan ses som ett staket runt ditt hus som skyddar ditt hus från rånare och tjuvar, men istället så är en brandvägg ditt dators staket som skyddar dig från illvillig personer. Brandväggen sätts vanligtvis mellan det interna nätverket och det publika nätverket och övervakar all trafik mellan de två punkter, både ingående och utgående trafik.

Brandväggen skyddar det interna nätverket genom att filtrerar nätverket från de reglerna som du sätter upp. En enkel brandvägg kollar enbart vart trafiken kommer ifrån och vart den ska, och tar bort den trafik som kommer från kända illvillig ip adresser. Detta går att konfigurera i reglerna på brandväggen, där du kan till exempel stoppa all trafik från X ip adress men tillåta trafik från Y ip adress och vilken port som detta går att köras på.

Brandväggar kan även genomsökningar av trafiken även känt som dynamic packet filter, som skyddar mot attacker som använder sig av transport lager protokoll. Dynamic packet filter kollar även om trafiken kommer från en betrodd källa och en riktigt klient skickar dem, alltså inte en fejkad request.

Det finns även host based brandväggar, som enbart fungerar på din maskin. Det fin även nätverks baserade brandväggar som sitter mellan det interna nätverket och det publika nätverket och skyddar alla på nätverket. Denna kan komma i olika typer, dedikerade brandväggar, som inbyggt i routern eller i molnet. Det går att använda en kombination av de två för ökad säkerhet.

### Vad är NFTABLES och hur fungerar detta?

NFTABLES är ett paket filtrings ramverk i Linux och var skapat för att ersätta IPTABLES som var byggt och utvecklat för flera år sedan. NFT är i ett nötskal använt för att manipulera, skicka och undersöka trafik på nätverket och kan bestämma vilka paket som ska bli skickade vart under olika orsaker som du bestämmer. Till exempel du vill nog inte att människor som du inte vet ska ansluta till ditt nätverk, så du kan du säga döda den trafiken när dem ansluter. NFT kan även göra det möjligt att skapa ett privat nätverk och sätta upp en säker miljö där använder får olika lov att göra olika saker.

Hur fungerar det då?
Jo, NFT fungerar genom att du skapar olika regler och vad som ska hända med olika typer av trafik. Till exempel om vi vill blockera all trafik från ip adressen 1.2.3.4.
`$ nft add rule ip foo input ip daddr 1.2.3.4 drop `
Alla kommandon körs från en kommando konsol.

Själva syntaxen och strukturen ser ut på detta sättet
Det finns tables, chains och regler. Tables har chains och chains har regler. Alla kommandon börjar med nft följt av en handling som add, delete, list.
`$ nft add chain [<family>] <table-name> <chain-name> { type <type> hook <hook> priority <value> \; [policy <policy>] }`

### Vad är IPTABLES och hur fungerar detta?

IPTABLES är likt NFTTABLES, brandväggar i linux, men är ett äldre ramverk och likt NFTABLES bestämmer vilken trafik som får komma in på nätverket och gå ut på det publika nätverket genom tables. Tables har chains som har regler (likt NFTABLES), som då filtrerar trafiken på nätverket.

När ett packet (datan i trafiken) matchar en av reglerna kommer den bli ett target, detta target kan bli en av 3 saker

- accept (detta är ett okej packet och skickar igenom det)
- drop (detta är inte okej, och stoppar paketet)
- return (stoppar packet från att gå vidare i chain och skickar tillbaka den till en tidigare chain)

Så hur funkar detta?
Jo, likt NFTABLES så använder vi oss av kommandon i kommandon konsolen för att bestämma olika regler och chains. För att ska ett chain regel kör vi följan de kommando
`$ sudo iptables -A <chain> -i <interface> -p <protocol (tcp/udp) > -s <source> --dport <port no.> -j <target>`

Skulle vi till exempel vilja blockera trafik från ip adressen 1.2.3.4 så kör vi följande kommando
`$ sudo iptables -A OUTPUT -d 1.2.3.4 -j DROP`

### Vad är skillnaden mellan NFTABLES och IPTABLES

Skillnaden NFTABLES och IPTABLES är att NFTABLES är enklare att använda och kombinera alla verktyg från alla IPTABLES ramverk (som iptables, ip6tables, arptables) till ett. Syntax skiljer de båda två också väldigt mycket, där NFTABLES är enklare och bättre än IPTABLES. I NFTABLES finns det även inga förskapade tables och chains vilket finns IPTABLES. Skillnaden mellan IPTABLES och NFTABLES för att blockera en viss ip adress:

IPTABLES: `$ sudo iptables -A OUTPUT -d 1.2.3.4 -j DROP`
NFTABLES: `$ nft add rule ip foo input ip daddr 1.2.3.4 drop`

En annan skillnad är att NFTABLES är snabbare och mer effektivt än IPTABLES., och det går även snabbare att konfigurera i NFTABLES då du kan exekvera flera kommandon i samma rad, vilket kan reducera mängden rader kommandon som du behöver köra för sätta upp din brandvägg på din maskin.

### Nämn 4 saker du kan göra med IP kommandot i Linux

För att få en lista med alla nätverket enheter och deras ip adresser kan du använda dig av kommandot, det går även att bara vissa deras IPv4 eller IPv6 adresser genom att använda -4 addr eller -6 addr retrospektivt.
`$ ip addr show`

Om du vill sätta en ip adress till en specifikt enhet kan du använda dig av följande kommando, där `ADDRESS` är den ip du vill sätta, och `IFNAME` är enhets namns exempelvis eth0.
`$ ip addr add ADDRESS dev IFNAME`
`$ sudo ip address add 192.168.121.45/24 dev eth0`

För att ändra statusen på en enhet så användes följande kommando. Detta för att ändra om en enhet ska vara online eller offline.
`$ ip ip link set dev {DEVICE} {up|down}`
`$ ip link set eth0 up`

För att ta reda på vilka routes som finns på Linux systemet så går det att använda följande kommando, som visar alla routes som är tillgängliga på ditt system.
`$ ip route list`
