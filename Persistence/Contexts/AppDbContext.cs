using System;
using aw_api.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace aw_api.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Category
            builder.Entity<Category>().ToTable("Categories");
            builder.Entity<Category>().HasKey(p => p.Id);

            builder.Entity<Category>().Property(p => p.Id).IsRequired()
                .ValueGeneratedOnAdd();

            builder.Entity<Category>().Property(p => p.Name).IsRequired()
                .HasMaxLength(30);

            builder.Entity<Category>().HasMany(p => p.Products)
                .WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);

            // Product
            builder.Entity<Product>().ToTable("Products");
            builder.Entity<Product>().HasKey(p => p.Id);

            builder.Entity<Product>().Property(p => p.Id).IsRequired()
                .ValueGeneratedOnAdd();

            builder.Entity<Product>().Property(p => p.Name).IsRequired()
                .HasMaxLength(50);

            builder.Entity<Product>().Property(p => p.QuantityInPackage)
                .IsRequired();

            builder.Entity<Product>().Property(p => p.UnitOfMeasurement)
                .IsRequired();
            


            // Seeding
            builder.Entity<Category>().HasData
            (
                new Category { Id = 100, Name = "Fruits"},
                new Category { Id = 101, Name = "Vegetables" }
            );
        }
    }
}
