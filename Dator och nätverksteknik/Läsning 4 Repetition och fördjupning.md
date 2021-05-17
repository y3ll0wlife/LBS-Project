### Vad är port forwarding?

Port forwarding är att konfigurera routern till att göra det möjligt att från en dator eller annan nätverks enhet att kunna ansluta till en annan dator eller nätverks enhet utanför det lokala nätverket

### Vad är skillnaden mellan POP3 och IMAP?

Om du använder POP3 så kommer dina mail att sparas lokalt på din dator, endast en version kan endast finnas på en enhet. Detta då servern skickar vidare ditt mail direkt när du får det och sparar ingen kopia vilket kan vara dåligt om något händer med ditt mejl om du inte har några backups.

Istället om du använder IMAP så sparas ditt mejl på servern (din mail server) vilket gör det möjligt att hämta mailet på alla din enheter som behöver tillgång till det då den sparar ingen lokal kopia förutom en cache av mailet. IMAP sparar även din mapp struktur mellan dinna enheter.

### Vad är en grupp policy?

Grupp policys är en hierarkisk infrastruktur som gör det möjligt för en nätverks admin att kunna införa olika konfigurationer för användare och datorer på nätverket.

### Vad kan man göra med en grupp policy?

Grupp policys gör det även möjligt att kunna skicka uppdateringar, restriktioner av applikationer och säkerhets inställningar som skickas över nätverket och användare dator laddar ner dem när dem ansluter till internet.

Exempelvis en konfiguration för elever och en för lärare för att till exempel ge tillgång till ett privat lärare nätverket som inte eleverna ska kunna komma åt.

### Vad är SSH?

SSH eller Secure Shell är ett nätverksprotokoll som gör det möjlig att kunna fjärransluten till andra nätverksenheter på ett säkert sätt över ett eventuellt osäkert nätverk.

### Vad kan SSH användes till?

SSH användes vanligtvis för fjärrstyrningen av UNIX liknande OS samt för filkopiering med bland annat SFTP eller SCP. Ett exempel på ett vanligt användningsområde är att sätta på en SSH tunnel mellan 2 datorer då all trafik är krypterad mellan dem som sedan krypteras hos den mottagande datorn och sedan skickas vidare vart den ska.

### Vad är skillnaden mellan IPV4 och IPV6?

IPv4: `172.16.254.1`
IPv6: `2001:0db8:85a3:0000:0000:8a2e:0370:7334`

Den mest uppenbara skillnaden mellan IPv4 och IPv6 är storlek i format IPv4 använder sig utav ett 32 bits adress medans IPv6 använder sig utav en 128 bits adress, vilket gör det möjligt att ha 1 028 gånger fler adresser än vad IPv4 har. Vilket löser problemet som IPv4 har stött på att vi har slut på ip adresser.

### Vad står förkortningarna WAN och LAN för?

WAN: Wide Area Network
LAN: Local Area Network

### Förklara vad statisk och dynamisk IP address är

En statisk ip är när använder själv kan bestämma vilken ip adress som dem vill ha i ett nätverk. Vilket är användbart när man vill konfigurera en server och alltid behöver veta att det är samma ip som servern ligger på.

En en dynamisk ip är till skillnad från en statisk ip en automatisk ip adress tillgiven oftast av en DHCP servern när du ansluter till internet. Detta då det är slut på IPv4 adresser så du får en slumpad från en pool av ip adresser.

### Vad heter den arbetsgrupp som Windows datorer är förinställda att hamna i?

- [ ] Homegroup
- [x] Workgroup
- [ ] Wingroup
- [ ] DHCP

### Nämn 3 saker som påverkar hastigheten i ett trådlöst nätverk

- avståendet mellan routern och enheten
- eventuella störningar som finns mellan routern och enheten
  - fysiska hinder som vägar
  - men även radiostörningar
- hur många andra som använder nätverket när du utför dina tester

### Vad är ett nätverksrack?

Nätverksrack är fästanordningar med standardiserade mått som gör det möjligt för nätverksprodukter från olika leverantörer att kunna monteras tillsammans på ett snyggt och organiserat vis. Racken är vanligtvis 19 tum breda men det finns även 10 tum varianter. Höjden på dem bestämmer hur många unit (enheter) som beskriver den standardiserade höjden som rackmontera produkter har.

### Vad är link-aggregation?

Link-aggration är när du använder två eller flera trådbundna anslutningar tillsammans, detta är vanligt för prestanda Naser som har dubbla gigabit nätverkskort vilket gör det möjligt att ansluta två nätverkskablar till den vilket kan höja hastigheten till 2 Gb/s.

### Vad står POE för när man talar om nätverk?

- [ ] Power on Equpment
- [ ] Path of Exile
- [x] Power over Ethernet
- [ ] Path over Ethernet

### Förklara vad Homeplug är

En homeplug även känt som en powerline kan du sätta i ett vanligt eluttag och detta omvandlar eluttaget till ett nätverksuttag i ditt hem, detta är vanligt i äldre hus som inte har tillgång till dubbla nättverksuttag.

### Nämn två standarder (802.11) för trådlöst nätverk.

- Wireless B (802.11b)
- Wireless G (802.11g)

### Vad står Mimo för?

Multiple Input Multiple Output

### Om du skaffar en router som det står dual-band på, vad betyder det att den har stöd för?

Om din router har stöd för dual band betyder det att den kan ha två band ett för 2.4 GHz-bandet och ett för 5 GHz-bandet. Detta då många enheter fortfarande använder 2.4 GHz bandet men den är väldigt använd så det kan vara snabbare att använda 5 GHz bandet för dem enheter som stödjer det vilket gör dual-band perfekt för detta scenariot.

### Förklara WEP, WPA och WPA2

Dessa 3 metoder är protokoll för att kryptera trådlösa nätverk och är dem vanligaste i detta syftet.

WEP är en tidig krypteringsmetod som började att utvecklas när trådlösa nätverk blev populärt. Dock idag är WEP väldigt dåligt och säkerheten i WEP är väldigt bristande vilket gör det möjligt att avlyssna trafik och kunna knäcka krypteringsnyckeln efter ett par minuter.

WPA och WPA2 är båda vidare utvecklingar på WEP tekniken och även om WPA kan anses som mycket säkrare än WEP så finns det ännu bättre i form utav WPA som använder sig utav AES som är uppföljare till krypteringsmetod TKIP som användes i WPA, vilket gör det i princip omöjlig att avlyssna ett nätverk som använder sig av WPA2.

### Vad står PSK för och vad innebär detta tillägg?

PSK står för Pre-Shared key och är ett tillägg till WPA och WPA2 som underlättar processen att ansluta till ett trådlöst nätverk. Den gör detta genom att när första gången en användare ansluter till nätverket kommer en fråga om ett lösenord, om det stämmer så upprättas en anslutning.

Om ett nätverk inte har PSK krävs en speciell autentiseringsserver som kontrollerar enhet som ansluter till nätverket, detta protokoll kallas EAP och användes främst i större företag.

### Vad är WPS?

WPS gör det super lätt att ansluta till ett krypterat nätverket och tar bort de långa och krångliga lösenorden och byter ut det mot ett knapptryck på routern och enheten som ska ansluta.

### Förklara vad en VPN-tunnel är och vad den gör

En VPN tunnel är en krypterad anslutningen mellan två punkter på ett öppet nätverket (internet) och användes vanligtvis av företag som vill låta sina anställda att nå kontorets interna nätverk hemifrån på ett säkert sätt. VPN tunnel gör att ingen utomstående kan se innehållet i trafiken och din internetleverantör kan bara se mängden data som skickas men inte vad den innehåller.
