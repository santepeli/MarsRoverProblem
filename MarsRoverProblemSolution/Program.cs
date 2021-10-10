using MarsRoverService;
using System;
using System.Threading;

namespace MarsRoverProblemSolution
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread t1 = new Thread(Fon);
            t1.Start();
            Thread t2 = new Thread(Fon2);
            t2.Start();

            // Console.WriteLine("Mars Rover Problem Sollution");
            // Console.ForegroundColor = ConsoleColor.Blue;


            // Console.Write("Set Start Position : ");
            // string startPosition = Console.ReadLine().Trim();

            // Console.Write("Rover Control Command  : ");
            // string command = Console.ReadLine();
            // Console.ForegroundColor = ConsoleColor.DarkYellow;


            // new Rover()
            //.DefineCordinat("3 3 E")
            //.SetCommand("MMRMMRMRRM")
            //.Move();

            // new Rover()
            // .DefineCordinat("1 2 N")
            // .SetCommand("LMLMLMLMM")
            // .Move();


            Console.ReadLine();
        }

        public static void Fon()
        {

            var result = Rover.Instance.Move("3 3 E", "MMRMMRMRRM");

            Console.WriteLine(result);
        }

        public static void Fon2()
        {
            Console.WriteLine(Rover.Instance.Move("1 2 N", "LMLMLMLMM"));
        }
    }
}
