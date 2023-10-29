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
        //Database.Migrate();
    }
    public DbSet<ProductEntity> Products { get; set; }

    public DbSet<PrimaryCategoryEntity> PrimaryCategory { get; set; }

    public DbSet<SubCategoryEntity> SubCategory { get; set; }

    public DbSet<PrimarySubCategoryEntity> PrimarySubCategory { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer("Server=localhost;Database=ManeroDatabase;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true");
    }


    // Seedings values here when the database is created.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PrimarySubCategoryEntity>()
            .HasKey(x => new { x.PrimaryCategoryId, x.SubCategoryId });

        modelBuilder.Entity<PrimaryCategoryEntity>().HasData(new PrimaryCategoryEntity
        {
            PrimaryCategoryId = 1, 
            Name = "Women"
        });

        modelBuilder.Entity<SubCategoryEntity>().HasData(new SubCategoryEntity
        {
            SubCategoryId = 1, 
            Name = "Dress"
        });

        modelBuilder.Entity<PrimarySubCategoryEntity>().HasData(new PrimarySubCategoryEntity
        {
            PrimaryCategoryId = 1, 
            SubCategoryId = 1 
        });

        // Seed ProductEntity
        modelBuilder.Entity<ProductEntity>().HasData(new ProductEntity
        {
            ProductId = Guid.NewGuid(), 
            ProductName = "Fine dress",
            ProductDescription = "Description",
            ProductPrice = 1000,
            Quantity = 1,
            Rating = 5,
            SubCategoryId = 1 
        });

        modelBuilder.Entity<ProductEntity>().HasKey(x => x.ProductId);

        base.OnModelCreating(modelBuilder);
    }
}
