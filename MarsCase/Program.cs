using MarsCase.Contract.Contracts;
using MarsCase.Utils.Helper;
using MarsCase.Utils.Enums;
using System;

namespace MarsCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mars Rover");
            Console.WriteLine("\n");
            Console.WriteLine("For First Case's Parameters");
            Console.WriteLine("Grid Size 5 x 5");
            Console.WriteLine("Current Location 0.0 North");
            Console.WriteLine("Target Location 1.2 North");
            Console.WriteLine("Rover Directions LMLMLMLMM");
            Console.WriteLine("\n");
            Plateau firstPlateau = new Plateau(new Coordinate(5, 5));
            Rover Step1 = new Rover(firstPlateau, new Coordinate(1, 2), Directions.N);
            Step1.States("LMLMLMLMM");
            Console.WriteLine(Step1.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("For Second Case's Parameters");
            Console.WriteLine("Grid Size 5 x 5");
            Console.WriteLine("Current Location 0.0 North");
            Console.WriteLine("Target Location 3.3 East");
            Console.WriteLine("Rover Directions MMRMMRMRRM");
            Console.WriteLine("\n");
            Plateau secondPlateau = new Plateau(new Coordinate(5, 5));
            Rover Step2 = new Rover(secondPlateau, new Coordinate(3, 3), Directions.E);
            Step2.States("MMRMMRMRRM");
            Console.WriteLine(Step2.ToString());

            Console.WriteLine("\n");

            Console.WriteLine("Expected Outout");
            Console.WriteLine(Step1.ToString());
            Console.WriteLine(Step2.ToString());





        }
    }
}
