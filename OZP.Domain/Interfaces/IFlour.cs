using System.Collections.Generic;

namespace OZP.Domain.Interfaces
{
    public interface IFlour
    {
        int Number { get; set; }
        List<IPersonElevator> ElevatorsQueue { get; set; }
    }
}
