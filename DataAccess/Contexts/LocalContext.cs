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
    }
    public DbSet<ProductEntity> Products { get; set; }

    public DbSet<PrimaryCategoryEntity> PrimaryCategories { get; set; }

    public DbSet<SubCategoryEntity> SubCategories { get; set; }

    public DbSet<ColorEntity> Colors { get; set; }

    public DbSet<SizesEntity> Sizes { get; set; }

    public DbSet<ProductInventoryEntity> ProductInventories { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer("Server=localhost;Database=ManeroDatabase;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true");
    }


    // Seedings values here when the database is created.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<PrimaryCategoryEntity>().HasData(CategorySeeder.SeedPrimaryCategories());

        modelBuilder.Entity<SubCategoryEntity>().HasData(CategorySeeder.SeedSubCategories());
        
        modelBuilder.Entity<ProductEntity>().HasKey(x => x.ProductId);

        base.OnModelCreating(modelBuilder);
    }
}
