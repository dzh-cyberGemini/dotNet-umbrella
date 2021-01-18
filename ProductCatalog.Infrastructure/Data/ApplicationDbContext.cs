using Microsoft.EntityFrameworkCore;
using ProductCatalog.Infrastructure.Data.Model;
using ProductCatalog.Infrastructure.Data;
using System;

namespace ProductCatalog.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
