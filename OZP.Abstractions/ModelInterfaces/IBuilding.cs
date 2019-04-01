using System.Collections.Generic;

namespace OZP.Abstractions.ModelInterfaces
{
    public interface IBuilding
    {
         List<IElevator> Elevators { get; set; }
         List<IFlour> Flours { get; set; }
         int MaxFlour { get; set; }
    }
}
