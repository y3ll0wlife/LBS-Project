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
            //string myText = "Hej på dig!";
            //int myNum = 21;

            //Console.WriteLine(myText);
            //myText = "Hej igen!";
            //Console.WriteLine("Variabeln myText innehåller nu: " + myText);

            //Console.WriteLine(myNum);
            //myNum++;
            //Console.WriteLine("Variabeln myNum innehåller nu: " + myText);

            //Console.ReadLine();

            /*
            1.    Vad är minText och mittTal i programkoden ovan?                            : minText = string / mittTal = integer
            2.    Vad är string till för?                                                    : för att spara en text
            3.    Vad är int till för?                                                       : för att spara en siffra
            4.    Vad är skillnaden på att skapa en variabel och att använda en variabel?    : att skapa en variable sätter du vilken variable typ det är i början annars är det bara att kalla på variablen för att ändra den
            5.    Till vad används + i programkoden ovan? (Två olika saker.)                 : du lägger till något, i fallet av en string så lägger man till en text del efter och på en int så lägger man till en siffra på den
            */

            string myName = "Philip";
            int myAge = 17;

            int num1 = 5;
            int num2 = 8;
            int sum = num1 + num2;

            int diff = num1 - num2;

            Console.WriteLine("Variabeln num1 har värdet: " + num1);
            Console.WriteLine("Variabeln num2 har värdet: " + num1);
            Console.WriteLine("Variabeln sum har värdet: " + num1);

            Console.WriteLine(num1 + " - " + num2 + " = " + sum);
            Console.ReadLine();
        }
    }
}
