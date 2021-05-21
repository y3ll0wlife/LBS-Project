using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7b
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            
                 Console.Write("Start number: ");
                 string startNum = Console.ReadLine();
                 Console.Write("Stop number: ");
                 string stopNum = Console.ReadLine();
                 Console.Write("Jumps: ");
                 string jumps = Console.ReadLine();

                 int startN = Convert.ToInt32(startNum);
                 int stopN = Convert.ToInt32(stopNum);
                 int j = Convert.ToInt32(jumps);
                 Console.WriteLine();

                 for (int i = startN; i <= stopN; i = i + j)
                 {
                     Console.Write(i + " ");
                 }

                 Console.ReadLine(); 
                 

            // Task 2
            
            Console.Write("Write a number: ");
            string num = Console.ReadLine();
            int number = Convert.ToInt32(num);
            int total = 0;

            for (int i = 0; i <= number; i++)
            {
                total = total + i;
            }
            Console.WriteLine("The sum of all numbers between 1 and " + num + " is " + total.ToString());
            Console.WriteLine("Press any key to leave!");
            Console.ReadKey();
            

            // Task 3
            
            Console.Write("Write a wholenumber: ");
            string num = Console.ReadLine();
            int number = Convert.ToInt32(num);
            bool check = false;

            for (float i = 1; i <= number; i++)
            {
                float numy = i / 3;
                float numy2 = i / 7;
                if ((numy % 1) == 0 && (numy2 % 1) == 0)
                {
                    check = true;
                    Console.WriteLine("The number: " + i.ToString() + " can be divided by 3 and 7");
                }
            }
            if(check == false) Console.WriteLine("Was not able to find any number :(");
            Console.WriteLine("Press any key to leave!");
            Console.ReadKey();
            

            // Task 4
            // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040, 1346269, 2178309, 3524578, 5702887, 9227465, 14930352, 24157817, 39088169
            
            Console.Write("Write a number: ");
            string numbey = Console.ReadLine();
            int number = Convert.ToInt32(numbey);

            int lastNum = 1;
            int num = 0;
            int total = 0;

            for (int i = 1; i <= number; i++)
            {
                total = lastNum + num;
                lastNum = num;
                num = total;
                Console.WriteLine(total);
            }
            
            Console.WriteLine("Press any key to leave!");
            Console.ReadKey();
            

            // Task 5
            
            Console.Write("Write a number: ");
            string numbey = Console.ReadLine();
            double number = Convert.ToDouble(numbey);

            double calcy = 0;

            for (double i = 0; i < number + 1; i+= 0.01)
            {
                calcy = i * i * i;
                if (Math.Round(calcy) == number)
                {
                    Console.WriteLine(Math.Round(i, 1));
                    break;
                }
            }
            Console.WriteLine("Press any key to leave!");
            Console.ReadKey();
            

            // Task 6
            // 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97
            
            Console.Write("Write a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = false;
            if (number <= 1) Console.WriteLine(number + " is not a primenumber");
            if (number == 2) Console.WriteLine(number + " is a primenumber");
            

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(number + " is not a primenumber");
                    break;
                }
                else isPrime = true;
            }
            if(isPrime) Console.WriteLine(number + " is a primenumber");

            Console.WriteLine("Press any key to leave!");
            Console.ReadKey();
            

            // Task 7
            // 2, 3, 5, 7, 11, 13, 17, 19 and 23

           Console.Write("Write a number: ");
           int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = false;

            for (int i = 2; number > 1; i++)
            {
                if (number % i == 0)
                {
                    while (number % i == 0)
                    {
                        number /= i;
                        Console.WriteLine("The number " + i + " is a primefactor");
                    }

                }
                else isPrime = true;
            }
            if(isPrime) Console.WriteLine(number + " is a primenumber");
            else Console.WriteLine(number + " is not a primenumber");

            Console.WriteLine("Press any key to leave!");
            Console.ReadKey();
        }
    }
}
