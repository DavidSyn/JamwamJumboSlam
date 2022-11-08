using Api.DataLayer.Models;
using Contracts.V1.Requests;

namespace Api.LogicLayer.Mapper
{
    public static class WeaponMapper
    {
        public static Weapon ToModel(this PostWeaponRequest request)
        {
            var result = new Weapon();

            result.Id = Guid.NewGuid();
            result.Name = request.Name;
            result.Variant = request.Variant;
            result.MultiweaponRuleExplanation = request.MultiweaponRuleExplanation;
            result.Points = request.Points;
            result.IsRelic = request.IsRelic;
            result.WeaponProfiles = 
                (request.WeaponProfiles != null) ? request.WeaponProfiles.ToModels() : new List<WeaponProfile>();

            return result;
        }
    }
}
