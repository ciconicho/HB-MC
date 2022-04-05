using System;
using Xunit;
using MarsCase.Contract.Contracts;
using MarsCase.Utils.Enums;

namespace MarsCase.UnitTest
{
    public class FirstRover
    {
        [Fact]
        public void FirstRoverCase()
        {

            //Arrange
            int x = 5;
            int y = 5;

            int targetXCoordinate = 1;
            int targetYCoordinate = 2;
            string targetDirections = "LMLMLMLMM";
            //Act
            Plateau secondPlateau = new Plateau(new Coordinate(x, y));
            Rover Step1 = new Rover(secondPlateau, new Coordinate(targetXCoordinate, targetYCoordinate), Directions.N);
            Step1.States(targetDirections);

            //Assert
            Assert.Equal("1 3 N", Step1.ToString());

        }
    }
}
