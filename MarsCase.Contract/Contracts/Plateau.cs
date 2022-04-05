using MarsCase.Contract.Contracts;
using MarsCase.Contract.Interfaces;

namespace MarsCase.Contract.Contracts
{
    public class Plateau : IPlateau
    {
        public Coordinate PlateauCoordinates { get; set; }

        public Coordinate PlateauCoordinate { get; set; }

        public Plateau(Coordinate coordinate)
        {
            PlateauCoordinates = coordinate;
        
        }

    
    }
}
