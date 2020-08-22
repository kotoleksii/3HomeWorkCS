using System;

namespace _3KotOleksiiHomeWorkCS
{
    class Task3
    {
        private int _row;
        private int _column;
        private int[,] _arr;
        private int _choice;
        private int _firstColumn;
        private int _secondColumn;
        private int _randMax;
        private Utilities ut;

        public Task3()
        {
            _row = 5;
            _column = 20;
            _arr = new int[_row, _column];
            _choice = 0;
            _firstColumn = 0;
            _secondColumn = 0;
            _randMax = 10;
            ut = new Utilities();
        }

        public void InfoTask()
        {
            Console.WriteLine("3. In a two-dimensional array of order M by N, swap the given columns.\n");
        }

        public void Solution()
        {
            ut.InitRandomArr(_row, _column, _arr, _randMax);

            Console.WriteLine("Replace columns! ");

            Console.Write("Select the first column: ");
            if ((int.TryParse(Console.ReadLine(), out _firstColumn) == false ||
                (_firstColumn <= 0 || _firstColumn > _column)))
            {
                ut.InputErrorMsg();
                return;
            }
            
            Console.Write("Select the second column: ");
            if ((int.TryParse(Console.ReadLine(), out _secondColumn) == false ||
                (_secondColumn <= 0 || _secondColumn > _column)))
            {
                ut.InputErrorMsg();
                return;
            }

            Console.WriteLine();

            for (var i = 0; i < _row; ++i)
            {
                _choice = _arr[i, _firstColumn - 1];
                _arr[i, _firstColumn - 1] = _arr[i, _secondColumn - 1];
                _arr[i, _secondColumn - 1] = _choice;
            }

            Console.ForegroundColor = ConsoleColor.Green;

            for (var i = 0; i < _row; ++i)
            {
                for (var j = 0; j < _column; ++j)
                {
                    Console.Write($"{_arr[i, j]}   ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ResetColor();
        }
    }
}