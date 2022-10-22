using WamjamJumboSlam.DataLayer.Repositories;
using WamjamJumboSlam.DataLayer.Repositories.Interfaces;

namespace WamjamJumboSlam.Bootstrap
{
    public static class RegisterRepositoriesExtensions
    {
        public static void AddRepositories(
            this IServiceCollection services)
        {
            services.AddTransient<IWeaponAbilitiesRepository, WeaponAbilitiesRepository>();
        }
    }
}
