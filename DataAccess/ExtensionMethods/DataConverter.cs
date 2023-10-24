using DataAccess.Models.Entities;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ExtensionMethods
{
    public static class DataConverter
    {
        public static Product ConvertProductEntityToProduct(this ProductEntity p)
        {
            var product = new Product()
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                ProductDescription = p.ProductDescription,
                ProductPrice = p.ProductPrice,
                Rating = p.Rating ?? 0,
                Quantity = p.Quantity ?? 0

            };
            return product;
        }
    }
}
