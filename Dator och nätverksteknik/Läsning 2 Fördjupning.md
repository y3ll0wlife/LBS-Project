### Vad var speciellt med Slot 1/Slot A?  
Slot 1 var speciell då Intel la till stöd för symmetrisk multiprocessing (SMP).  
Slot A var speciell då den gav stö för en högre bus hastighet, dock var den mekaniskt kompatibelt men elektriskt inkompatibelt med Slot 1.  


### Vad står PGA och LGA för?  
PGA: Pin Grid Array  
LGA: Land grid array  

### Hur mycket ram kan använda som max i en dator som har ett 32 bitars operativsystem?  
Du kan använda 4 gigabytes (4,294,967,296 bytes) RAM i en dator som har ett 32 bits system, dock beroende på operativsystem kan denna siffran vara lägre och kan få dig att hamna run 3.5 gigabytes.  

### Vad är processor cache?   
En CPU cache är en hårdvarucache som används av CPUen för snabbare kunna leverera data till CPU snabbare än RAMet eller dators hårddisk. Detta för att CPUen vill ha information snabbare än vad RAMet kan leverera så då kommer datorn att bli segare och kommer inte göra något fören RAMet har skickat datan som CPUet vill ha.  

### Vad är skillnaden mellan ARM och x86?  
ARM har RISC (Reduced Instruction Set Computing) arkitektur medans x86 har en CISC (Complex Instruction Set Computing) arkitektur. ARM har fler register och har stöd för de flesta instruktioner innan Intel lade till dem. ARM har en simplare arkitektur vilket leder till en mindre silikon area och mängder av energi spararar funktioner medans x86 är mer kraftfull i både energiförbrukning och produktion.  

### Förklara vad multithreading är och vad det gör  
Multithreading är förmågan för ett program eller operativsystemets process att kunna ha fler än en trådar samtidigt, vilket gör det möjligt att kunna hantera flera begärande från användaren samtidigt utan att köra flera kopiera av samma program samtidigt.  

### Vilken av dessa processorsocklar är Intel? 
- [ ] AM4
- [X] LGA1151  
 
### Förklara hur en CPU i en dator fungerar och vad den gör.   
En processor även känd som CPU är den logiska kretsen som svara och bearbetar inmatning, lagring av data och utdata som i sin tur driver datorn och får den att fungera. Man kan säga att CPUet är hjärnan i datorn. CPUets jobb är att följa instruktioner som berättar om vilken data som ska bearbetar och på vilket sätt den ska bearbetas. Ett exempel är att en simpel kalkylator app skickar en instruktion till CPUet som säger att ta två nummer och lägg ihop dem och skicka tillbaka resultatet.   
  
### Hur kan en dator addera tal?  
Datorn göra detta med hjälp utav ALU (Aritcmetic &  Logic Unit). ALU är två delar i en Aritcmetic unit och en Logic Unit. Aritcmetic unit hanterar alla numeriska operationer så som addition och subtraktion. Låt säga att vi har 7+6 då ställer vi upp följande beräkning. Först måste vi konvertera decimalnummer till binära nummer, då datorer bara kan jobba med 1or och 0or. Datorer har enkel addition och subtraktion redan programmet så här är ett exempel på hur datorer gör matte.

Då får vi:
```
7: 0111
6: 0110

 0111
+0110
------
    1
```
Första sloten blir 1 då vi tar det största nummret från den
```
 (1)
 0111
+0110
------
   01
```
Då datorer bara kan spara 1or och 0or kan vi spara en tvåa här så sätter det som 0 och flyttar vidare en etta till det nästa ledet.
```
(1)1 
  0111
+ 0110
------
   101
```
Här blir det som förra sloten fast istället så har vi ju 3 ettor så då kan vi flytta ner en etta och flytta vidare en etta till det nästa nästa ledet.
```
 1 
 0111
+0110
------
 1101
```
1 0 0 där har vi det största talet 1 så då stoppar vi in den i vår uträkingen och vi är klara svaret blir 1101 vilket i decimal nummer är 13 vilket är det svaret vi ville ha.  

### Ta reda på vad en GATE/Grind är och förklara hur en transistor i en CPU kan användas som en GATE/Grind
En GATE/Grind är en beteckning på en elektronisk funktion, som i datorer genomför en logisk funktion som AND eller OR.

I transistor är en GATE/Grind som bestämmer ifall transistorn ska skicka igenom ström eller stoppa strömmen. Detta med hjälp utav olika logiska funktioner som AND eller OR.  



