using System;

namespace Uppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sticks = 12;

            Console.WriteLine($"There is currently {sticks} sticks.\nYou can only take 1, 2 or 3 sticks each turn.\nWhoever takes the last stick wins!\n\n");

            while(sticks > 0)
            {
                Console.WriteLine($"There is currently {sticks} remaining.\nHow many do you want to take?");
                int playerTakes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                if (playerTakes < 1 || playerTakes > 3) Console.WriteLine("\n\n1, 2 or 3 sticks only!\n\n");
                else
                {
                    Console.WriteLine($"Player takes {playerTakes} sticks");
                    sticks -= playerTakes;
                    Console.WriteLine($"I take {4-playerTakes} sticks\n\n");
                    sticks -= 4 - playerTakes;

                }
            }
            Console.WriteLine("I win again ;)");
            Console.ReadKey();
        }

        
    }
}
