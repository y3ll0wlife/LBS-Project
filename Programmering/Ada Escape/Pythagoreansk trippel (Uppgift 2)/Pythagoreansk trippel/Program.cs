/*
 En ”Pythagoreansk trippel” är tre heltal;

    a < b < c 

som uppfyller Pythagoras sats;

    a2 + b2 = c2 

Alltså a ska vara mindre än b som i sin tur ska vara mindre än c. Det finns endast en ”trippel” där a + b + c = 950. 
Hitta värdet på produkten abc. Det är lösenordet till nästa nivå.

a mindre än b som är mindre än c
a + b + c = 950
 */

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pythagoreansk_trippel
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int tries = 0;
            Random rnd = new Random();
            while (true)
            {
                a = rnd.Next(1, 500);
                b = rnd.Next(1, 500);
                c = rnd.Next(1, 500);

                double sum = Math.Pow(a, 2) + Math.Pow(b, 2);
                if (sum == Math.Pow(c, 2) && a < b && b < c && (a + b + c) == 950)
                {
                    /*
                            A = 228
                            B = 325
                            C = 397
                            29417700
                            */
                    Console.WriteLine("A = " + a);
                    Console.WriteLine("B = " + b);
                    Console.WriteLine("C = " + c);
                    Console.WriteLine(a * b * c);
                    Console.WriteLine("Tries: " + tries);
                    break;

                }
                else
                {
                    tries++;
                }
            }
            
            Console.ReadKey();
        }
    }
}
