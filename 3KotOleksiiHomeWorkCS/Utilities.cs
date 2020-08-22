using System;

namespace _3KotOleksiiHomeWorkCS
{
    public class Utilities
    { 
        public void ConfigApp()
        {
            Console.Title = "3 KotOleksii HomeWork C#";
            Console.WindowWidth = 118;
            Console.WindowHeight = 25;
            WelcomeMsg();
        }

        public void InitRandomArr(int row, int column, int[,] arr, int randMax)
        {
            var rnd = new Random();
            Console.WriteLine($"Random Array {row}x{column}:\n");

            for (var i = 0; i < row; ++i)
            {
                for (var j = 0; j < column; ++j)
                {
                    arr[i, j] = rnd.Next(0, randMax);
                    Console.Write($"{arr[i, j]}   ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public void InfoExit()
        {
            Console.WriteLine("Enter <exit> if you want to exit ;)\n");
        }

        public void WelcomeMsg()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hi there! Good viewing!\n");
            Console.ResetColor();
        }

        public void InputErrorMsg()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nError! Incorrect input\n");
            Console.ResetColor();
        }

        public void ContinueMsg()
        {
            Console.WriteLine("Press any key to continue . . .\n");
        }

        public void ExitMsg()
        {
            Console.WindowWidth = 40;
            Console.WindowHeight = 4;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Thanks for your review . . . Goodbye!\n");
            Console.ResetColor();
        }
    }
}