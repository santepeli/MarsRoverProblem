using MarsRoverService.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverService.OperationControlService
{
    public class RoverControl
    {
        public static void Navigate()
        {
            if (Possition.Orientation == Directions.N)
                Possition.Y++;
            else if (Possition.Orientation == Directions.E)
                Possition.X++;
            else if (Possition.Orientation == Directions.S)
                Possition.Y--;
            else if (Possition.Orientation == Directions.W)
                Possition.X--;
        }
    }
}
