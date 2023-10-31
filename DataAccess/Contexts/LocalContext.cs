using DataAccess.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace DataAccess.Contexts;

public class LocalContext : DbContext
{
    public LocalContext()
    {
    }
    public LocalContext(DbContextOptions<LocalContext> options) : base(options)
    {
        Database.EnsureCreated();
        //Database.Migrate();
    }
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<PromotionEntity> Promotions { get; set; }

    public DbSet<PrimaryCategoryEntity> PrimaryCategories { get; set; }

    public DbSet<SubCategoryEntity> SubCategories { get; set; }

    public DbSet<ColorEntity> Colors { get; set; }

    public DbSet<SizeEntity> Sizes { get; set; }

    public DbSet<ProductInventoryEntity> ProductInventories { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer("Server=localhost;Database=ManeroDatabase;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true");
    }


    // Seedings values here when the database is created.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<ProductEntity>().HasKey(x => x.ProductId);

        modelBuilder.Entity<ProductEntity>()
            .HasOne(p => p.ProductInventory)
            .WithOne(i => i.Product)
            .HasForeignKey<ProductEntity>(p => p.ProductId);

        modelBuilder.Entity<PrimaryCategoryEntity>().HasData(CategorySeeder.SeedPrimaryCategories());

        modelBuilder.Entity<SubCategoryEntity>().HasData(CategorySeeder.SeedSubCategories());

        modelBuilder.Entity<ColorEntity>().HasData(ProductSeeder.SeedColors());

        modelBuilder.Entity<SizeEntity>().HasData(ProductSeeder.SeedSizes());


        modelBuilder.Entity<ProductEntity>().HasData(ProductSeeder.SeedProducts());

        modelBuilder.Entity<ProductInventoryEntity>().HasData(ProductSeeder.SeedProductInventory());



        base.OnModelCreating(modelBuilder);
    }
}
