using System;

namespace _3KotOleksiiHomeWorkCS
{
    class Task2
    {
        private int _row;
        private int _column;
        private int[,] _arr;
        private int _num;
        private int _amount;
        private int _randMax;
        private Utilities ut;

        public Task2()
        {
            _row = 5;
            _column = 5;
            _arr = new int[_row, _column];
            _num = 0;
            _amount = 0;
            _randMax = 10;
            ut = new Utilities();
        }

        public void InfoTask()
        {
            Console.WriteLine("2. Write a program that prompts the user to enter a number and counts how many times that number occurs in an array. \n");
        }

        public void Solution()
        {
            _amount = 0;
            ut.InitRandomArr(_row, _column, _arr, _randMax);

            Console.Write("Input number: ");

            if (int.TryParse(Console.ReadLine(), out _num) == false ||
                (_num < 0 || _num >= _randMax))
            {
                ut.InputErrorMsg();
                return;
            }
            else
                for (var i = 0; i < _row; ++i)
                    for (var j = 0; j < _column; ++j)
                        if (_arr[i, j] == _num)
                            _amount++;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nYour number occurs in the array {_amount} times\n");
            Console.ResetColor();
        }
    }
}