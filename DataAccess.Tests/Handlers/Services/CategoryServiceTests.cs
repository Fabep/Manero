using DataAccess.Contexts;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Tests.Handlers.Services
{
    public class CategoryServiceTests
    {
        private ICategoryService _sut;
        private SubCategoryRepository _subCategoryRepository;
        private LocalContext _localContext;

        public CategoryServiceTests()
        {
            _localContext = LocalContext();
            _subCategoryRepository = new SubCategoryRepository(_localContext);
            _sut = new CategoryService(_subCategoryRepository);

        }

        private LocalContext LocalContext()
        {
            var options = new DbContextOptionsBuilder<LocalContext>()
                  .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                  .Options;

            return new LocalContext(options);
        }

        [Fact]
        public async Task GetAllPrimaryCategories_ReturnsListOfPrimaryCategories()
        {
            //Arrange

            //Act
            var result = await _sut.GetAllPrimaryCategories();

            //Assert
            Assert.NotNull(result);
            Assert.IsType<List<PrimaryCategory>>(result);
            Assert.Contains(result, p => p.PrimaryCategoryName.Contains("Men"));
            Assert.Contains(result, p => p.PrimaryCategoryName.Contains("Women"));
            Assert.Contains(result, p => p.PrimaryCategoryName.Contains("Unisex"));

        }

        [Fact]
        public async Task GetSubCategoriesByPrimaryCategoryIdMen_ReturnsListOfSubCategories_AssociatedWithPrimaryCategoryId()
        {
            //Arrange
            var primaryCategoryId = 1;


            //Act
            var result = await _sut.GetSubCategoriesByPrimaryCategoryId(primaryCategoryId);

            //Assert
            Assert.NotNull(result);
            Assert.IsType<List<SubCategory>>(result);
            Assert.Contains(result, p => p.SubCategoryName.Contains("Men"));
            Assert.Contains(result, p => p.SubCategoryName.Contains("Suits"));


        }


        [Fact]
        public async Task GetSubCategoriesByPrimaryCategoryIdWomen_ReturnsListOfSubCategories_AssociatedWithPrimaryCategoryId()
        {
            //Arrange
            var primaryCategoryId = 2;


            //Act
            var result = await _sut.GetSubCategoriesByPrimaryCategoryId(primaryCategoryId);

            //Assert
            Assert.NotNull(result);
            Assert.IsType<List<SubCategory>>(result);
            Assert.Contains(result, p => p.SubCategoryName.Contains("Women"));
            Assert.Contains(result, p => p.SubCategoryName.Contains("Dresses"));


        }



        [Fact]
        public async Task GetSubCategoriesByPrimaryCategoryIdUnisex_ReturnsListOfSubCategories_AssociatedWithPrimaryCategoryId()
        {
            //Arrange
            var primaryCategoryId = 3;


            //Act
            var result = await _sut.GetSubCategoriesByPrimaryCategoryId(primaryCategoryId);

            //Assert
            Assert.NotNull(result);
            Assert.IsType<List<SubCategory>>(result);
            Assert.Contains(result, p => p.SubCategoryName.Contains("Unisex"));
        }

    }
}
