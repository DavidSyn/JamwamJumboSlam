using Microsoft.EntityFrameworkCore;
using WamjamJumboSlam.Bootstrap;
using WamjamJumboSlam.DataLayer;

namespace WamjamJumboSlam
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
            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING")));
           

            services.AddSwagger();
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            app.ConfigureSwagger();

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
