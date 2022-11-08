using WamjamJumboSlam.LogicLayer.Validators.Interfaces;
using WamjamJumboSlam.LogicLayer.Validators;

namespace WamjamJumboSlam.Bootstrap
{
    public static class RegisterValidatorsExtensions
    {
        public static void AddValidators(
            this IServiceCollection services)
        {
            services.AddTransient<IWeaponAbilityValidator, WeaponAbilityValidator>();
        }
    }
}
