using System;
using Xunit;
using MarsCase.Contract.Contracts;
using MarsCase.Utils.Enums;

namespace MarsCase.UnitTest
{
    public class SecondRover
    {
        [Fact]
        public void SecondRoverCase()
        {

            //Arrange
            int x = 5;
            int y = 5;

            int targetXCoordinate = 3;
            int targetYCoordinate = 3;
            string targetDirections = "MMRMMRMRRM";
            //Act
            Plateau secondPlateau = new Plateau(new Coordinate(x, y));
            Rover Step2 = new Rover(secondPlateau, new Coordinate(targetXCoordinate, targetYCoordinate), Directions.E);
            Step2.States(targetDirections);

            //Assert
            Assert.Equal("5 1 E", Step2.ToString());

        }
    }
}
