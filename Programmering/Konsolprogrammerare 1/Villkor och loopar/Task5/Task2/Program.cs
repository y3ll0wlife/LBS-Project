using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hur gammal är du? (Skriv bara siffor) ");
            //string input = Console.ReadLine();
            //int age = Convert.ToInt32(input);

            //if(age >= 18) Console.WriteLine("Oj, är du redan " + age + " år gammal!");
            //else Console.WriteLine("Är du bara " + age + "...");

            //Console.ReadLine();

            /*
            1.    Vad är inmatning och ålder i programkoden ovan? : input är den texten vi tar in från användaren och age är när vi konverterar input till en int
            2.    Vad string och int? När används de? : string är text och int är ett heltal
            3.    Vad tror du Convert.ToInt32(inmatning) gör? : Conveterar en string till en int
            4.    Till vad används if och else ? : if för att checka två saker och om det stämmer gå vidare och else är när inget annat fungerar
            5.    Vad kallas det som står precis till höger om if ? : paranterser
            6.    Vad betyder tecknet > ? : Större än
             */

            // Task 1
            Console.Write("Hur gammal är du? (Skriv bara siffor) "); // Skriver ut en text
            string input = Console.ReadLine(); // Läser vad användaren skriver
            int age = Convert.ToInt32(input); // Konverterar string till en int

            if (age >= 18) Console.WriteLine("Oj, är du redan " + age + " år gammal!"); // checkar om age är större eller samma som 18 och sedan skriver en text
            else Console.WriteLine("Är du bara " + age + "..."); // Om det är mindra än 18 så skriv ut en text

            Console.ReadLine(); // Läs en linje 

            // Task 2
            Console.Write("Hur många grader är det? (Skriv bara siffor) ");
            string input = Console.ReadLine();
            int degrees = Convert.ToInt32(input);

            if(degrees >= 24) Console.WriteLine("Baddags");
            else Console.WriteLine("Ja, ja lika bra att va i skolan");

            Console.ReadLine();

            // Task 3
            Console.Write("Gissa på ett tal? (Skriv bara siffor) ");
            string input = Console.ReadLine();
            int guess = Convert.ToInt32(input);

            if (guess == 3) Console.WriteLine("Rätt gissat");
            else Console.WriteLine("Helt fel");

            Console.ReadLine();
        }
    }
}
