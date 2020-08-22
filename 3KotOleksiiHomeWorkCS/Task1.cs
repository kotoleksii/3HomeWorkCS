using System;
using System.Linq;

namespace _3KotOleksiiHomeWorkCS
{
    class Task1
    {
        private int _value;
        private int _reverseValue;
        private Utilities ut;

        public Task1()
        {
            _value = _reverseValue = 0;
            ut = new Utilities();
        }

        public void InfoTask()
        {
            Console.WriteLine("1. Given an integer N greater than 0, find the number obtained by reading the number N from right to left. \n");
        }

        public void Solution()
        {
            Console.Write("Enter the value: ");

            if (int.TryParse(Console.ReadLine(), out _value) == false || (_value <= 0))
            {
                ut.InputErrorMsg();
                return;
            }
            else
                _reverseValue = int.Parse(new string(_value.ToString().Reverse().ToArray()));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Reverse value:   {_reverseValue} \n");
            Console.ResetColor();
        }
    }
}