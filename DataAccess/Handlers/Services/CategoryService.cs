using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

			var categoriesList = await _subCategoryRepository.GetAllAsync(x => true);



			var primaryCategoriesList = categoriesList.Include(x=> x.PrimaryCategory).ToList();

			//var primaryrnd = primaryCategoriesList.FirstOrDefault().PrimaryCategory.PrimaryCategoryName;


			//return categoriesList.AsQueryable().Include(x=> x.PrimaryCategoryId)
			//	.Select(p => DataConverter.ConvertProductEntityToProduct(p))
			//	.ToList(); 

			return null;
		}

	}
}
