using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Skriv något kul: ");
            //string returnMessage = Console.ReadLine();
            //Console.WriteLine("Ha-Ha-Ha! " + returnMessage);
            //Console.ReadLine();

            /*
            1.    Vad händer med det som användaren skriver i konsolfönstret? : Den sparar det i en variable vid namn returnMessage
            2.    Vad tror du Console.ReadLine() har för funktion på rad två ovan? : Den läser av vad som användaren skriver i konsolen
            3.    returvärde är en så kallad variabel. Vad används den till i koden ovan? : för att läggas på efter texten
            4.    Vad tror du + används till i koden ovan? : för att slå ihop två texter
            5.    Vad är skillnaden på WriteLine() och Write()? (Prova att ändra i koden för att ta reda på svaret) : WriteLine = skapar ny rad ; Write fortsätter skriva på samma rad

             */

            // Task 1
            //Console.Write("Vad heter du? ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hej " + name);
            //Console.ReadLine();

            // Task 2
            Console.Write("Vilken är din favoritfärg? ");
            string favColor = Console.ReadLine();
            Console.WriteLine(favColor + ", vilken fin färg!");
            Console.ReadLine();
        }
    }
}
