using OZP.Abstractions.ModelInterfaces;

namespace OZP.Abstractions.ServiceInterfaces
{
    public interface IValidationService
    {
        void Validate(IElevator elevator, IPerson person);
    }
}
