using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                default:
                    Console.WriteLine("Invalid alternative");
                    break;
            }

            Console.ReadKey();
            

            // Task 2

            string facing = Console.ReadLine();
            switch (facing.ToUpper())
            {
                case "N":
                    Console.WriteLine("You walk north");
                    break;
                case "S":
                    Console.WriteLine("You walk south");
                    break;
                case "E":
                    Console.WriteLine("You walk east");
                    break;
                case "W":
                    Console.WriteLine("You walk west");
                    break;
                default:
                    Console.WriteLine("I don't understand!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
