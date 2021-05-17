### Föklara den typ av minne som användes i Apollo raketernas datorer.

Kärnminne (Magnetic-core memory) är ett primärminne för datorer, och är uppbyggt av ringar av ferritkärnor (magnetiskt material). Minnet fungerar genom att kärnorna magnetiseras i olika riktningar och beroende på om det på den polarisationsriktning som en 1 eller 0. Utläsningen av data sker i olika lästrådar.

### Förklara hur en bussbredd kan påverka prestandan

Bussbreden säger hur mycket en buss kan överföra mellan olika delar i datorn. Låt säga att bussbredd är 256 bitar då kan den skicka 256 1or och 0or samtidigt. Detta gör att gör om bussbredden är större så kan går det att ändra information snabbare då du kan skicka data snabbare.

### Vad är ett hålkort(punchcard) och vad har dom används till?

Hålkorten även känt som Hollerith cards och IBM cards, dessa är papper kort med hål som var inslagna med hand eller av en maskin som representerade data och instruktioner till datorer. Dem användes för att mata in data i tidiga datorer, korten matades in i en kortläsare ansluten till datorn som konverterade hållen på kortet till digital data. Dem användes då dem tidiga datorerna inte kunda spara information och data som våra datorer gör idag. Om du vill skapa ett program eller fil och dela den med andra datorer var med hjälp av dessa hållkort.

### Vad är OpenCL och Cuda?

OpenCL (Open Computing Language):
OpenCL är en öppen och oberoende standard för parallell programmering över olika plattformer. OpenCL fungerar även på FPGas, CPuer och GPUer.

Cuda (Compute Unified Device Architecture):
Cuda är en parallell datorplattform och programmeringsmodell skapad av Nvidia. Cuda gör det möjligt att utveckla snabba och datorintensiva applikationer genom att utnyttja kraften hos GPUer delar av beräkningen.

### Vad är skillnaden mellan en hårddisk och en SSD?

Skillnaden mellan en hårddisk och en SSD är att SSD är här snabbare, väger mindre och är mer hållbara (då den saknar rörliga delar inuti sig).

### Hur mycket data får i verkligheten plats på en hårddisk som säljs i en butik som 4TB(terabyte)

4 _ 1000 _ 1000 _ 1000 _ 1000 = 4000000000000 (bytes tillverkare)
4 _ 1024 _ 1024 _ 1024 _ 1024 = 4398046511104 (bytes dator)

4398046511104 - 4000000000000 = 398046511104 (skillnaden)
398046511104 bytes = 398.046511 gigabytes = 0.398046511 terabytes
4 - 0.398046511 = 3.601953489 TB

Vi kommer att få ungefär 3.602 TB i verkligheten.

### Vad är Sata?

Sata är ett dataöverföringsgränssnitt mellan lagringsmedierna.

### Nämn 5 udda format för att spara information

Flexidisc, Large Reel-toReel Audio Tapes, PD (Phase Change Dual), Stringy Floppy, Iomega Click! Disk

### Vilken anslutning har idag nästan helt ersatt mSata i bärbara datorer

M.2 (före detta Next Generation Form Factor)

### Vad står NVME för?

Non-Volatile Memory Express

### Förklara dessa 3 filsystem: NTFS, EXT4 och FAT32 (Vad dom används till och om dom har för eller nackdelar)

NTFS (New Technology File System):
NTFS är ett filsystem utvecklat av Microsoft och är en vidareutveckling av FAT32, med stor kompatibilitet med andra enheter och operativsystem. NTFS har även flera säkerhetsfördelar och möjligheter till kryptering av filerna.

Det negativa med NTFS är att det inte går att skriva till Macs utan speciella program.

NTFS är bra för interna och externa hårddiskar (samt USB minnen) som användes i en Windows miljö.

EXT4:
EXT4 är det vanliga filsystemet för Linux datorer och Naser.

Det negativa med EXT4 är att det enbart går att använda på Linux då Windows eller Mac kan inte läsa eller skriva direkt till EXT4 hårddiskar.

EXT4 användningsområden är för en portabel lagringen för stora filer, dock fungerar sällen i mediaspelare etc.

