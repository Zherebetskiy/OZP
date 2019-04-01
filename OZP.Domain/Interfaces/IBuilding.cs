using System.Collections.Generic;

namespace OZP.Domain.Interfaces
{
    public interface IBuilding
    {
         List<IElevator> Elevators { get; set; }
         List<IFlour> Flours { get; set; }
         int MaxFlour { get; set; }
    }
}
