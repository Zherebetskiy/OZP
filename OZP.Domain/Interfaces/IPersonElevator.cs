using OZP.Domain.Models;

namespace OZP.Domain.Interfaces
{
    public interface IPersonElevator
    {
        Person Person { get; set; }
        int ElevatorId { get; set; }
    }
}
