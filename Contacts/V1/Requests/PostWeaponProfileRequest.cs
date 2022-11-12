using Contracts.V1.Models;

namespace Contracts.V1.Requests
{
    public class PostWeaponProfileRequest
    {
        public string? Description { get; set; }
        public string Range { get; set; } = string.Empty;
        public string WeaponType { get; set; } = string.Empty;
        public string WeaponTypeModifier { get; set; } = string.Empty;
        public string? Strength { get; set; }
        public string? ArmourPenetration { get; set; }
        public string? Damage { get; set; }

        public List<WeaponAbilityDto> Abilities { get; set; } = new();
    }
}
