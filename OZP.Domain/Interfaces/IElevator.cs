using OZP.Domain.Models;
using System.Collections.Generic;

namespace OZP.Domain.Interfaces
{
    public interface IElevator
    {
        int Id { get; set; }
        int NextFlour { get; set; }
        DirectionType Direction { get; set; }
        List<Person> People { get; set; }
        int CurrentFlour { get; set; }
    }
}
