using Contracts.V1.Requests;

namespace Api.LogicLayer.Validators.Interfaces
{
    public interface IWeaponAbilityValidator
    {
        public List<string> Validate(Guid id);
        public List<string> Validate(PostWeaponAbilityRequest request);
    }
}
