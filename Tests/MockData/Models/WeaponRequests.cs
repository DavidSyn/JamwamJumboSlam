using Contracts.V1.Requests;

namespace Tests.MockData.Models
{
    internal static partial class DefaultModels
    {
        internal static class WeaponRequests
        {
            internal static PostWeaponRequest BoltRifle()
            {
                var result = new PostWeaponRequest()
                {
                    Name = DefaultValues.Weapons.Name_BoltRifle,
                    Variant = DefaultValues.Weapons.WeaponVariant_Default,
                    MultiweaponRuleExplanation = DefaultValues.Weapons.MultiweaponRuleExplanation_Default,
                    Points = DefaultValues.Weapons.Points_Default,
                    IsRelic = DefaultValues.Weapons.IsRelic_Default,
                    WeaponProfiles = DefaultModels.WeaponProfilesRequests.BoltFifle()
                };
                return result;
            }

            internal static PostWeaponRequest KombiRokkit()
            {
                var result = new PostWeaponRequest()
                {
                    Name = DefaultValues.Weapons.Name_KombiRokkit,
                    Variant = DefaultValues.Weapons.WeaponVariant_Default,
                    MultiweaponRuleExplanation = DefaultValues.Weapons.MultiweaponRuleExplanation_Kombi,
                    Points = DefaultValues.Weapons.Points_Default,
                    IsRelic = DefaultValues.Weapons.IsRelic_Default,
                    WeaponProfiles = DefaultModels.WeaponProfilesRequests.KombiRokkit()
                };
                return result;
            }

            internal static PostWeaponRequest FlashmetalGuns()
            {
                var result = new PostWeaponRequest()
                {
                    Name = DefaultValues.Weapons.Name_FlashmetalGuns,
                    Variant = DefaultValues.Weapons.WeaponVariant_Default,
                    MultiweaponRuleExplanation = DefaultValues.Weapons.MultiweaponRuleExplanation_FlashmetalGuns,
                    Points = DefaultValues.Weapons.Points_Default,
                    IsRelic = DefaultValues.Weapons.IsRelic_Default,
                    WeaponProfiles = DefaultModels.WeaponProfilesRequests.KombiRokkit()
                };
                return result;
            }

            internal static PostWeaponRequest GorksKlaw()
            {
                var result = new PostWeaponRequest()
                {
                    Name = DefaultValues.Weapons.Name_GorksKlaw,
                    Variant = DefaultValues.Weapons.WeaponVariant_Default,
                    MultiweaponRuleExplanation = DefaultValues.Weapons.MultiweaponRuleExplanation_Default,
                    Points = DefaultValues.Weapons.Points_Default,
                    IsRelic = DefaultValues.Weapons.IsRelic_Default,
                    WeaponProfiles = DefaultModels.WeaponProfilesRequests.GorksKlaw()
                };
                return result;
            }
        }
    }
}
