using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; 1 <= 100; i = i + 2)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Slut på loopen.");
            //Console.ReadLine();

            /*
            1. Vad används for till ovan? : För att loopa igen 0-100 och göra 2 hopp hela tiden
            2. Vad kallas i <= 100 för? : Så länge i är mindre än 100
            3. Vad händer om man byter i <= 100 till 1 == 1 som logiskt uttryck? : den kommer då bli en evig loop för att 1 kommer alltid vara det samma som 1

             */

            // Task 1
              for (int i = 1; i < 11; i++)
              {
                  Console.WriteLine(i);
              }

              Console.ReadLine();

            // Task 2
            for (int i = 1; i < 51; i++)
                {
                    Console.WriteLine("Hej, nu är vi på varv, " + i);
                }

                Console.ReadLine();

            // Task 3
            for (int i = 20; i != -1; i--)
             {
                 Console.WriteLine(i);
                 Thread.Sleep(1000);
             }
             Console.WriteLine("Booooooooommm");
             Console.ReadLine();

            // Task 4
            for (int i = 1; i <= 100; i = i + 2)
              {
                  Console.WriteLine(i);
              }

              Console.ReadLine(); 

            // Task 5
            for (int i = 0; i <= 1000; i = i + 10)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
