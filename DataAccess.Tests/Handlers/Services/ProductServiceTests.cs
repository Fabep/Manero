using DataAccess.Contexts;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models.Entities;
using Moq;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Tests.Handlers.Services
{
    public class ProductServiceTests
    {
        private IProductService _sut;
        private ProductRepository _productRepository;
        private LocalContext _localContext;

        public ProductServiceTests()
        {
            _localContext = new LocalContext();
            _productRepository = new ProductRepository(_localContext);
            _sut = new ProductService(_productRepository);
        }


        [Fact]
        public async void GetBestSellersAsync_DoesNotReturn_Null()
        {
            //Arrange

            //Act
            var result = await _sut.GetBestSellersAsync();

            //Assert
            Assert.NotEmpty(result);
        }

        [Fact]
        public async void GetBestSellersAsync_ReturnsType_ListOfProduct()
        {
            //Arrange

            //Act
            var result = await _sut.GetBestSellersAsync();

            //Assert
            Assert.IsType<List<Product>>(result);
        }

        [Fact]
        public async void GetFeaturedProductsAsync_DoesNotReturn_Null()
        {
            //Arrange

            //Act
            var result = await _sut.GetFeaturedProductsAsync();

            //Assert
            Assert.NotEmpty(result);
        }

        [Fact]
        public async void GetFeaturedProductsAsync_ReturnsType_ListOfProduct()
        {
            //Arrange

            //Act
            var result = await _sut.GetFeaturedProductsAsync();

            //Assert
            Assert.IsType<List<Product>>(result);
        }

        [Fact]
        public void ShouldHavePromotion_ProductPriceLessThan799_ReturnsTrue()
        {
            // Arrange
            var product = new ProductEntity { ProductPrice = 498 };

            // Act
            var result = _sut.ShouldHavePromotion(product);

            // Assert
            Assert.True(result);
        }
        [Fact]
        public void ShouldHavePromotion_ProductPrice799OrMore_ReturnsFalse()
        {
            // Arrange
            var product = new ProductEntity { ProductPrice = 499 };

            // Act
            var result = _sut.ShouldHavePromotion(product);

            // Assert
            Assert.False(result);
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
        }

		[Fact]
		public async Task SearchProductsAsync_ReturnsListOfProducts()
		{
			// Arrange
			

			// Act
			var result = await _sut.SearchProductsAsync("Cozy Suit");

			// Assert
			Assert.NotNull(result);
			Assert.IsType<List<Product>>(result);
			Assert.True(result.Any(p => p.ProductName.Contains("Cozy Suit")), "Expected product not found in the result.");
		}

		



	}
}
