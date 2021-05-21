using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter w = new StreamWriter("../../file.txt");

            Console.Write("What is your name: ");
            w.WriteLine(Console.ReadLine());
            Console.Write("What is your last name: ");
            w.WriteLine(Console.ReadLine());

            Console.Write("What is your age: ");
            bool isInt = int.TryParse(Console.ReadLine(), out int age);
            while (!isInt) isInt = int.TryParse(Console.ReadLine(), out age);
            w.WriteLine(age);

            Console.WriteLine("\nSaving data to file.txt");
            w.Close();
            Console.ReadKey();

        }
    }
}
