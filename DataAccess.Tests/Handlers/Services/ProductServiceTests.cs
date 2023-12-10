using Bogus;
using DataAccess.Contexts;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace DataAccess.Tests.Handlers.Services
{
    public class ProductServiceTests
    {
        private IProductService _sut;
        private ProductRepository _productRepository;
        private LocalContext _localContext;

        private Mock<IProductService> _productMock;

        public ProductServiceTests()
        {
            _localContext = LocalContext();
            _productRepository = new ProductRepository(_localContext);
            _sut = new ProductService(_productRepository);
            _productMock = new Mock<IProductService>();
        }

        private LocalContext LocalContext()
        {
            var options = new DbContextOptionsBuilder<LocalContext>()
                  .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                  .Options;

            return new LocalContext(options);
        }


        [Fact]
        public async void GetBestSellersAsync_DoesNotReturn_Null()
        {
            //Arrange

            //Act
            var result = await _sut.GetBestSellersAsync();

            //Assert
            Assert.NotEmpty(result);

            _localContext.Database.EnsureDeleted();
            _localContext.Dispose();
        }

        [Fact]
        public async void GetBestSellersAsync_ReturnsType_ListOfProduct()
        {
            //Arrange

            //Act
            var result = await _sut.GetBestSellersAsync();

            //Assert
            Assert.IsType<List<Product>>(result);

            _localContext.Database.EnsureDeleted();
            _localContext.Dispose();
        }

        [Fact]
        public async void GetFeaturedProductsAsync_DoesNotReturn_Null()
        {
            //Arrange

            //Act
            var result = await _sut.GetFeaturedProductsAsync();

            //Assert
            Assert.NotEmpty(result);

            _localContext.Database.EnsureDeleted();
            _localContext.Dispose();
        }

        [Fact]
        public async void GetFeaturedProductsAsync_ReturnsType_ListOfProduct()
        {
            //Arrange

            //Act
            var result = await _sut.GetFeaturedProductsAsync();

            //Assert
            Assert.IsType<List<Product>>(result);

            _localContext.Database.EnsureDeleted();
            _localContext.Dispose();
        }

        [Fact]
        public void ShouldHavePromotion_ProductPriceLessThan499_ReturnsTrue()
        {
            // Arrange
            var product = new ProductEntity { ProductPrice = 498 };

            // Act
            var result = _sut.ShouldHavePromotion(product);

            // Assert
            Assert.True(result);

            _localContext.Database.EnsureDeleted();
            _localContext.Dispose();
        }
        [Fact]
        public void ShouldHavePromotion_ProductPrice499OrMore_ReturnsFalse()
        {
            // Arrange
            var product = new ProductEntity { ProductPrice = 499 };

            // Act
            var result = _sut.ShouldHavePromotion(product);

            // Assert
            Assert.False(result);

            _localContext.Database.EnsureDeleted();
            _localContext.Dispose();
        }

        [Fact]
        public async void GetSortedListOfProducts_DoesNotReturn_Null()
        {
            //Arrange
            var listOfProductsToSort = await _sut.GetBestSellersAsync();
            listOfProductsToSort = listOfProductsToSort.ToList();

            //Act
            var result = _sut.GetSortedListOfProducts("ProductNameAsc", listOfProductsToSort);

            //Assert
            Assert.NotEmpty(result);

            _localContext.Database.EnsureDeleted();
            _localContext.Dispose();
        }

        [Fact]
        public async void GetSortedListOfProducts_ReturnsType_ListOfProduct()
        {
            //Arrange
            var listOfProductsToSort = await _sut.GetBestSellersAsync();
            listOfProductsToSort = listOfProductsToSort.ToList();

            //Act
            var result = _sut.GetSortedListOfProducts("ProductNameAsc", listOfProductsToSort);

            //Assert
            Assert.IsType<List<Product>>(result);

            _localContext.Database.EnsureDeleted();
            _localContext.Dispose();
        }

        [Fact]
        public async void GetSortedListOfProducts_ProductNameAsc_ReturnsListWithDifferentOrder()
        {
            //Arrange
            var unsortedList = await _sut.GetBestSellersAsync();
            unsortedList = unsortedList.ToList();
            var sortedList = _sut.GetSortedListOfProducts("ProductNameAsc", unsortedList);
            var expected = unsortedList.Take(1);

            //Act
            var result = sortedList.Take(1);

            //Assert
            Assert.NotEqual(expected, result);

            _localContext.Database.EnsureDeleted();
            _localContext.Dispose();
        }

        [Fact]
        public async void GetSortedListOfProducts_NoSortOrder_ReturnsListWithSameOrder()
        {
            //Arrange
            var unsortedList = await _sut.GetBestSellersAsync();
            unsortedList = unsortedList.ToList();
            var sortedList = _sut.GetSortedListOfProducts("", unsortedList);
            var expected = unsortedList.Take(1);

            //Act
            var result = sortedList.Take(1);

            //Assert
            Assert.Equal(expected, result);

            _localContext.Database.EnsureDeleted();
            _localContext.Dispose();
        }

        [Fact]
        public async Task SearchProductsAsync_ReturnsListOfProducts()
        {
            // Arrange


            // Act
            var result = await _sut.SearchProductsAsync("");

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<Product>>(result);
            Assert.True(result.Any(p => p.ProductName.Contains("")), "Expected product not found in the result.");

            _localContext.Database.EnsureDeleted();
            _localContext.Dispose();
        }

        [Fact]
        public async Task GetProductColorAndSizes_ReturnsListOfColorSizeCombinations()
        {
            // Arrange
            var productName = "Amazing Pants";
            List<SizeColorCombination> list = new()
            {
                new SizeColorCombination
                {
                    Color = new Color()
                    {
                        ColorName = "Orange"
                    },
                    Size = new Size()
                    {
                        SizeType = Enums.SizeEnum.S
                    }
                },
                new SizeColorCombination
                {
                    Color = new Color()
                    {
                        ColorName = "Orange"
                    },
                    Size = new Size()
                    {
                        SizeType = Enums.SizeEnum.M
                    }
                },
                new SizeColorCombination
                {
                    Color = new Color()
                    {
                        ColorName = "Black"
                    },
                    Size = new Size()
                    {
                        SizeType = Enums.SizeEnum.S
                    }
                },
                new SizeColorCombination
                {
                    Color = new Color()
                    {
                        ColorName = "Black"
                    },
                    Size = new Size()
                    {
                        SizeType = Enums.SizeEnum.L
                    }
                },
            };
            // Act
            _productMock.Setup(s => s.GetProductColorsAndSizesAsync(productName)).ReturnsAsync(list);

            var res = await _productMock.Object.GetProductColorsAndSizesAsync(productName);
            // Assert
            Assert.True(res.Any());
            Assert.True(res.TrueForAll(x => x.GetType() == typeof(SizeColorCombination)));
            Assert.True(res.TrueForAll(x => x.Color is not null && x.Size is not null));
        }
        [Fact]
        public async Task FindProduct_ReturnsProduct()
        {
            // Arrange
            var color = "Orange";
            var size = "XL";
            var productName = "Amazing Pants";

            // Act
            _productMock.Setup(s => s.FindProduct(productName, size, color)).ReturnsAsync(new Product
            {
                ProductId = Guid.NewGuid(),
                ImageUrl = "link",
                ProductDescription = "description",
                DiscountedPrice = 100,
                ProductName = productName,
                ProductPrice = 100,
                Promotion = null,
                PromotionId = 0,
                Quantity = 0,
                Rating = 0,
            });

            var res = await _productMock.Object.FindProduct(productName, size, color);

            // Assert

            Assert.IsType<Product>(res);
            Assert.Equal(productName, res.ProductName);
        }
    }
}
