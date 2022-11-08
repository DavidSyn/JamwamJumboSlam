using Contacts.V1.Requests;

namespace WamjamJumboSlam.LogicLayer.Validators.Interfaces
{
    public interface IWeaponAbilityValidator
    {
        public List<string> Validate(Guid id);
        public List<string> Validate(PostWeaponAbilityRequest request);
    }
}
