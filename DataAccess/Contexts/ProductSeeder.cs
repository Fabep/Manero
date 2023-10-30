using DataAccess.Models.Entities;

namespace DataAccess.Contexts;

internal class ProductSeeder
{
    private static string[] ClothingNames = new string[] { "T-Shirt", "Pants", "Dress", "Shoes", "Bag", "Suit" };
    private static string[] Color = new string[] { "Red", "Blue", "Green", "Yellow", "White", "Black" };
    private static string[] Size = new string[] { "XS", "S", "M", "L", "XL", "XXL" };
    private static string[] Descriptions = new string[]
    {
        "Fancy",
        "Great",
        "Warm",
        "Elegant",
        "Cozy",
        "Stylish",
        "Chic",
        "Comfortable",
        "Trendy",
        "Sophisticated",
        "Fashionable",
        "Exquisite",
        "Modern",
        "Luxurious",
        "Classy"
    };

    private static List<Guid> ProductIds = new List<Guid>();
    private static readonly Random random = new Random();
    internal static IEnumerable<ProductEntity> SeedProducts()
    {
        var baseProducts = new List<ProductEntity>();
        for (int i = 0; i <= 1; i++)
        {
            var clothingName = ClothingNames[random.Next(0, 6)];
            var description = Descriptions[random.Next(0, 15)];
            var subCategoryId = CategorySeeder.GetSubCategoryId(clothingName);

            for (int colorId = 1; colorId < 7; colorId++)
            {

                for (int sizeId = 1; sizeId < 7; sizeId++)
                {
                    ProductEntity entity = new ProductEntity()
                    {
                        ProductName = $"{description} {clothingName}",
                        ProductDescription =
                            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                        ProductPrice = random.Next(50, 1000),
                        Quantity = random.Next(0, 100),
                        Rating = random.Next(0, 5),
                        SubCategoryId = subCategoryId,
                        ColorId = colorId,
                        SizeId = sizeId

                    };

                    ProductIds.Add(entity.ProductId);
                    baseProducts.Add(entity);
                }
            }
        }
        return baseProducts;
    }


    internal static IEnumerable<ColorEntity> SeedColors()
    {
        var colors = new List<ColorEntity>();
        for (int i = 0; i < Color.Length; i++)
        {
            ColorEntity entity = new ColorEntity()
            {
                ColorId = i + 1,
                Color = Color[i],
            };
            colors.Add(entity);
        }
        return colors;
    }


    internal static IEnumerable<SizeEntity> SeedSizes()
    {
        var sizes = new List<SizeEntity>();
        for (int i = 0; i < Size.Length; i++)
        {
            SizeEntity entity = new SizeEntity()
            {
                SizeId = i + 1,
                Size = Size[i],
            };
            sizes.Add(entity);
        }
        return sizes;
    }

    internal static IEnumerable<ProductInventoryEntity> SeedProductInventory()
    {
        var productInventory = new List<ProductInventoryEntity>();
        for (int i = 0; i < ProductIds.Count; i++)
        {
            ProductInventoryEntity entity = new ProductInventoryEntity()
            {
                ProductId = ProductIds[i],
                Quantity = random.Next(20, 100),
                LastInventory = DateTime.Now
            };
            productInventory.Add(entity);
        }
        return productInventory;
    }


}
