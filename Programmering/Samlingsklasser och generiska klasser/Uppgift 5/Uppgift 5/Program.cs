/*
    Skriv ett program som räknar ut förekomsten av ord i en text(histogram). 
    Indata kan lösas via konsollen eller genom att läsa en txt-fil. 
    Resultatet presenteras sorterat med flest förekomster först. 
    Var noga med att skala bort punkter, kommatecken, frågetecken och utropstecken samt tänk på/lös att "Det" inte är samma som "det".
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_5
{
    class Program
    {
        public static string RemoveBad(string s)
        {
            string[] bad = new string[] {".", ",", "?", "!", "\n"};
            foreach (string c in bad) s = s.Replace(c, string.Empty);

            return s;
        }

        static void Main(string[] args)
        {
            bool isTextFile = false; // om false använder konsolen istället
            string PATH = "../../bee.movie";
            List<string> commonWords = new List<string>();
            string text;

            if (!isTextFile) text = RemoveBad(Console.ReadLine());
            else text = File.ReadAllText(PATH);

            string[] words = text.Split(' ');
            foreach (var w in words) commonWords.Add(RemoveBad(w));
            SortedList<string, int> result = new SortedList<string, int>();

            for (int i = 0; i < words.Count(); i++)
            {
                if (result.ContainsKey(commonWords[i])) result[commonWords[i]] = result[commonWords[i]] += 1;
                else result.Add(commonWords[i], 1);
            }


            foreach (KeyValuePair<string, int> kvp in result.OrderBy(x => x.Value)) Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);
                             



            Console.ReadKey();
            
        }
    }
}
