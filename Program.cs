using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProductCatalog.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.Utilities;

namespace ProductCatalog
{
    class Program
    {
        //public static object DependancyRe { get; private set; }

        static void Main(string[] args)
        {
            var serviceProvider = DependancyResolver.GetServiceProvider();
            var app = serviceProvider.GetService<Application>();


            using (serviceProvider.CreateScope())
            {
                app.Run(args);
            }

            //CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddDbContext<ApplicationDbContext>(op => op.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=dotNetCore-roductCatalog;Trusted_Connection=True;MultipleActiveResultSets=true"));

                });
        }
    }
}
