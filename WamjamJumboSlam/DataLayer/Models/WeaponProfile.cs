using WamjamJumboSlam.DataLayer.Enums;

namespace WamjamJumboSlam.DataLayer.Models
{
    public class WeaponProfile
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public int Range { get; set; }

        public WeaponTypeEnum WeaponType { get; set; }
        public int WeaponTypeNumberOfDice { get; set; }
        public DieType WeaponTypeDieType { get; set; }
        public int WeaponTypeModifier { get; set; }

        public int? Strength { get; set; }
        public ModifierType StrengthModifierType { get; set; }
        
        public int? ArmourPenetration { get; set; }

        public int? DamageNumberOfDice { get; set; }
        public DieType DamageDieType { get; set; }
        public int DamageModifier { get; set; }

        public List<WeaponAbility> Abilities { get; set; } = new();
    }
}
