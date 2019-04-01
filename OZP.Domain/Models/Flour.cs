using OZP.Abstractions.ModelInterfaces;
using System.Collections.Generic;
namespace OZP.Domain.Models
{
    public class Flour : IFlour
    {
        public int Number { get; set; }
        public List<IPersonElevator> ElevatorsQueue { get; set; }
    }
}
