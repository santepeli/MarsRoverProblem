using MarsRoverService;
using System;

namespace MarsRoverProblemSolution
{
    class Program
    {
        static void Main()
        {
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            //Console.WriteLine("Mars Rover Project!");

            //Console.ForegroundColor = ConsoleColor.Cyan;

            //Console.Write("Plato Max Point : ");
            //string maxPoint = Console.ReadLine();

            //Console.Write("Start Position : ");
            //var startPosition = Console.ReadLine().Trim().Split(' ');

            //Console.WriteLine("Hello World!");
            //Console.ReadLine();


            Console.WriteLine("Hello World!");
            new Rover()
            .DefineCordinat("1 2 N")
            .DefineCommand("LMLMLMLMM")
            .Run();


            Console.ReadLine();
        }
    }
}
