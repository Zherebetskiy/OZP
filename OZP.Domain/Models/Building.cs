using OZP.Abstractions.ModelInterfaces;
using System.Collections.Generic;

namespace OZP.Domain.Models
{
    public class Building : IBuilding
    {
        public List<IElevator> Elevators { get; set; }
        public List<IFlour> Flours { get; set; }
        public int MaxFlour { get; set; }

        public Building(int elevators, int flours)
        {
            Elevators = new List<IElevator>(elevators);
            Flours = new List<IFlour>(flours);
            MaxFlour = flours;
        }
    }
}
