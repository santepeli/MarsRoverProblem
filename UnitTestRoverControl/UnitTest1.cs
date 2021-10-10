using MarsRoverService;
using System;
using Xunit;

namespace UnitTestRoverControl
{
    public class UnitTest1
    {
        [Fact]
        public void TestScenarioRight()
        {
            Assert.Equal("1 3 N", Rover.Instance.Move("1 2 N", "LMLMLMLMM"));
        }

        [Fact]
        public void TestScenarioLeft()
        {
            Assert.Equal("5 1 E", Rover.Instance. Move("3 3 E", "MMRMMRMRRM"));
        }
    }
}
