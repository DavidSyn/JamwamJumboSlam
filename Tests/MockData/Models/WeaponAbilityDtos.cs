using Contracts.V1.Models;

namespace Tests.MockData.Models
{
    internal static partial class DefaultModels
    {
        internal static class WeaponAbilityDtos
        {
            public static List<WeaponAbilityDto> Blast()
            {
                var result = new List<WeaponAbilityDto>();
                result.Add(SetBlast());
                return result;
            } 

            private static WeaponAbilityDto SetBlast()
            {
                var result = new WeaponAbilityDto()
                {
                    Id = null,
                    Name = DefaultValues.Weapons.Abilities.Name_Blast,
                    Description = DefaultValues.Weapons.Abilities.Description_Blast
                };
                
                return result;
            }
        }
    }
}
