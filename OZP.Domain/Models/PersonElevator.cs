using OZP.Abstractions.ModelInterfaces;

namespace OZP.Domain.Models
{
    public class PersonElevator : IPersonElevator
    {
        public IPerson Person { get; set; }
        public int ElevatorId { get; set; }
    }
}
