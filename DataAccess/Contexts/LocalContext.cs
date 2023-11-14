using DataAccess.Models.Entities;
using Microsoft.EntityFrameworkCore;

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
	public DbSet<CustomerEntity> Customers { get; set; }
	public DbSet<CustomerAddressEntity> CustomerAddresses  { get; set; }
	public DbSet<PaymentMethodEntity> PaymentMethods { get; set; }
	public DbSet<OrderAddressEntity> OrderAddresses { get; set; }
	public DbSet<OrdersEntity> Orders { get; set; }
	public DbSet<OrderItemsEntity> OrderItems { get; set; }
	public DbSet<OrderStatusEntity> OrderStatuses  { get; set; }
	public DbSet<WishListEntity> WishLists { get; set; }
    public DbSet<WishListItemsEntity> WishListItems { get; set; }




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

        modelBuilder.Entity<PromotionEntity>().HasData(new PromotionEntity
        {
            PromotionId = 1,
            Name = "Autumn Sale",
            Description = "Manero's best sale yet!",
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddDays(30),
            DiscountRate = 0.10,
        });

        modelBuilder.Entity<OrderStatusEntity>().HasData(OrderSeeder.SeedOrderStatus());
        modelBuilder.Entity<OrdersEntity>().HasData(OrderSeeder.SeedOrders());
        modelBuilder.Entity<OrderItemsEntity>().HasData(OrderSeeder.SeedOrderItems());

        base.OnModelCreating(modelBuilder);
    }
}
