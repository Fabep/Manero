using DataAccess.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts;

public class LocalContext : DbContext
{
    public LocalContext() { }
    public LocalContext(DbContextOptions<LocalContext> options) : base(options)
    {
        if (Database.EnsureCreated())
            Database.Migrate();
    }
    public DbSet<ProductEntity> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer();


    // Seedings values here when the database is created.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductEntity>().HasData(ProductSeeder.SeedProducts());

        base.OnModelCreating(modelBuilder);
    }
}
