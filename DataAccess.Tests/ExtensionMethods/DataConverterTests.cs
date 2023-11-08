using DataAccess.ExtensionMethods;
using DataAccess.Models.Entities;
using DataAccess.Models.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Tests.ExtensionMethods
{
    public class DataConverterTests
    {
        private readonly ProductSchema _schema = new ProductSchema
        {
            ProductName = "Test",
            ProductDescription = "Test Description",
            ProductPrice = 50,
            Quantity = 1,
        };
        [Fact]
        public void ProductSchema_Should_ConvertToProductEntity_When_DataConverterIsCalled()
        {
            // Act
            var result = _schema.ConvertProductSchemaToProductEntity();

            // Assert
            Assert.True(result is ProductEntity);
        }
        [Fact]
        public void When_ProductSchema_IsConvertedToProjectEntity_ItHasTheSameValuesAsTheSchema()
        {

            var result = _schema.ConvertProductSchemaToProductEntity();

            Assert.Equal(_schema.ProductName, result.ProductName);
            Assert.Equal(_schema.ProductPrice, result.ProductPrice);
            Assert.Equal(_schema.ProductDescription, result.ProductDescription);
            Assert.Equal(_schema.Quantity, result.ProductInventory!.Quantity);
        }
    }
}
