using OZP.Abstractions.ModelInterfaces;

namespace OZP.Abstractions.ServiceInterfaces
{
    public interface IElevatorService
    {
        IValidationService ValidationService { get; set; }
        IFlourPersonService FlourPersonService { get; set; }
        void Break(IElevator elevator);
        void Move(IElevator elevator);
    }
}
