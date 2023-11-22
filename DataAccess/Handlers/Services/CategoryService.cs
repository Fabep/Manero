using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Handlers.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly SubCategoryRepository _subCategoryRepository;

        public CategoryService(SubCategoryRepository subCategoryRepository)
        {
            _subCategoryRepository = subCategoryRepository;
        }

        public async Task<List<PrimaryCategory>> GetAllPrimaryCategories()
        {

            var categoriesList = _subCategoryRepository.GetAll(x => true);

            var primaryCategoriesList = categoriesList
                .Include(x => x.PrimaryCategory)
                .Select(x => DataConverter.ConvertPrimaryCategoryEntityToPrimaryCategory(x.PrimaryCategory!))
                .Distinct()
                .ToList();


            return primaryCategoriesList;
        }


        public async Task<List<SubCategory>> GetSubCategoriesByPrimaryCategoryId(int primaryCategoryId)
        {

            var categoriesList = _subCategoryRepository.GetAll(x => true);


            return categoriesList.Where(x => x.PrimaryCategoryId == primaryCategoryId)
                .Select(x => DataConverter.ConvertSubCategoryEntityToSubCategory(x))
                .ToList();
        }


    }
}