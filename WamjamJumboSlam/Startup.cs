using Microsoft.AspNetCore.RateLimiting;
using System.Threading.RateLimiting;
using Api.Bootstrap;

namespace Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void RegisterServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddRateLimiting();
            services.AddSwagger();

            services.AddDatabase(
                Configuration["AZURE_SQL_CONNECTIONSTRING"]);
            services.AddRepositories();
            services.AddValidators();
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            app.ConfigureSwagger();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.UseRateLimiter();
            app.MapControllers();

            app.SetupDatabase(
                Configuration["REBUILD_DATABASE"]);

            app.Run();
        }
    }
}
