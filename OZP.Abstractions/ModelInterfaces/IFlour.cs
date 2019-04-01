using System.Collections.Generic;

namespace OZP.Abstractions.ModelInterfaces
{
    public interface IFlour
    {
        int Number { get; set; }
        List<IPersonElevator> ElevatorsQueue { get; set; }
    }
}
