using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextäventyrBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            Random rnd = new Random();
            int accountRND = rnd.Next(1, 4); // used for the first part were get to see if your charc is destroyed or not
            int whatIsRandom = rnd.Next(1, 6); // for the random part in the charc creation

            int waitTimeBetweenText = 800;
            string strengths, favColor, bloodType, whatYouThinkAboutYourCreation, name, goToSleep, wayToSchool, goInCave, openChest, stillNotOpenChest; // all of the variables we are using
            string tasteIt = "";

            Console.WriteLine("Välkommen till Livskärna");
            Thread.Sleep(waitTimeBetweenText);

            // Character creation phase
            Console.WriteLine("\n\nVi ska nu påbörja med att skapa din karaktär");
            Thread.Sleep(waitTimeBetweenText);
            Console.WriteLine("Vilken är din karaktärs bästa styrka (Smart, Stark, Snäll)?"); // Strength used later
            strengths = Console.ReadLine().ToLower();
            Console.WriteLine("\nVilken är din karaktärs favoritfärg (Grön, Rosa, Gul, Blå, Turokise)?"); // Fav color used for nothing than costmetics
            favColor = Console.ReadLine().ToLower();
            Console.WriteLine("\nVilken är din karaktärs blodtyp (A, AB, B, C, D)?"); // Bloodtype used for surviving one thing
            bloodType = Console.ReadLine().ToLower();
            Console.WriteLine("\nSå vad tycker du om din karaktär?"); // Never used except the end of one thing (nvm never used)
            whatYouThinkAboutYourCreation = Console.ReadLine();
            Console.WriteLine("\nVad heter din karaktär?"); // Used for cosmetics
            name = Console.ReadLine();
            if(name.ToLower() == "linus" || name.ToLower() == "simon" || name.ToLower() == "emil") Console.WriteLine("\nUnderbart vilken fin perfekt karaktär vi har skapat"); // Secret diologe
            else Console.WriteLine("\nVi kommer kalla den " + name);

            Console.WriteLine("\n\nVänta några sekunder medans jag fixar din karaktär"); 
            Thread.Sleep(2500);
            
            if (accountRND == 1) // If random destory and make new character
            {
                strengths = "snäll";
                favColor = "grå";
                bloodType = "c";
                whatYouThinkAboutYourCreation = "Life is question that should not be answered";
                name = "Flint";

                Console.WriteLine("....så synd din karaktär är nu borta och din nya karaktär är Clara jag hoppas att du gillar henne. En snäll tjej som älskar rosa. Jag hoppas att detta fungerar istället" );
            }
            else if (accountRND == 2) // Changes one thing but leaves the rest unchanged player dont know what that is
            {
                if (whatIsRandom == 1) strengths = "smart";
                else if (whatIsRandom == 2) favColor = "gul";
                else if (whatIsRandom == 3) bloodType = "d";
                else if (whatIsRandom == 4) whatYouThinkAboutYourCreation = "Life is question that should be answered";
                else name = "Kevin";

                Console.WriteLine(".... något hände men vad?");
            }
            else Console.WriteLine("Det var konstigt det var som något skulle hända men inget hände."); // Nothing was changed
            Thread.Sleep(waitTimeBetweenText * 2);
            // End of creation phase

            // The game starts
            Console.WriteLine("\n\nVälkommen till spelet " + name); // Welcome to the game
            Thread.Sleep(waitTimeBetweenText);
            Console.WriteLine(" _____________________________________________________________________________");
            Console.WriteLine("|:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::|");
            Console.WriteLine("|:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::|");
            Console.WriteLine("|:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::|");
            Console.WriteLine("|:::::::::::::::::::::==========================::::::::::::::::::::::::::::::|");
            Console.WriteLine("|::::::::::::::::::::/                           :::::::::::::::::::::::::::::|");
            Console.WriteLine("|:::::::::::::::::::/  !__________!   .    _______::::::::::::::::::::::::::::|");
            Console.WriteLine("|::::::::::::::::::/   |____  ____|  /_    |__*__| :::::::::::::::::::::::::::|");
            Console.WriteLine("|:::::::::::::::::/|   {____}{____} __|__  |__*__| |::::::::::::::::::::::::::|"); // Amazing beedroom because why not
            Console.WriteLine("|:::::::!::::::::| |___%%%%%%%%%%%%_|_*_|_|__*__|_| |:::::::::::::::::::::::::|"); // I hope you like it
            Console.WriteLine("|::::::/  :::::::|/   %%%%%%%%%%%%%%|   | |/    |   |:::::::::::::::::::::::::|");
            Console.WriteLine("|=====|   |======|   %%%%%%%%%%%%%%%%               |=====================_===|"); // ps I DID NOT MAKE THIS
            Console.WriteLine("|     |   |      |  %%%%%%%%%%%%%%%%%%              |                    /    |");
            Console.WriteLine("|     |   |      | %%%%%%%%%%%%%%%%%%%%             |                   /___  |");
            Console.WriteLine("|        /       |/||||||||||||||||||||             |   .-------------.   |   |");
            Console.WriteLine("|    _______     |||||||||||||||||||||||            |   : .    .    . :   |    ");
            Console.WriteLine("|    |__@__|     |                                  |  _;_____________;_  |    ");
            Console.WriteLine("lc___|_____|_____|                                  |_(_)=============(_)_|___ ");
            Console.WriteLine(" `===|=====|===========================================|_______________|=_|_=` ");
            Console.WriteLine("`=============================================================================`");
            Console.WriteLine("===============================================================================`");
            Console.WriteLine("================================================================================`");

            // Some story
            Console.WriteLine("\n\nDu vaknar upp i din säng, du ser dig runt i rummet, vad hände igår frågor du dig själv");
            Thread.Sleep(waitTimeBetweenText);
            Console.WriteLine("Rummet är fyllt av din " + favColor + " lakan, kuddar allt men du vet inte varför, allt var ju svart igår");
            Thread.Sleep(waitTimeBetweenText);
            Console.WriteLine("Du rör dig sakta ut ur rummet ut i hallen och ser dig själv i spegeln");
            Thread.Sleep(waitTimeBetweenText);  
            Console.WriteLine("Ditt " + favColor + "a hår sticker åt alla håll");
            Thread.Sleep(waitTimeBetweenText);
            // End of story part

            // First question if yes ends game else play the rest of the game
            Console.WriteLine("\nVill du gå och lägga dig igen och skolka (Ja / Nej)?"); 
            goToSleep = Console.ReadLine().ToLower();
            if (goToSleep == "ja")
            {   
                Console.WriteLine("\nDu går tillbaka till din säng och lägger dig igen somnar snabbt och glömmer bort att världen existerar");
                Thread.Sleep(waitTimeBetweenText);
                Console.WriteLine("Du räddar tekniskt sätt världen"); // Way 1 of winning
                Thread.Sleep(8000);
                Environment.Exit(0); // Exit app
            } // Quits app after some text
            else if (goToSleep == "nej")
            {
                Console.WriteLine("\nDu kollar på klockan ser att den redan är mycket och att du är sen till skolan");
                Thread.Sleep(waitTimeBetweenText);
                if (strengths == "smart")
                {
                    Console.WriteLine("Du slänger dig ur huset ska du ta bilen, springa eller ta cykeln?");
                    wayToSchool = Console.ReadLine().ToLower();
                    if (wayToSchool == "bil")
                    {
                        Console.WriteLine("\nDu tar dig till skolan med lätthet, och går igenom dagen som den skulle vara");
                        Thread.Sleep(waitTimeBetweenText);
                        Console.WriteLine("Du räddade världen men kunde den sluta på ett annat sätt"); // Way 2 of winning
                        Thread.Sleep(8000);
                        Environment.Exit(0);
                    }
                    else if (wayToSchool == "cykel")
                    {
                        Console.WriteLine("\nDu tar dig till skolan men ser en mystiskt gång på vägen, men du ignorerar den och tar dig till skolan. Skulle ta kanske ha gått in i den?");
                        Thread.Sleep(waitTimeBetweenText);
                        Console.WriteLine("Du räddade världen men kunde den sluta på ett annat sätt"); // Way 3 of winning
                        Thread.Sleep(8000);
                        Environment.Exit(0);
                    }
                    
                }

                else if (strengths == "stark")
                {
                    Console.WriteLine("Du slänger dig ur huset ska du ta gå, springa eller ta cykeln?");
                    wayToSchool = Console.ReadLine().ToLower();
                    if (wayToSchool == "cykel")
                    {
                        Console.WriteLine("\nDu tar dig till skolan men ser en mystiskt gång på vägen, men du ignorerar den och tar dig till skolan. Skulle ta kanske ha gått in i den?");
                        Thread.Sleep(waitTimeBetweenText);
                        Console.WriteLine("Du räddade världen men kunde den sluta på ett annat sätt"); // Way 4 of winning
                        Thread.Sleep(8000);
                        Environment.Exit(0);
                    }
                    

                }
                else
                {
                    Console.WriteLine("Du slänger dig ur huset ska du ta bilen, gå, springa eller ta cykeln?");
                    wayToSchool = Console.ReadLine().ToLower();
                    if (wayToSchool == "bil")
                    {
                        Console.WriteLine("\nDu tar dig till skolan med lätthet, och går igenom dagen som den skulle vara");
                        Thread.Sleep(waitTimeBetweenText);
                        Console.WriteLine("Du räddade världen men kunde den sluta på ett annat sätt"); // Way 5 of winning
                        Thread.Sleep(8000);
                        Environment.Exit(0);
                    }
                    else if (wayToSchool == "cykel")
                    {
                        Console.WriteLine("\nDu tar dig till skolan men ser en mystiskt gång på vägen, men du ignorerar den och tar dig till skolan. Skulle ta kanske ha gått in i den?");
                        Thread.Sleep(waitTimeBetweenText);
                        Console.WriteLine("Du räddade världen men kunde den sluta på ett annat sätt"); // Way 6 of winning
                        Thread.Sleep(8000);
                        Environment.Exit(0);
                    }
                }
            }  // If gets out of this you will contiune the game and if not you have won the game
            else Environment.Exit(0);
            // End of first question

            // Secound question about going into the cave or not
            Thread.Sleep(waitTimeBetweenText);
            Console.WriteLine("\nDu rör dig raskt till skolan men ser en grotta. En grotta som inte har varit där innan. Vill du kolla vad det är? (Ja / Nej)");
            goInCave = Console.ReadLine().ToLower();
            if (goInCave == "nej")
            {
                Console.WriteLine("Du rör dig vidare från grottan och tänker inte så mycket mer på den. Kanske livet skulle se annorlunda ut om du gick in i?");
                Thread.Sleep(waitTimeBetweenText);
                Console.WriteLine("Du räddade världen men kunde den sluta på ett annat sätt");
                Thread.Sleep(8000);
                Environment.Exit(0); // Exit app
            } // if nej go back to sleep and forget the world
            // End of secound question

            Thread.Sleep(waitTimeBetweenText);
            Console.WriteLine("\nDu går in i grottan och ser dig omkring inget speciellt verkar vara här");
            Thread.Sleep(waitTimeBetweenText);
            Console.WriteLine("Du rör dig mer och mer in i grottan. Du känner att luften blir kallare och kallare.");
            Thread.Sleep(waitTimeBetweenText);
            Console.WriteLine("Stenar rasar in bakom dig och blockerar vägen bakom dig. Du kan inte återvända du måste röra dig längre in.");
            Thread.Sleep(waitTimeBetweenText);

            // Third question
            Console.WriteLine("\n        __________");
            Console.WriteLine("        / ____;;___  ");
            Console.WriteLine("       | /         /");
            Console.WriteLine("       `. ())oo() .");   // Some art because why not
            Console.WriteLine("        |(%()*^^()^ ");
            Console.WriteLine("       %| |-%-------|");
            Console.WriteLine("      %   | %  ))   |");
            Console.WriteLine("      %   |%________|");

            Console.WriteLine("Du ser en låda liggandes på marken. Vill du öppna den (Ja / Nej)?");
            openChest = Console.ReadLine().ToLower();
            if (openChest == "nej")
            {
                Console.WriteLine("\nOm du inte öppnar den kommer du att dö. Vill du fortfarande inte öppna den (Ja / Nej)?");
                stillNotOpenChest = Console.ReadLine().ToLower();
                if (stillNotOpenChest == "ja")
                {
                    Console.WriteLine("Du dör en plågsam död. Alla dina vänner har glömt bort vem du är och allt det du har gjort försvinner det var som att ingen visste att du existerade. Vad hade hänt om du öppnade den?");
                    Thread.Sleep(waitTimeBetweenText);
                    Console.WriteLine("Du rädde världen genom att döda dig själv. Var det värt det? Kunde du ha räddat dig själv också?");
                    Thread.Sleep(8000);
                    Environment.Exit(0);
                }
            } // Secound chance of answering correct
            // End of third question

            // Fouth question
            Console.WriteLine("\nDu ser en lera liggandes i lådan. Vad kan detta vara till för?");
            Thread.Sleep(waitTimeBetweenText);
            Console.WriteLine("Du ser även att det ligger en maskin i hörnet av rummet. Med ett håll där du skulle kunna hälla i leran");
            Thread.Sleep(waitTimeBetweenText);
            Console.WriteLine("Du skulle kunna smaka på leran tänker du för dig själv");
            Thread.Sleep(waitTimeBetweenText);
            Console.WriteLine("\nVill du smaka på leran (Ja / Nej) ?");
            if (strengths == "smart") Console.WriteLine("\nDu skrattar för dig själv för att du tänker vilken person skulle någonsin vilja smaka på den där leran den kommer nog att döda dig"); // if smart skip question
            else tasteIt = Console.ReadLine().ToLower();
            if (tasteIt == "ja")
            {
                Console.WriteLine("Du dör snabbt. Livet flyger förbi dina ögon och alla dina vänner få en känsla av att något saknas med de vet inte vad.");
                Thread.Sleep(waitTimeBetweenText);
                Console.WriteLine("Du rädde världen genom att döda dig själv. Var det värt det? Kunde du ha räddat dig själv också?");
                Thread.Sleep(8000);
                Environment.Exit(0);
            } // you taste it and die GAME OVER!
            // End of fourth question

            Console.WriteLine("\nIntressant val. Du går istället och häller i den i maskin.");
            Thread.Sleep(waitTimeBetweenText * 3);
            Console.WriteLine("Maskinen börjar skaka och låta. Du bakar bak.");
            Thread.Sleep(waitTimeBetweenText * 3);
            Console.WriteLine("Du tänker vad har jag gjort.");
            Thread.Sleep(waitTimeBetweenText * 3);
            Console.WriteLine("Maskinen exploderar\n\n");
            Thread.Sleep(4000);

            // Depending on bloodtype choice next is important
            if (bloodType == "d" || bloodType == "c" || bloodType == "ab")
            {
                Console.WriteLine("Världen exploderar allting dör. Varför? Kunde du ha gjort något annorlunda?");
                Thread.Sleep(8000);
                Environment.Exit(0);
            } // bloodtype d, c, ab impossible to win
            else if (bloodType == "a" && strengths == "stark")
            {
                Console.WriteLine("Det har magiskt skapas en väg ut. Du går ut i världen och ser dig omkring vad har hänt. Alla träd är borta. Alla bilar är borta. Allt är förstört. Du må ha överlevt men. Allting annat är dött och du lär dö inom en snar framtid. Du gjorde ändå allt du kunde men du gjorde några mistag. Vissa blodtyper är värre än andra");
                Thread.Sleep(15000);
                Environment.Exit(0);
            } // bloodtype a and if strength is stark you will survive but evertything will get destoryed
            else if (bloodType == "b")
            {
                Console.WriteLine("Du rör dig ut. Vägen som var tidigare blockerad är nu öppen. En man står utanför grottan. Han ser på dig med ett stort leende. Han ger dig en fråga. En fråga som förändrar allt en fråga som skapar stor oro bland dig. Han frågar. Vem är du och varför har du dödat  min.....");
                Thread.Sleep(15000);
                Environment.Exit(0);
            } // you survive
            else
            {
                Console.WriteLine("Du vaknar upp på ett sjukhus, en man står i hörnet av rummet och säger välkommen tillbaka till ditt ....");
                Thread.Sleep(8000);
                Environment.Exit(0);
            } // all other options you surivive kinda
        }
    }
}
