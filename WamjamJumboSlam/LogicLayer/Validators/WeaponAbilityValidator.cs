using Contracts.V1.Requests;
using Api.LogicLayer.Validators.Interfaces;

namespace Api.LogicLayer.Validators
{
    public class WeaponAbilityValidator : IWeaponAbilityValidator
    {
        public List<string> Validate(Guid id)
        {
            var errors = new List<string>();
            if (id == Guid.Empty)
            {
                errors.Add($"{nameof(id)} is missing.");
            }

            return errors;
        }

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
