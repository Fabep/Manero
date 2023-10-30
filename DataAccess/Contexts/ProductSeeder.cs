using DataAccess.Models.Entities;

namespace DataAccess.Contexts;

internal class ProductSeeder
{
    private static string[] ClothingNames = new string[] {"T-Shirt", "Pants", "Dress", "Shoes", "Bag", "Suit"};
    private static string[] Color = new string[] {"Red", "Blue", "Green", "Yellow", "White", "Black" };
    private static readonly Random random = new Random();
    internal static IEnumerable<ProductEntity> SeedProducts()
    {
        var baseProducts = new List<ProductEntity>();
        for (int i = 0; i <= 20;  i++)
        {
            ProductEntity entity = new ProductEntity()
            {
                ProductName = $"{ClothingNames[random.Next(0, 6)]} {Color[random.Next(0, 6)]}",
                ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                ProductPrice = random.Next(50, 1000),
                Quantity = random.Next(0, 100),
                Rating = random.Next(0, 5),
            };
            baseProducts.Add(entity);
        }
        return baseProducts;
    }
}
