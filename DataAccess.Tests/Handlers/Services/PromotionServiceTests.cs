using DataAccess.Contexts;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Handlers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models.Schemas;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Tests.Handlers.Services
{
    public class PromotionServiceTests
    {
        private IPromotionService _sut;
        private PromotionCodeRepository _promotionCodeRepository;
        private LocalContext _localContext;

        public PromotionServiceTests()
        {
            _localContext = LocalContext();
            _promotionCodeRepository = new PromotionCodeRepository(_localContext);
            _sut = new PromotionService(_promotionCodeRepository);

        }

        private LocalContext LocalContext()
        {
            var options = new DbContextOptionsBuilder<LocalContext>()
                  .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                  .Options;

            return new LocalContext(options);
        }

        [Fact]
        public async Task GetPromotionCode_ReturnsExistingPromotionCode()
        {
            // Arrange
            var expectedResult = "MANERONEW";
            // Act
            var result = await _sut.GetPromotionCode(expectedResult);
            // Assert
            Assert.Equal(result.Name, expectedResult);

            _localContext.Database.EnsureDeleted();
            _localContext.Dispose();
        }

        [Fact]
        public async Task GetPromotionCode_ReturnsNull_WhenPromotionCodeDoesNotExist()
        {
            // Arrange
            var query = "MANERO";
            // Act
            var result = await _sut.GetPromotionCode(query);
            // Assert
            Assert.Null(result);

            _localContext.Database.EnsureDeleted();
            _localContext.Dispose();
        }


        [Fact]
        public void CalculatePromotionCodeDiscount_ReturnsCorrectDiscountAmount()
        {

            // Arrange
            var discountPercentage = 0.15m;
            var totalValueBeforeDiscount = 500;
            var expectedResult = 75;
            // Act
            var result = _sut.CalculatePromotionCodeDiscount(discountPercentage, totalValueBeforeDiscount);


            // Assert
            Assert.Equal(result, expectedResult);

            _localContext.Database.EnsureDeleted();
            _localContext.Dispose();
        }



    }
}
