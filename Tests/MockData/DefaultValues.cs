using Api.DataLayer.Enums;

namespace Tests.MockData
{
    internal static class DefaultValues
    {
        internal static class Weapons
        {
            public static string Name_BoltRifle => "Bolt Rifle";
            public static string Name_KombiRokkit => "Kombi-rokkit";
            public static string Name_FlashmetalGuns => "Flashmetal Guns";
            public static string Name_GorksKlaw => "Gork's Klaw";
            public static string WeaponVariant_Default => null;
            public static string MultiweaponRuleExplanation_Default => null;
            public static string MultiweaponRuleExplanation_Kombi => "Before selecting targets, select one or both of the profiles below to make attacks with. If you select both, then each time an attack is made with this weapon this phase, subtract 1 from that attack’s hit roll.";
            public static string MultiweaponRuleExplanation_FlashmetalGuns => "Before selecting targets, select one of the profiles below to make attacks with.";
            public static int Points_Default => 0;
            public static bool IsRelic_Default => false;
            public static string Description_Default => null;
            public static string Description_KombiRokkit => "Rokkit";
            public static string Description_KombiShoota => "Shoota";
            public static string Description_FlashmetalGuns_WarpHail => "Warp Hail";
            public static string Description_FlashmetalGuns_RuinousSalvo => "Ruinous Salvo";
            public static string Description_FlashmetalGuns_FocusedMalice => "Focused Malice";
            public static string Range_BoltRifle => "30";
            public static string Range_KombiRokkit => "24";
            public static string Range_KombiShoota => "18";
            public static string Range_FlashmetalGuns => "24";
            public static string Range_GorksKlaw => "Melee";
            public static string WeaponType_BoltRifle => WeaponTypeEnum.RapidFire.ToString();
            public static string WeaponType_KombiRokkit => WeaponTypeEnum.Heavy.ToString();
            public static string WeaponType_KombiShoota => WeaponTypeEnum.Dakka.ToString();
            public static string WeaponType_FlashmetalGuns => WeaponTypeEnum.Heavy.ToString();
            public static string WeaponType_GorksKlaw => WeaponTypeEnum.Melee.ToString();
            public static string WeaponTypeModifier_Melee => null;
            public static string WeaponTypeModifier_BoltRifle => "2";
            public static string WeaponTypeModifier_KombiRokkit => "1D2";
            public static string WeaponTypeModifier_KombiShoota => "3";
            public static string WeaponTypeModifier_FlashmetalGuns_WarpHail => "1D6+9";
            public static string WeaponTypeModifier_FlashmetalGuns_RuinousSalvo => "1D3+3";
            public static string WeaponTypeModifier_FlashmetalGuns_FocusedMalice => "1D3";
            public static string Strength_BoltRifle => "4";
            public static string Strength_KombiRokkit => "8";
            public static string Strength_KombiShoota => "4";
            public static string Strength_FlashmetalGuns_WarpHail => "5";
            public static string Strength_FlashmetalGuns_RuinousSalvo => "7";
            public static string Strength_FlashmetalGuns_FocusedMalice => "9";
            public static string Strength_GorksKlaw => "x2";
            public static string ArmourPenetration_BoltRifle => "-1";
            public static string ArmourPenetration_KombiRokkit => "-2";
            public static string ArmourPenetration_Default => "0";
            public static string ArmourPenetration_FlashmetalGuns_WarpHail => "-1";
            public static string ArmourPenetration_FlashmetalGuns_RuinousSalvo => "-2";
            public static string ArmourPenetration_FlashmetalGuns_FocusedMalice => "-3";
            public static string ArmourPenetration_GorksKlaw => "-4";
            public static string Damage_KombiRokkit => "3";
            public static string Damage_Default => "1";
            public static string Damage_FlashmetalGuns_RuinousSalvo => "2";
            public static string Damage_FlashmetalGuns_FocusedMalice => "4";
            public static string Damage_GorksKlaw => "4";

            public static class Abilities
            {
                public static string Name_Blast => "Blast";
                public static string Description_Blast => "Blast";
            }
        }
    }
}
