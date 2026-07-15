using Microsoft.EntityFrameworkCore;
using ProductsManagementConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsManagementConsoleApp.DataLayer
{
    public class ProductsDbContext : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the Database
            optionsBuilder.UseNpgsql("host=localhost; port=5432; database=KalkiTechProductsDB; username=postgres; password=password@123").LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        }

        // Map the entity class to a database table
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
