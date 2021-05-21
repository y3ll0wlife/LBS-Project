using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //int randomNum = rnd.Next(1, 11);

            //Console.Write("Guess a number between 1 and 10: ");
            //int guessedNum = Convert.ToInt32(Console.ReadLine());

            //if(guessedNum == randomNum) Console.WriteLine("Well done that was correct");
            //else Console.WriteLine("Sorry that was wrong the number was " + randomNum);

            //Console.ReadKey();

            /*
               1.    Hur slumpar man ett tal i C#? : Med Random metoden
               2.    Vad anger 1 och 11 i randomObjekt.Next(1, 11) ? : 1 anger det minsta talet som kan slumpas och 11 det högsta talet +1
               3.    Vad kallas 1 och 11 i randomObjekt.Next(1, 11) ? : Ints
               4.    Vad kallas Next för? : Det ger tillbaka nummer i den oändliga sekvensen av nummer som genereras från Random : https://stackoverflow.com/questions/29475679/why-is-next-method-called-next
               5.    Varför finns en variabel framför anropet till Next? : För att vi skapar en variable som är kopplad till Random metoden och då kallar vi på den och sedan Next
               6.    Vad är skillnaden på = och == i C#? Vad kallas de tecknen? : = är för att sätta något som att ge en variable någon att spara ; Operators
             */

            // Task 1
            
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(1, 101));
            Console.WriteLine(rnd.Next(1, 101));
            Console.WriteLine(rnd.Next(1, 101));
            Console.WriteLine(rnd.Next(1, 101));
            Console.WriteLine(rnd.Next(1, 101));

            Console.ReadKey();
            

            // Task 2
            
            Random rnd = new Random();

            int num1 = rnd.Next(1, 7);
            int num2 = rnd.Next(1, 7);

            if(num1 == num2) Console.WriteLine("A pair of " + num1 + "s nice!");
            else Console.WriteLine("The numbers are " + num1 + " and " + num2);

            Console.ReadKey();
            

            // Task 3

            Random rnd = new Random();

            int num1 = rnd.Next(1, 11);
            int num2 = rnd.Next(1, 11);

            if(num1 == num2) Console.WriteLine("They both became " + num2);
            if(num1 > num2) Console.WriteLine(num1 + " is bigger than " + num2);
            if (num1 < num2) Console.WriteLine(num1 + " is smaller than " + num2);

            Console.ReadKey();
        }
    }
}
