using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Vad är din temperatur? (Använd komma för att ange decimaler - t.ex. 37,14) ");
            string data = Console.ReadLine();
            double temperatur = Convert.ToDouble(data);

            if (temperatur > 36.8) Console.WriteLine("Vila i sängen hela dagen!");
            else if (temperatur < 36.5) Console.WriteLine("Cool typ! Drick en kopp varm choklad...");
            else Console.WriteLine("Helt normalt! Du är ju frisk...");

            Console.ReadLine();
            */
            /*
             1.    Vad tror du att datatypen double är till för? : decimal tal 
             2.    När ska man ha semikolon och i vilka fall ska man inte ha semikolon? (Studera koden ovan och försök att hitta regler.) : Inga efter vilkor annars ja
             3.    Vad är vitsen med att ha else if (villkor) ? : För att när if inte fungerar kollar vi på else if och om inte det funkar tar vi else
             4.    Kan man lika gärna ha t.ex. 36,5 istället för 36.5 i programkoden? (Testa.) : Nej errors för att programmet vet inte vad , är till för
             5.    När ska man använda komma och när ska man använda punkt när man jobbar med decimaltal? : . i if satser och , när vi konveterar en string till double
             6.    Ändra dina nationella inställningar i Windows (om du kan) till amerikanska. Prova att kör programmet igen och testa både 36,5 och 36.5. Vad händer? : , funkar inte och . funkar
             */

            // Task 1
             Console.WriteLine("Ge mig två siffor att addera");
             Console.WriteLine("Siffra 1:");
             string num1 = Console.ReadLine();
             Console.WriteLine("Siffra 2:");
             string num2 = Console.ReadLine();

             double num1Double = Convert.ToDouble(num1);
             double num2Double = Convert.ToDouble(num2);
             double sum = num1Double + num2Double;

             Console.WriteLine(num1Double + " + " + num2Double + " = " + sum);
             Console.ReadLine();

            // Task 2
            Console.Write("Hur många grader är det ute? ");
             string num1 = Console.ReadLine();
             double num1Double = Convert.ToDouble(num1);

             if(num1Double >= 24) Console.WriteLine("Baddags!");
             else if (num1Double >= 20) Console.WriteLine("Ingen jacka idag!");
             else if(num1Double >= 0) Console.WriteLine("Skönt att det är plusgrader");
             else if (num1Double <= -5) Console.WriteLine("Oj, redan vinter");
             else if (num1Double <= -10) Console.WriteLine("Varm mössa idag");
             else Console.WriteLine("Hmmmm något blev fel");

             Console.ReadLine(); 

            // Task 3
            Console.Write("Ett decimaltal? ");
            string num1 = Console.ReadLine();
            double num1Double = Convert.ToDouble(num1);

            Console.WriteLine(Math.Round(num1Double, 2));

            Console.ReadLine();
        }
    }
}
