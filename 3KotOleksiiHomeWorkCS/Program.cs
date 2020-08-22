using System;

namespace _3KotOleksiiHomeWorkCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Task1();
            var t2 = new Task2();
            var t3 = new Task3();
            var ut = new Utilities();
            var work = true;

            ut.ConfigApp();

            do
            {
                t1.InfoTask();
                t2.InfoTask();
                t3.InfoTask();
                ut.InfoExit();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Select a task: ");
                Console.ResetColor();

                var choice = "";
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        t1.InfoTask();
                        t1.Solution();
                        ut.ContinueMsg();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        t2.InfoTask();
                        t2.Solution();
                        ut.ContinueMsg();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        t3.InfoTask();
                        t3.Solution();
                        ut.ContinueMsg();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "exit":
                        Console.Clear();
                        ut.ExitMsg();
                        work = false;
                        break;                      
                    default:
                        ut.InputErrorMsg();
                        break;
                }
            } while (work);
        }         
    }
}