using Api.DataLayer.Repositories;
using Api.DataLayer.Repositories.Interfaces;

namespace Api.Bootstrap
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
