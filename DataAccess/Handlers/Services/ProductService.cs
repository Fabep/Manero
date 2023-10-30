using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Handlers.Services
{
    public class ProductService : IProductService
    {

        private readonly ProductRepository _productRepository;
        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> GetOneProductFromNameAsync(string productName)
        {
            return DataConverter.ConvertProductEntityToProduct(await _productRepository.GetAsync(x => x.ProductName == productName));
        }

        public async Task<Dictionary<string, string>> GetProductColorsAndSizesAsync(string productName) 
        {
            try
            {
                var combinations = new Dictionary<string, string>();

                var temp = await _productRepository.GetAllAsync(x => x.ProductName == productName);
                var products = temp.AsQueryable()
                    .Include(c => c.ColorEntity)
                    .Include(s => s.SizeEntity).ToList();
                
                foreach (var product in products)
                {
                    combinations.Add(product.Size.SizeName, product.Color.ColorName);
                }
                return combinations;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return null!;
        }
    }
}
