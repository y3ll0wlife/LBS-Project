using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Task8b
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            
            int i = 1;
            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadKey();
           
            // Task 2
            
            int i = 10;
            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }
            Console.ReadKey();
           

            // Task 3
            
             Console.Write("Text: ");
             string i = Console.ReadLine();

             while (true) Console.WriteLine(i);
            

            // Task 4
            
            Random rnd = new Random();
            int secret = rnd.Next(1, 101);
            int guesses = 1;
            bool hasFound = false;

            while (hasFound == false)
            {
                Console.Write("Guess a number between 1 and 100: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == secret) hasFound = true;
                else
                {
                    if(guess < secret) Console.WriteLine("För lågt!");
                    if(guess > secret) Console.WriteLine("För högt!");
                    guesses++;
                }
            }
            Console.WriteLine("Gratz it only took " + guesses.ToString() + " tries");
            Console.ReadKey();
           

            // Task 5
            
            int i = 2;
            int lastNum = 1;
            int num = 0;
            int total = 0;

            while (i < 1000000)
            {
                total = lastNum + num;
                lastNum = num;
                num = total;
                if (total >= 1000000) break;
                Console.WriteLine(total);  
            }
          

            Console.WriteLine("Press any key to leave!");
            Console.ReadKey();
           

            // Task 6
            
            Console.Write("How much money do you have (kr): ");
            double money = Convert.ToDouble(Console.ReadLine());
            Console.Write("Intrest rate (%): ");
            double intrest = Convert.ToDouble(Console.ReadLine());
            Console.Write("Goal (kr): ");
            double goal = Convert.ToDouble(Console.ReadLine());

            int years = 1;
            double moneyCurrent = money;
            double intrestPrencent = intrest / 100;

            while (moneyCurrent <= goal)
            {
                double test = moneyCurrent * intrestPrencent;
                moneyCurrent = moneyCurrent + test;
                years++;
            }
            Console.WriteLine("Its going to take " + years + " years to get from " + money + "kr to " + goal + "kr and you will end up with " + moneyCurrent + "kr");
            Console.ReadKey();
           

            // Task 7
            
            int currentYear = 2019;
            int maxYear = 2050;
            while (currentYear != maxYear)
            { 
                if(DateTime.IsLeapYear(currentYear)) Console.WriteLine(currentYear + " is a leap year");
                currentYear++;
            }
            Console.ReadKey();
           

            // Task 8

            int day = 1;
            int month = 1;
            int dayMax = 30;
            
            while (true)
            {
                DateTime value = new DateTime(DateTime.Now.Year, month, day);
                if(value.DayOfWeek.ToString() == "Monday") Console.WriteLine(value.ToString());

                if (month == 2) dayMax = 27;
                else dayMax = 30;
                if (day == dayMax)
                {
                    month++;
                    day = 0;
                }

                day++;
                if (month == 13) break;
            }


            Console.ReadKey();
        }
    }

}
