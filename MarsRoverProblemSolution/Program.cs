using MarsRoverService;
using System;
using System.Threading;

namespace MarsRoverProblemSolution
{
    class Program
    {
        static void Main(string[] args)
        {

            //Thread t1 = new Thread(fxThread1);
            //t1.Start();
            //Thread t2 = new Thread(fxThread2);
            //t2.Start();

            Console.Write("Set Start Position : ");
            string startPosition = Console.ReadLine().Trim();

            Console.Write("Rover Control Command  : ");
            string command = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            var result = Rover.Instance.Move(startPosition, command);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void fxThread1()
        {
            Console.WriteLine(Rover.Instance.Move("3 3 E", "MMRMMRMRRM"));
        }

        public static void fxThread2()
        {
            Console.WriteLine(Rover.Instance.Move("1 2 N", "LMLMLMLMM"));
        }
    }
}
