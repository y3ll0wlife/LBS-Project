/*
    Använd en lista av strängar för att symbolisera en kortlek. 
    T.ex. "k5" betyder klöver 5, "hKn" hjärter knekt, "sE" spader Ess, "rD" ruter dam, etc. 
    Var effektiv när du fyller listan och använd loopar. 
    Skriv sedan ett program som slumpvis drar kort från kortleken tills dess att alla 52 kort är dragna. 
    Skriv ut varje kort du "drar".
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> deck = new List<string>();
            string[] values = new string[13] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] types = new string[4] { "d", "h", "c", "s" };

            foreach (string type in types) 
                foreach (string value in values) 
                    deck.Add($"{type}{value}");

            Random rnd = new Random();
            int count = deck.Count();

            for (int i = 0; i < count; i++)
            {
                string card = deck[rnd.Next(deck.Count())];
                Console.WriteLine($"{card}");
                deck.Remove(card);
            }

            Console.ReadKey();
        }
    }
}
