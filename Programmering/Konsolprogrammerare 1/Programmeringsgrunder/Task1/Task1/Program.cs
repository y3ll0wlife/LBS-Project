using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello World");
            }
           
            Console.ReadLine();

            // 1.    Till vad används Console.WriteLine(...) ? : För att skriva en line men text
            // 2.    Hur kan man ändra texten som visas i konsolfönstret? : Genom att ändra vad som står inom " i WriteLine funktionen
            // 3.Vad händer om man tar bort raden med Console.ReadLine() ? Testa. : Programmet startar och sedan stängs av
            // 4.    Vad händer när man trycker F5? : Startar en debugger

        }
    }
}
