using Api.DataLayer.Enums;
using Api.DataLayer.Models;
using Contracts.V1.Requests;
using System.Runtime.CompilerServices;

namespace Api.LogicLayer.Mapper
{
    public static class WeaponProfileMapper
    {
        public static WeaponProfile ToModel(
            this PostWeaponProfileRequest request,
            bool usingMultiweaponRule = false)
        {
            var result = new WeaponProfile();
            result.Id = Guid.NewGuid();
            result.Description = MapDescription(
                request.Description,
                usingMultiweaponRule);
            result.Range = MapRange(
                request.Range);


            return result;
        }

        public static List<WeaponProfile> ToModels(this List<PostWeaponProfileRequest> requests) 
        {
            var result = new List<WeaponProfile>();
            var usingMultiweaponRule = false;

            if (requests.Count > 1)
            {
                usingMultiweaponRule = true;
            }

            foreach (var request in requests)
            {
                result.Add(ToModel(request, usingMultiweaponRule));
            }

            return result;
        }

        private static string? MapDescription(
            string? description,
            bool usingMultiweaponRule)
        {
            if (string.IsNullOrEmpty(description))
            {
                return null;
            }
            if (usingMultiweaponRule)
            {
                if (description.Substring(0, 2) != "- ")
                {
                    return $"- {description}";
                }
            }
            return description;
        }

        private static int MapRange(
            string range)
        {
            if (string.IsNullOrEmpty(range))
            {
                return 0;
            }
            if (range == WeaponTypeEnum.Melee.ToString())
            {
                return 0;
            }

            return int.Parse(range);
        }
    }
}
