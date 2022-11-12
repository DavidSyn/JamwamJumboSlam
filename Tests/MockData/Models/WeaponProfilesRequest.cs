using Contracts.V1.Requests;

namespace Tests.MockData.Models
{
    internal static partial class DefaultModels
    {
        internal static class WeaponProfilesRequests
        {
            internal static List<PostWeaponProfileRequest> BoltFifle()
            {
                var result = new List<PostWeaponProfileRequest>();
                result.Add(new PostWeaponProfileRequest()
                {
                    Description = DefaultValues.Weapons.Description_Default,
                    Range = DefaultValues.Weapons.Range_BoltRifle,
                    WeaponType = DefaultValues.Weapons.WeaponType_BoltRifle,
                    WeaponTypeModifier = DefaultValues.Weapons.WeaponTypeModifier_BoltRifle,
                    Strength = DefaultValues.Weapons.Strength_BoltRifle,
                    ArmourPenetration = DefaultValues.Weapons.ArmourPenetration_BoltRifle,
                    Damage = DefaultValues.Weapons.Damage_Default,
                    Abilities = new List<Contracts.V1.Models.WeaponAbilityDto>()
                });

                return result;
            }

            internal static List<PostWeaponProfileRequest> KombiRokkit()
            {
                var result = new List<PostWeaponProfileRequest>();
                result.Add(new PostWeaponProfileRequest()
                {
                    Description = DefaultValues.Weapons.Description_KombiRokkit,
                    Range = DefaultValues.Weapons.Range_KombiRokkit,
                    WeaponType = DefaultValues.Weapons.WeaponType_KombiRokkit,
                    WeaponTypeModifier = DefaultValues.Weapons.WeaponTypeModifier_KombiRokkit,
                    Strength = DefaultValues.Weapons.Strength_KombiRokkit,
                    ArmourPenetration = DefaultValues.Weapons.ArmourPenetration_KombiRokkit,
                    Damage = DefaultValues.Weapons.Damage_KombiRokkit,
                    Abilities = DefaultModels.WeaponAbilityDtos.Blast()
                });
                result.Add(new PostWeaponProfileRequest()
                {
                    Description = DefaultValues.Weapons.Description_KombiShoota,
                    Range = DefaultValues.Weapons.Range_KombiShoota,
                    WeaponType = DefaultValues.Weapons.WeaponType_KombiShoota,
                    WeaponTypeModifier = DefaultValues.Weapons.WeaponTypeModifier_KombiShoota,
                    Strength = DefaultValues.Weapons.Strength_KombiShoota,
                    ArmourPenetration = DefaultValues.Weapons.ArmourPenetration_Default,
                    Damage = DefaultValues.Weapons.Damage_Default,
                    Abilities = new List<Contracts.V1.Models.WeaponAbilityDto>()
                });

                return result;
            }

            internal static List<PostWeaponProfileRequest> FlashmetalGuns()
            {
                var result = new List<PostWeaponProfileRequest>();
                result.Add(new PostWeaponProfileRequest()
                {
                    Description = DefaultValues.Weapons.Description_FlashmetalGuns_WarpHail,
                    Range = DefaultValues.Weapons.Range_FlashmetalGuns,
                    WeaponType = DefaultValues.Weapons.WeaponType_FlashmetalGuns,
                    WeaponTypeModifier = DefaultValues.Weapons.WeaponTypeModifier_FlashmetalGuns_WarpHail,
                    Strength = DefaultValues.Weapons.Strength_FlashmetalGuns_WarpHail,
                    ArmourPenetration = DefaultValues.Weapons.ArmourPenetration_FlashmetalGuns_WarpHail,
                    Damage = DefaultValues.Weapons.Damage_Default,
                    Abilities = new List<Contracts.V1.Models.WeaponAbilityDto>()
                });
                result.Add(new PostWeaponProfileRequest()
                {
                    Description = DefaultValues.Weapons.Description_FlashmetalGuns_RuinousSalvo,
                    Range = DefaultValues.Weapons.Range_FlashmetalGuns,
                    WeaponType = DefaultValues.Weapons.WeaponType_FlashmetalGuns,
                    WeaponTypeModifier = DefaultValues.Weapons.WeaponTypeModifier_FlashmetalGuns_RuinousSalvo,
                    Strength = DefaultValues.Weapons.Strength_FlashmetalGuns_RuinousSalvo,
                    ArmourPenetration = DefaultValues.Weapons.ArmourPenetration_FlashmetalGuns_RuinousSalvo,
                    Damage = DefaultValues.Weapons.Damage_FlashmetalGuns_RuinousSalvo,
                    Abilities = new List<Contracts.V1.Models.WeaponAbilityDto>()
                });
                result.Add(new PostWeaponProfileRequest()
                {
                    Description = DefaultValues.Weapons.Description_FlashmetalGuns_FocusedMalice,
                    Range = DefaultValues.Weapons.Range_FlashmetalGuns,
                    WeaponType = DefaultValues.Weapons.WeaponType_FlashmetalGuns,
                    WeaponTypeModifier = DefaultValues.Weapons.WeaponTypeModifier_FlashmetalGuns_FocusedMalice,
                    Strength = DefaultValues.Weapons.Strength_FlashmetalGuns_FocusedMalice,
                    ArmourPenetration = DefaultValues.Weapons.ArmourPenetration_FlashmetalGuns_FocusedMalice,
                    Damage = DefaultValues.Weapons.Damage_FlashmetalGuns_FocusedMalice,
                    Abilities = new List<Contracts.V1.Models.WeaponAbilityDto>()
                });

                return result;
            }

            internal static List<PostWeaponProfileRequest> GorksKlaw()
            {
                var result = new List<PostWeaponProfileRequest>();
                result.Add(new PostWeaponProfileRequest()
                {
                    Description = DefaultValues.Weapons.Description_Default,
                    Range = DefaultValues.Weapons.Range_GorksKlaw,
                    WeaponType = DefaultValues.Weapons.WeaponType_GorksKlaw,
                    WeaponTypeModifier = DefaultValues.Weapons.WeaponTypeModifier_Melee,
                    Strength = DefaultValues.Weapons.Strength_GorksKlaw,
                    ArmourPenetration = DefaultValues.Weapons.ArmourPenetration_GorksKlaw,
                    Damage = DefaultValues.Weapons.Damage_GorksKlaw,
                    Abilities = new List<Contracts.V1.Models.WeaponAbilityDto>()
                });

                return result;
            }
        }
    }}
