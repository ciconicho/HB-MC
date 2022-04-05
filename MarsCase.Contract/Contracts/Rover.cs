using MarsCase.Contract.Interfaces;
using MarsCase.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsCase.Contract.Contracts
{
    public class Rover : IRover
    {
        public IPlateau RoverPlateau { get; set; }
        public ICoordinate Coordinate { get; set; }
        public Directions RoverDirections { get; set; }

        public Rover(IPlateau _roverPlateau, ICoordinate _coordinate, Directions _roverDirections)
        {
            RoverPlateau = _roverPlateau;
            Coordinate = _coordinate;
            RoverDirections = _roverDirections;
        
        }

        public void States (string route)
        {
            for (int i = 0; i < route.Length; i++)
            {
                if (route[i] == 'M') {
                    GoStraight();
                }

                else if (route[i] == 'L') {
                    TurnLeft();
                }

                else if (route[i] == 'R') {
                    TurnRight();
                }
            }
        }

        private void GoStraight()
        {
            if (RoverDirections == Directions.N)
            {
                Coordinate.Y++;
            }
            else if (RoverDirections == Directions.E) {
                Coordinate.X++;
            }

            else if (RoverDirections == Directions.S) {
                Coordinate.Y--;
            }

            else if (RoverDirections == Directions.W) {
                Coordinate.X--;
            }
        }

        private void TurnLeft()
        {
           int locationL = (int)((RoverDirections - 1) < Directions.N ? Directions.W : RoverDirections - 1) % 4;

            RoverDirections = (locationL == 0 ? Directions.W : (Directions)locationL);


        }

        private void TurnRight() {
            var locationR = (int)((RoverDirections + 1) < Directions.N ? Directions.W : RoverDirections + 1) % 4;

            RoverDirections = (locationR == 0 ? Directions.W : (Directions)locationR);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Coordinate.X, Coordinate.Y, RoverDirections);
        }
    }
}
