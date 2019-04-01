using OZP.Abstractions;
using OZP.Abstractions.ModelInterfaces;

namespace OZP.Domain.Models
{
    public class Person : IPerson
    {
        public double Weight { get; set; }
        public int InFlour { get; set; }
        public int OutFlour { get; set; }
        public DirectionType Direction { get; set; }
    }
}
