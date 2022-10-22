namespace Contacts.V1.Requests
{
    public class PostWeaponRequest
    {
        public string Name { get; set; } = string.Empty;
        public string? Variant { get; set; }
        public string? MultiweaponRuleExplanation { get; set; }
        public int Points { get; set; }
        public bool IsRelic { get; set; }
        public List<PostWeaponProfileRequest> WeaponProfiles { get; set; } = new();
    }
}
