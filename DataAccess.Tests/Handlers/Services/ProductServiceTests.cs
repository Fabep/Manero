using DataAccess.Contexts;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
