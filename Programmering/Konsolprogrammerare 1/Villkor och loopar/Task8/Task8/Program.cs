using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {

            //int antalVarv = 0;
            //while (antalVarv < 1000)
            //{
            //    Console.Write(antalVarv + " Hej ");
            //    antalVarv = antalVarv + 1;
            //}
            //Console.WriteLine(); // Ger en radbrytning
            //Console.WriteLine("Slut på loopen.");
            //Console.ReadLine();

            /*
            1.    Vad används while till ovan? : För att loopa igenom antalVarv till något mindre en tusen
            2.    Vad betyder antalVarv = antalVarv + 1; ? : Antalvarv är lika med antalvarv + 1
            3.    Vad händer om man tar bort raden antalVarv = antalVarv + 1; ?  : den kommer köra i evigt för att vi kommer aldrig att gå över tusen
                Varför blir det så? : För att vi öker aldrig antalvarv
            4.    Vad kallas antalVarv < 1000 för? : För att checka om antalvarv är större än tusen
            5.    Vad händer om man byter antalVarv < 1000 till 1 == 1 som logiskt : Då kommer den göra i evigt för att 1 kommer alltid vara lika med 1
                uttryck?
             */

            // Task 1
            
            int i = 1;
            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadKey();
            

            // Task 2
            
            int i = 1;
            while (i <= 50)
            {
                Console.WriteLine("Hej vi är på varv " + i);
                i++;
            }

            Console.ReadKey();
            

            // Task 3
            
            int i = 20;
            while (i != 0)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
                i--;
            }
            Console.WriteLine("Booooooooommm");
            Console.ReadKey();
            

            // Task 4
            
            while (true)
            {
                Console.WriteLine("Hej igen! ");
            }
            

            // Task 5
            
            Console.Write("How many times: ");
            int times = Convert.ToInt32(Console.ReadLine());
            int inc = 1;
            while (inc <= times)
            {
                Console.WriteLine("Hej " + inc);
                inc++;
            }

            Console.ReadKey();
            

            // Task 6
            
            Console.Write("Text: ");
            string text = Console.ReadLine();
            Console.Write("How many times: ");
            int times = Convert.ToInt32(Console.ReadLine());
            int inc = 1;
            while (inc <= times)
            {
                Console.WriteLine(inc.ToString() + ". " + text);
                inc++;
            }

            Console.ReadKey();
            

            // Task 7
            int inc = 2;
            while (inc <= 100)
            {
                Console.WriteLine(inc);
                inc += 2;
            }

            Console.ReadKey();
        }
    }
}
