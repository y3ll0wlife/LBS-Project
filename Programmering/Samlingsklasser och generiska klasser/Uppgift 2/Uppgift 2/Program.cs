/*
    Skapa ett program där du tillåts att mata in tal tills dess att du matar in 0 då avslutas programmet. 
    Efter varje inmatat tal skall du skriva ut medelvärdet av alla tal som matats in. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double val = Convert.ToInt32(Console.ReadLine());
            List<double> vals = new List<double>();

            while(val != 0)
            {
                vals.Add(val);
                val = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Medelvärdet är: {vals.Sum()}/{vals.Count()} = {vals.Sum()/vals.Count()}");

            Console.ReadKey();
        }
    }
}
