namespace Contracts.V1.Models
{
    public class WeaponAbilityDto
    {
        public Guid? Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
