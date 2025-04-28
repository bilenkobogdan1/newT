using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprises.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Notes.Domain.Entities;
namespace Notes.Aplication.EF
{
    public class AppDbContext: DbContext
    {
     //   private IConfiguration _config;
        public AppDbContext()
        {
            Database.EnsureCreated();
            IConfigurationBuilder builder;
            builder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);
            builder.Build();
            // _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
            optionsBuilder.UseSqlServer("Server=BILLBOG2407;Database=myTest;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasIndex(x => x.Articule).IsUnique();
        }
        public DbSet<HistoryMstock> Histories { get; set; }
        public DbSet<Mstock> Mstocks { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Price> Prices { get; set; }
    }
}
