using Contracts.V1.Requests;

namespace Api.LogicLayer.Validators.Interfaces
{
    public interface IWeaponValidator
    {
        public List<string> Validate(PostWeaponRequest request);
    }
}
