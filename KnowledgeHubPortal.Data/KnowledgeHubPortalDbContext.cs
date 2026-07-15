using KnowledgeHubPortal.Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KnowledgeHubPortal.Data
{
    public class KnowledgeHubPortalDbContext : DbContext
    {
        // configure database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=KnowledgeHubPortalDb;Username=postgres;Password=password@123");

        }
        // map entities to database tables
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
