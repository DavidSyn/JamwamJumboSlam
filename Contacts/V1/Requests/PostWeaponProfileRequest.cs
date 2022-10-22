using Contacts.V1.Models;

namespace Contacts.V1.Requests
{
    public class PostWeaponProfileRequest
    {
        public string? Description { get; set; }
        public int Range { get; set; }
        public string WeaponType { get; set; } = string.Empty;
        public string? Strength { get; set; }
        public string? ArmourPenetration { get; set; }
        public string? Damage { get; set; }

        public List<WeaponAbilityDto> Abilities { get; set; } = new();
    }
}
