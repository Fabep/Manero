using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Handlers.Services.Abstractions
{
    public interface IProductService
    {
        public Task<Dictionary<string, string>> GetProductColorAndSizeCombinationsAsync(string productName);
    }
}
