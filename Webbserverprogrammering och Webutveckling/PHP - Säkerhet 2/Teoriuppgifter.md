> Vad är en XSS-attack och hur kan man enkelt försvåra den. Varför skall man placera känsliga filer utanför webbroten?

XSS är en klientbaserad injektion attack. Som gör det möjligt för att kunna injekterar kod i hemsidan som sedan kommer att köras när användaren ser kod. Detta kan resultera i att användaren blir av med sina cookies eller gör det möjligt för angriparen att läsa filer på servern.

Ett enkelt sätt att försvåra XSS är att sanera all form text som användaren kan skicka till servern. Nedan följer ett exempel på sanering:

```php
function softTreatMessage($s)
{
    return str_replace("\\", "", htmlspecialchars($s));
}
```

Anledning till att placera känsliga filer utanför webbroten är på grund av att undvika användare att kunna nå dessa filer och enbart våra php filer ska kunna nå dessa filer.

> Varför skall man filtrera data från formulär och länkar (get)?

Anledning till att sanera data skickat från en användare är för att undvika att om en angripare vill ladda upp skadlig kod till hemsidan. Ett sätt är genom att använda `filter_input()` funktionen, med flaggan `FILTER_SANITIZE_FULL_SPECIAL_CHARS` för att ta bort felaktig teckenkod.

> Varför bör man använda PASSWORD_DEFAULT när man använder funktionen password_hash?

Det som `PASSWORD_DEFAULT` gör att den sätter den starkaste krypteringsalgoritmer som default, vilket idag är bcrypt, men i framtiden kanske det är något annat.

> Ge exempel på hur man kan försvåra sessionskapningar?

Ett rätt så enkelt exempel på detta är genom att förnya sessions nyckeln varje gång man loggar in och ut. I php använder man funktionen `session_regenerate_id()` och sedan passerar en boolean om man vill eller vill inte göra detta.

> Vad är TSL (eller SSL)?

TSL även känt som transport layer security är ett protokoll som stödjer krypterad kommunikation. För att kunna använda TSL måste det finnas på servern, sedan uppger man vilka kataloger som ska upprätta en säker anslutning med TSL. Alla detta är därefter krypterad och när man besöker en sida som stödjer kryptering ser man i adressfältet att det står `https` istället för `http`.

> Beskriv kortfattat följande attackmetoder.
>
> - XSS
> - CSRF
> - LFI

XSS: gör det möjligt för en angripare att injektera kod i en hemsida, vilket gör att när användaren besöker hemsida körs denna kod, vilket kan vara skadlig.

CSRF: gör det möjligt för en angripare att köra förfrågningar som användaren, vilket kan vara skadligt om användaren är inloggad på hemsidan. Vilket kan göra att angriparen kan byta inställningar, skicka pengar ändra lösenord med mera som användaren.

LFI: gör det möjligt för en angripare att komma åt lokala filer på servern som inte användaren ska komma åt egentligen.
