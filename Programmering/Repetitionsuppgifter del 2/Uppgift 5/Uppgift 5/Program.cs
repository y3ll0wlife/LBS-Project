/*
Skapa ett fyra i rad i Konsolen. Använd två olika symboler.
Ex [*] & [^].
^     ^           ^     *       
*     * ^         ^  *  ^
*  ^  * *      *  ^  *  *
*  *  ^ ^      *  ^  *  * 

(För en extra utmaning så gör att användaren får spela mot datorn)
 */

using System;

namespace Uppgift5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuration
            string player1 = "*";
            string player2 = "^";
            string whiteSpace = "0";


            int width = 7;
            int height = 6;


            // Start of the program
            int[,] board = new int[height, width];


            bool gameActive = true;



             // Let the games begin
             Console.WriteLine("Welcome to connect four");
             Console.WriteLine($"Type a number between 1 and {width} to place your mark");

             // Randomzie who starts
             Random rng = new Random();
             bool p1Turn = rng.Next(0, 2) > 0;

             if (p1Turn) Console.WriteLine("Player 1 starts!");
             else Console.WriteLine("Player 2 starts!");

             GenerateBoard(board, width, height, player1, player2, whiteSpace);

             while (gameActive)
             {
                 int place = Convert.ToInt32(Console.ReadLine());
                 if (place < 1 || place > width) Console.WriteLine($"Type a number between 1 and {width}!");
                 else {
                     if (p1Turn) board[0, place-1] = 1;
                     else board[0, place-1] = 2;

                     Fall(board, width, height);
                     GenerateBoard(board, width, height, player1, player2, whiteSpace);
                     p1Turn = !p1Turn;
                 }
             }
        }
        public static void GenerateBoard(int[,] board, int width, int height, string p1, string p2, string whiteSpace)
        {
            for (int i = 0; i < height; i++)
            {
                for (int z = 0;z < width; z++)
                {
                    if(board[i, z] == 1) Console.Write($"{p1} ");
                    else if (board[i, z] == 2) Console.Write($"{p2} ");
                    else Console.Write($"{whiteSpace} ");

                }
                Console.WriteLine();
            }
        }

        public static void Fall(int[,] board, int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int z = 0; z < width; z++)
                {

                    if (i + 1 == height) continue;
                    if(board[i, z] == 1 && board[i + 1, z] == 0)
                    {
                        board[i, z] = 0;
                        board[i + 1, z] = 1;
                    }
                    if (board[i, z] == 2 && board[i + 1, z] == 0)
                    {
                        board[i, z] = 0;
                        board[i + 1, z] = 2;
                    }

                }
            }
        }

       
    }
}
