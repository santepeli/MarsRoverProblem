using MarsRoverService;
using System;
using Xunit;

namespace UnitTestRoverControl
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Scenario_1()
        {
            //Assert.Equal("1 3 N", Rover.Instance.DefineCordinat("1 2 N").SetCommand("LMLMLMLMM").Move());
        }

        [Fact]
        public void Test_Scenario_2()
        {
            //Assert.Equal("5 1 E", Rover.Instance.DefineCordinat("3 3 E").SetCommand("MMRMMRMRRM").Move());
        }
    }
}
