/*
    Bygg vidare på Övning 3 men använd en Dictionary istället. 
    Som nyckel använder du "k5" etc eftersom dessa är unika i en kortlek på 52 kort. 
    Som värde lagrar du int, Ess = 1, Kung = 13, etc. 
    Dra nu två kort åt gången utan att "minska" kortleken och skriv ut "PAR" de gånger du drar två lika kort, dvs att värdet är lika. 
    För att lösa detta måste du slumpvis kunna välja en nyckel i Dictionary vilket du kan genom att gå på Keys i Dictionary som i sig är en lista. 
    Försök till sist beräkna hur många gånger det blir "PAR" om du gör 1000 dragningar.

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_4
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Dictionary<string, int> deck = new Dictionary<string, int>();
            string[] values = new string[13] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] types = new string[4] { "d", "h", "c", "s" };

            foreach (string type in types)
                foreach (string value in values)
                    deck.Add($"{type}{value}", Array.IndexOf(values, value));

            Random rnd = new Random();
            for (int i = 0; i < 1_000; i++)
            {
                string card1 = $"{types[rnd.Next(types.Count())]}{values[rnd.Next(values.Count())]}";
                string card2 = $"{types[rnd.Next(types.Count())]}{values[rnd.Next(values.Count())]}";

                if (deck[card1] == deck[card2] && card1 != card2) Console.WriteLine($"Par med {card1} och {card2}");
            }

            Console.ReadKey();
        }
    }
}
