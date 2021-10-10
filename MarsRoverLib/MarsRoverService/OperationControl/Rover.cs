using MarsRoverService.Helper;
using MarsRoverService.OperationControlService;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverService
{
    public sealed class Rover : IRoverOperaiton
    {
        public static char[] _commandArray;
        static volatile Rover instance;
        static object lockObject = new object();

        private object locker = new object();
        public enum RunState
        {
            Stopped,
            Starting,
            Running,
            Stopping,
        }
        private RunState _running = RunState.Stopped;

        public RunState Running
        {
            get
            {
                lock (locker)
                {
                    return _running;
                }
            }
            set
            {
                lock (locker)
                {
                    _running = value;
                }
            }
        }

        public static Rover Instance { get { return new Rover(RunState.Running); } }

        public Rover(RunState state)
        {
            Running = state;

        }

        public IRoverOperaiton DefineCordinate(string cordinat)
        {
            string[] firstPosition = cordinat.ToUpper().Split(" ");
            Possition.X = Convert.ToInt32(firstPosition[0]);
            Possition.Y = Convert.ToInt32(firstPosition[1]);
            Possition.Orientation = (Directions)Enum.Parse(typeof(Directions), firstPosition[2]);
            return this;
        }

        public IRoverOperaiton SetCommand(string command)
        {
            _commandArray = command.ToUpper().ToCharArray();
            return this;
        }

        public string Move(string coordinate, string command, string plateau = "5 5")
        {
            string target = "";

            while (Running == RunState.Running)
            {
                lock (locker)
                {
                    DefineCordinate(coordinate);
                    SetCommand(command);

                    for (int i = 0; i < _commandArray.Length; ++i)
                    {
                        if (_commandArray[i] == 'L')
                        {
                            if (Possition.Orientation == Directions.N)
                            {
                                Possition.Orientation = Directions.W;
                                continue;
                            }

                            Possition.Orientation = (Directions)(Possition.Orientation - 1);
                            continue;
                        }

                        if (_commandArray[i] == 'R')
                        {
                            if (Possition.Orientation == Directions.W)
                            {
                                Possition.Orientation = Directions.N;
                                continue;
                            }
                            Possition.Orientation = (Directions)(Possition.Orientation + 1);
                            continue;
                        }
                        RoverControl.Navigate();
                    }

                    target = Possition.X.ToString() + " " + Possition.Y.ToString() + " " + (Directions)Possition.Orientation;
                    return target;
                }
            }

            Dispose();

            return target;
        }

        public void Dispose()
        {
            lock (locker)
            {
                this.Dispose();
            }

            Running = RunState.Stopped;
        }

    }
}
