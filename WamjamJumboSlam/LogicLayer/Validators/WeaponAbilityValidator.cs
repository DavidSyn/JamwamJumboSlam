using Contacts.V1.Requests;
using WamjamJumboSlam.LogicLayer.Validators.Interfaces;

namespace WamjamJumboSlam.LogicLayer.Validators
{
    public class WeaponAbilityValidator : IWeaponAbilityValidator
    {
        public List<string> Validate(PostWeaponAbilityRequest request)
        {
            var errors = new List<string>();
            if (request == null)
            {
                errors.Add($"{nameof(PostWeaponAbilityRequest)} is missing.");
            }
            else
            {
                if (string.IsNullOrEmpty(request.Description))
                {
                    errors.Add($"{nameof(PostWeaponAbilityRequest)}.{nameof(request.Description)} is missing.");
                }
            }

            return errors;
        }
    }
}
