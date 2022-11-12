using Api.LogicLayer.Validators.Interfaces;
using Api.LogicLayer.Validators;

namespace Api.Bootstrap
{
    public static class RegisterValidatorsExtensions
    {
        public static void AddValidators(
            this IServiceCollection services)
        {
            services.AddTransient<IWeaponAbilityValidator, WeaponAbilityValidator>();
            services.AddTransient<IWeaponValidator, WeaponValidator>();
        }
    }
}
