using Api.DataLayer.Enums;
using Api.LogicLayer.Validators.Interfaces;
using Contracts.V1.Requests;
using System.Text.RegularExpressions;

namespace Api.LogicLayer.Validators
{
    public class WeaponValidator : IWeaponValidator
    {
        private Regex MultiplierRegex { get; set; }
        private Regex DieModifierRegex { get; set; }
        private Regex DieRegex { get; set; }

        public WeaponValidator() 
        {
            DieRegex = new Regex("^[1-9]D[1-9]");
            DieModifierRegex = new Regex("^[1-9]D[1-9]+[1-9]");
            MultiplierRegex = new Regex("^x[1-9]");
        }

        public List<string> Validate(PostWeaponRequest request)
        {
            var result = new List<string>();

            if (request == null)
            {
                result.Add("Missing request!");
                return result;
            }

            if (string.IsNullOrEmpty(request?.Name))
            {
                result.Add($"Missing {nameof(request.Name)}");
            }

            if (request?.WeaponProfiles == null ||
                request?.WeaponProfiles.Count == 0)
            {
                result.Add($"Missing {nameof(request.WeaponProfiles)}");
            }

            if (request?.WeaponProfiles.Count == 1)
            {
                if (request?.WeaponProfiles[0] != null)
                {
                    if (!string.IsNullOrEmpty(request?.WeaponProfiles[0].Description))
                    {
                        result.Add($"Description should be null with only 1 WeaponProfile");
                    }
                }
            }

            if (request?.WeaponProfiles.Count > 1)
            {
                if (string.IsNullOrEmpty(request.MultiweaponRuleExplanation))
                {
                    result.Add($"Need {nameof(request.MultiweaponRuleExplanation)} if WeaponProfiles is above 1");
                }
            }

            foreach (var weaponProfile in request?.WeaponProfiles)
            {
                result.AddRange(
                    ValidateWeaponProfile(
                        result,
                        weaponProfile));
            }

            return result;
        }

        private List<string> ValidateWeaponProfile(
            List<string> errors,
            PostWeaponProfileRequest request)
        {
            if (!int.TryParse(request.Range, out _))
            {
                if (request.Range != WeaponTypeEnum.Melee.ToString())
                {
                    errors.Add("Range need to be Melee or a number");
                }
            }

            if (!string.IsNullOrEmpty(request.WeaponType))
            {
                if (!Enum.TryParse<WeaponTypeEnum>(request.WeaponType, out _))
                {
                    errors.Add("WeaponType does not have a correct value");
                }
            }

            if (!string.IsNullOrEmpty(request.WeaponTypeModifier))
            {
                if (!int.TryParse(request.WeaponTypeModifier, out _))
                {
                    if (!(DieRegex.IsMatch(request.WeaponTypeModifier) ||
                        MultiplierRegex.IsMatch(request.WeaponTypeModifier) ||
                        DieModifierRegex.IsMatch(request.WeaponTypeModifier)))
                    {
                        errors.Add($"{nameof(request.WeaponTypeModifier)} is wrongly formatted");
                    }
                }
            }

            if (!string.IsNullOrEmpty(request.Strength))
            {
                if (!int.TryParse(request.Strength, out _))
                {
                    if (!(DieRegex.IsMatch(request.Strength) ||
                        MultiplierRegex.IsMatch(request.Strength) ||
                        DieModifierRegex.IsMatch(request.Strength)))
                    {
                        errors.Add($"{nameof(request.Strength)} is wrongly formatted");
                    }
                }
            }

            if (!string.IsNullOrEmpty(request.ArmourPenetration))
            {
                if (!int.TryParse(request.ArmourPenetration, out _))
                {
                    errors.Add($"{nameof(request.ArmourPenetration)} is wrongly formatted");
                }
            }

            return errors;
        }
    }
}
