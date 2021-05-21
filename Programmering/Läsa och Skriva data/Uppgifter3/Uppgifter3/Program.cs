using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgifter3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f;
            int countChar = 0;
            int countLine = 0;
            int countWord = 0;
            using (f = new StreamReader("../../cool-file.txt")){
                string l;
                while ((l = f.ReadLine()) != null)
                {
                    countChar += l.Length; // gets amount of chars
                    countLine++; // adds one to the line count

                    string[] w = l.Split(' '); // splits the string 
                    if(!String.IsNullOrWhiteSpace(w[0])) countWord += w.Length; // checks if the line is null or whitespace (cool method) and adds the length of the amount of words

                }
            }

            Console.WriteLine($"characters: {countChar}");
            Console.WriteLine($"words: {countWord}");
            Console.WriteLine($"lines: {countLine}");
            Console.ReadKey();


        }
    }
}
