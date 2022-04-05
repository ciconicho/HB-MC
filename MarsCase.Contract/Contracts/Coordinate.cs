﻿
using MarsCase.Contract.Interfaces;

namespace MarsCase.Contract.Contracts
{
    public class Coordinate : ICoordinate
    {

        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