FAT32 (File Allocation Table):
FAT32 är ett av dem äldre filsystem, det har funnits sedan Windows 95 men användes även idag dock i begränsad utsträckning. Filsystemet tillåter endast filer med en maximal storlek på 4GB och för det andra så är den maximala storlek på en partition 32GB. Vilket betyder att om du har en 500GB hårddisk så kommer den behövas dela upp i 16 delar (500/32~15.6) som kommer att ses som 16 olika hårddiskar på din dator. FAT32 är även väldigt utdaterad i säkerhetsfunktioner.

Dock det positiva med FAT32 är att det går att läsa och skriva till princip alla enheter och operativsystem.

Dock har du ett USB minne som är 32GB är FAT32 otroligt bra för den användningen.

### Vad är en partition?

En partition kan enkelt förklaras som en del av hårddisken, men delar alltså upp de olika delarna på hårddisken i mindre bitar. Till exempel kan man ha en Windowsinstallation på en bit (partition) och en Linuxinstallation på en annan bit (partition).

### Vad är defragmentering?

Defragmentering är en sammansättning av fragmenterade filer till sammanhängande filer. Defragmentering gör att hårddisken blir snabbare och frigör utrymme på den.

### Vad är Trim?

TRIM är ett kommando som kan berätta för SSDen vilket datablock som inte längre behövs och kan raderas.

### Om jag har 3 diskar i min dator och vill kunna använda så mycket utrymme som möjligt men ändå vill ha en säkerhet om en disk går sönder, vilken typ av RAID bör jag använda mig av?

- [ ] Raid 1
- [ ] Raid 0
- [x] Raid 5
- [ ] Raid 6

### Hur mycket minne skulle du rekomendera till en kontorsdator och varför?

Jag skulle rekommendera 8GB då det är tillräckligt mycket minne för att göra det mesta som man vill göra på ett kontor, vilket är oftast att kunna läsa och skriva data till något program och använda sig utav en webbläsare. Exempelvis Excel eller Firefox. Eventuellt så skulle man kunna ha 16GB då om du ska göra något lite mer krävande så kan mer minne underlätta.

### I vilka läsare kan jag använda ett SDHC-kort?

- [ ] SD
- [x] SDHC
- [x] SDXC

### Bonus fråga: Du ska bygga en filserver åt en vän du har fått 8000kr att göra deta detta. Vilka delar skulle du använda? Vilket operativsystem skulle du använda? Vilken typ av raid skulle du använda? Motivera ditt val av raid och operativsystem.

Inet kundvagn: https://i.imgur.com/Y6svSsA.png

Thermaltake Core V1:
Vi behöver helt enkelt ett simpelt chassi som inte är allt för stort så jag bestämmde mig för detta, som också var väldigt prisvärt.

AMD Ryzen 3 3200G 3.6 GHz 6MB:
Detta är CPUet som vi kommer att använda det är ett AMD Ryzen som är strömsnålt och kraftfullt, vilket blir perfekt till våran server. Det är även kompatibilitet med vårat moderkort.

Gigabyte B450 I AORUS PRO WIFI:
Detta är moderkort som kommer att användas. Jag valde ett modekort där vi kan uppgradering de olika komponterana i dator under tidens gång, detta moderkortet har 2 RAM platers och 4 Sata 6.0 gbit/s, det är även kompatibilitet med våran CPU.

HyperX 8GB (2x4GB) DDR4 2400MHz CL15 Fury:
Detta är vårt RAM, detta är något som jag skulle vilja ha högre men det fick bli vad det blev då vi är lite på en budget. Detta är ett snabbt DDR4 minne som är kompatibilitet med AMD och har en hög minnesfrekvens.

Seagate IronWolf 4TB 5900rpm 64MB:
Jag har valt att gå för 2 stycken 4TB seagate IronWolfs som min lagringens metod, då vi kommer att använda oss utav RAID 1 som enbart funkar för 2 diskar.

be quiet! SFX-L Power 500W:
Vi vill bara ha en enkel och fungerade men också tyst nätaggregat till servern.

Vilket operativsystem skulle du använda?
Vi kommer att slänga Windows Server på denna då vår vän inte är direkt datavana och är van med Windows som sitt operativsystem. Som ett annat val kan vår vän använda sig utav Ubuntu Server, men då han är mer van med Windows så tänkte jag att Windows server är det bättre valet.

Vilken typ av raid skulle du använda?
Vi kommer att använda oss utav RAID 1, vilket ger oss 50% säkerhet på en disk om något skulle gå snett. Jag skulle helst vilja ha RAID 5 men vi hade inte pengarna till en till hårddisk så det fick bli vad det blev.
