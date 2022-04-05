


using MarsCase.Utils.Enums;

namespace MarsCase.Contract.Interfaces
{
    public interface IRover
    {
        IPlateau RoverPlateau { get; set; }
        ICoordinate Coordinate { get; set; }
        Directions RoverDirections { get; set; }
    }
}
