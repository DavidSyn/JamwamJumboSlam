using Contracts.V1.Models;
using Contracts.V1.Requests;
using Api.DataLayer.Models;

namespace Api.LogicLayer.Mapper
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

        public static WeaponAbilityDto ToContract(this WeaponAbility model)
        {
            var result = new WeaponAbilityDto()
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
            };
            return result;
        }
    }
}
