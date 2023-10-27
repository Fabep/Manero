using DataAccess.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts;

public class LocalContext : DbContext
{
    public LocalContext() 
    {
        Database.Migrate(); 
    }
    public LocalContext(DbContextOptions<LocalContext> options) : base(options)
    {
        Database.Migrate();
    }
    public DbSet<ProductEntity> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer("Server=localhost;Database=ManeroDatabase;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true");
    }


    // Seedings values here when the database is created.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<ProductEntity>().HasData(ProductSeeder.SeedProducts());
        modelBuilder.Entity<ProductEntity>().HasData(new ProductEntity
        {
            ProductName = "Cool T-Shirt",
            ProductDescription = "Description",
            ProductPrice = 1000,
            Quantity = 1,
            Rating = 5
        });
        modelBuilder.Entity<ProductEntity>().HasKey(x => x.ProductId);

        base.OnModelCreating(modelBuilder);
    }
}
