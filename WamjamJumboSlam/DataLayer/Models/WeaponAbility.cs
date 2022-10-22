namespace WamjamJumboSlam.DataLayer.Models
{
    public class WeaponAbility
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<WeaponProfile> Weapons { get; set; } = new();
    }
}
