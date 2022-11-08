using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Api.DataLayer;

namespace Api.Bootstrap
{
    public static class RegisterDatabaseExtensions
    {
        public static void AddDatabase(
            this IServiceCollection services,
            string? connectionString)
        {
            ArgumentNullException.ThrowIfNull(connectionString);

            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(connectionString));
        }

        public static void SetupDatabase(
            this WebApplication app,
            string? rebuildDatabase)
        {
            ArgumentNullException.ThrowIfNull(rebuildDatabase);

            if (!string.IsNullOrEmpty(rebuildDatabase) &&
                rebuildDatabase == "true")
            {
                using (var scope = app?.Services?.GetService<IServiceScopeFactory>()?.CreateScope())
                {
                    using (var dbContext = scope?.ServiceProvider.GetRequiredService<DatabaseContext>())
                    {
                        if (dbContext != null)
                        {
                            dbContext.Database.EnsureCreated();
                        }
                        else
                        {
                            throw new NullReferenceException("DatabaseContext could not be resolved!");
                        }
                    }
                } 
            }
        }
    }
}
