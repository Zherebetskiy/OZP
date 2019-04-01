namespace OZP.Abstractions.ModelInterfaces
{
    public interface IPersonElevator
    {
        IPerson Person { get; set; }
        int ElevatorId { get; set; }
    }
}
