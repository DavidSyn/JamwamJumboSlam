namespace WamjamJumboSlam.DataLayer.Models
{
    public class Weapon
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Variant { get; set; }
        public string? MultiweaponRuleExplanation { get; set; }
        public int Points { get; set; }
        public bool IsRelic { get; set; }
        public List<WeaponProfile> WeaponProfiles { get; set; } = new();

    }
}
