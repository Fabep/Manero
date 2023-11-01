using DataAccess.Models.Entities;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models.Schemas;

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
				Quantity = p.Quantity ?? 0,
				DiscountedPrice = p.DiscountedPrice ?? 0
			};
			return product;
		}
		public static Promotion ConvertPromotionEntityToPromotion(this PromotionEntity promotionEntity)
		{
			if (promotionEntity == null)
			{
				return null; // Returnera null om ingen kampanj hittades
			}
			var promotion = new Promotion()
			{
				PromotionId = promotionEntity.PromotionId,
				Name = promotionEntity.Name,
				Description = promotionEntity.Description,
				DiscountRate = promotionEntity.DiscountRate,
				StartDate = promotionEntity.StartDate,
				EndDate = promotionEntity.EndDate
			};

			return promotion;
		}
        public static ProductEntity ConvertProductSchemaToProductEntity(this ProductSchema p)
        {
            var product = new ProductEntity()
            {
                ProductName = p.ProductName,
                ProductDescription = p.ProductDescription,
                ProductPrice = p.ProductPrice,
                ColorId = 1,
                SizeId = 1,
                SubCategoryId = 1,
            };
            var productInventory = new ProductInventoryEntity()
            {
                Quantity = p.Quantity ?? 0,
                LastInventory = DateTime.Now
            };
            product.ProductInventory = productInventory;
            return product;
        }
    }
}

