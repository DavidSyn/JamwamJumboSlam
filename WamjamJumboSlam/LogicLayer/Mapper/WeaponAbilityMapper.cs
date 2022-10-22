using Contacts.V1.Requests;
using WamjamJumboSlam.DataLayer.Models;

namespace WamjamJumboSlam.LogicLayer.Mapper
{
    public static class WeaponAbilityMapper
    {
        public static WeaponAbility ToModel(this PostWeaponAbilityRequest request)
        {
            var result = new WeaponAbility()
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
            };
            return result;
        }
    }
}
