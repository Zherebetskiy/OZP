using System.Collections.Generic;

namespace OZP.Abstractions.ModelInterfaces
{ 
    public interface IElevator
    {
        int Id { get; set; }
        int NextFlour { get; set; }
        DirectionType Direction { get; set; }
        List<IPerson> People { get; set; }
        int CurrentFlour { get; set; }
    }
}
