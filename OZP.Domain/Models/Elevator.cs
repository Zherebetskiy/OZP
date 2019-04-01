using OZP.Abstractions;
using OZP.Abstractions.ModelInterfaces;
using System.Collections.Generic;

namespace OZP.Domain.Models
{
    public class Elevator : IElevator
    {
        public int Id { get; set; }
        public int NextFlour { get; set; }
        public DirectionType Direction { get; set; }
        public List<IPerson> People { get; set; }
        public int CurrentFlour { get; set; }
    }
}
