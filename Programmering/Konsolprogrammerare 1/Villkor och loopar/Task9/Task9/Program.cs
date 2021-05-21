using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //int random1, random2;
            //int rounds = 0;

            //while (true)
            //{
            //    random1 = rnd.Next(1, 101);
            //    random2 = rnd.Next(1, 101);

            //    rounds++;
            //    Console.WriteLine("Round: " + rounds + " ; Random is " + random1 + " and " + random2);

            //    if (random1 == random2) break;
            //}
            //Console.WriteLine("\nThe random numbers were the same on round " + rounds);
            //if(rounds < 20) Console.WriteLine("This was fast!!!");
            //else if(rounds < 100) Console.WriteLine("Less than a hundred at least");
            //else Console.WriteLine("Wow this took a while...");

            //Console.ReadKey();

            /*
               1.    När kommer kommandot break att köras? : När random1 och random2 är samma
               2.    Till vad används break? : Vi använder break för att avsluta en loop som denna while true loop som annars skulle köra i evigt
               3.    Varför behövs else i else if (antalVarv < 100) ? : För att om vi hade haft if så hade vi fått två posetiva svar och både två hade skrivit ut något men när vi har else if så när if blir godkännt så körs inte else if och om if inte körs så kollar den om else if är uppnåt och då kör den den
             */

            // Task 1
            
            Random rnd = new Random();
            int rounds = 0;
            while (true)
            {
                int random1 = rnd.Next(1, 101);
                int random2 = rnd.Next(1, 101);
                int random3 = rnd.Next(1, 101);
                rounds++;
                if (random1 == random2 && random1 == random3) break;
            }
            Console.WriteLine("Done and it only took " + rounds + " rounds");
            Console.ReadKey();
            

            // Task 2
            
            Random rnd = new Random();
            int rounds = 0;
            while (true)
            {
                int random1 = rnd.Next(1, 101);
                int random2 = rnd.Next(1, 101);
                int random3 = rnd.Next(1, 101);
                rounds++;
                if (random1 == random2 || random1 == random3 || random2 == random3) break;
            }
            Console.WriteLine("Done and it only took " + rounds + " rounds");
            Console.ReadKey();
            

            // Task 3

            Random rnd = new Random();
            int random = rnd.Next(1, 101);
            int round = 0;

            while (round <= 10000)
            {
                if (random <= 25) Console.ForegroundColor = ConsoleColor.Red;
                else if (random >= 25 && random <= 50) Console.ForegroundColor = ConsoleColor.Yellow;
                else if (random >= 50 && random <= 75) Console.ForegroundColor = ConsoleColor.Green;
                else if (random >= 75) Console.ForegroundColor = ConsoleColor.Blue;

                Console.Write(random + " ");
                round++;
                random = rnd.Next(1, 101);
            }
           
            Console.ReadKey();
        }
    }
}
