using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductCatalog.Core.Contracts;
using ProductCatalog.Core.Services;
using ProductCatalog.Infrastructure.Data;
using ProductCatalog.Infrastructure.Data.Common;
using ProductCatalog.Pages;
using System;


namespace ProductCatalog.Utilities
{
    public static class DependancyResolver
    {
        public static IServiceProvider GetServiceProvider()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IRepository, Repository>();
            services.AddSingleton<Application>();
            services.AddScoped<Menu>();
            services.AddScoped<ProductPage>();
            services.AddScoped<IProductService, ProductService>();

            services.AddDbContext<ApplicationDbContext>(op => op.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=dotNetCore-roductCatalog;Trusted_Connection=True;MultipleActiveResultSets=true"));

            return services.BuildServiceProvider();
        }
    }
}
