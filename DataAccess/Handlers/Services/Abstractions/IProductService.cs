using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Handlers.Services.Abstractions
{
    public interface IProductService
    {
        public Task<Dictionary<string, string>> GetProductColorsAndSizesAsync(string productName);

        public Task<Product> GetOneProductFromNameAsync(string productName);
    }
}
