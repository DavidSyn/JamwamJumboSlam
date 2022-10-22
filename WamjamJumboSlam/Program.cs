namespace WamjamJumboSlam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var startup = new Startup(builder.Configuration);

            startup.RegisterServices(builder.Services);

            var webApplication = builder.Build();
            startup.Configure(webApplication, webApplication.Environment);
        }
    }
}