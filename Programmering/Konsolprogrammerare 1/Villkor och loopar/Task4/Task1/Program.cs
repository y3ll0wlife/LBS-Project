using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Vad heter du? ");
            //string name = Console.ReadLine();

            //if (name.ToLower() == "anna")
            //{
            //    Console.WriteLine("Hej Anna");
            //    Console.WriteLine("Går det bra om jag kallar dig för \"Anna Panna\"..."); 
            //}
            //else if (name.ToLower() == "olle")
            //{
            //    Console.WriteLine("Hej Olle!");
            //    Console.WriteLine("Går det bra om jag kallar dig för \"Olle Bolle\"...");

            //}
            //else
            //{
            //    Console.WriteLine("Hej " + name + "!");
            //    Console.WriteLine("Går det bra om jag kallar dig för \"Kompis\"...");
            //}

            //Console.ReadLine();

            /*
             1.    Till vad används if och else tror du? : If om en sak stämmer och else för när if inte funkar
             2.    Vad är skillnaden på = och == ? : = är när du stter en variable och == är du matchar två saker
             3.    Vad händer om man byter == till = i den första if-satsen? (Testa!) : Errors :)
             4.    Varför är det en variabel framför ReadLine-funktionen vid en inmatning : För att vi ska kunna spara svaret i en variable
             */

            // Task 1
            Console.WriteLine("Lösenord: ");
            string password = Console.ReadLine();

            if (password.ToLower() == "rätt lösenord") Console.WriteLine("Välkommen till systmet");
          
            else Console.WriteLine("Fel lösenord. Go home...");
            

            // Task 2
            Console.WriteLine("Gillar du programmering? ");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "ja") Console.WriteLine("Kul att höra!");
            else Console.WriteLine("Kämpa på ändå!");
            Console.ReadLine();


            // Task 3
            Console.WriteLine("Vilken är din favoritfärg? ");
            string answer = Console.ReadLine();

           if(answer.ToLower() == "röd") Console.WriteLine("Rött är sött");
           else if(answer.ToLower() == "blå") Console.WriteLine("Blått är vått");
           else if (answer.ToLower() == "gult") Console.WriteLine("Gult är fult");
           else Console.WriteLine("Kul färg");
            Console.ReadLine();
        }
    }
}
