namespace OZP.Abstractions.ModelInterfaces
{
    public interface IPerson
    {
        double Weight { get; set; }
        int InFlour { get; set; }
        int OutFlour { get; set; }
        DirectionType Direction { get; set; }
    }
}
