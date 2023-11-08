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
				ImageUrl = GetProductImage(p.SubCategoryId)
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

		public static PrimaryCategory ConvertPrimaryCategoryEntityToPrimaryCategory(this PrimaryCategoryEntity entity)
		{
			if (entity == null)
			{
				return null;
			}

			var primaryCategory = new PrimaryCategory()
			{
				PrimaryCategoryId = entity.PrimaryCategoryId,
				PrimaryCategoryName = entity.PrimaryCategoryName
			};

			return primaryCategory;

		}



		public static SubCategory ConvertSubCategoryEntityToSubCategory(this SubCategoryEntity entity)
		{
			if (entity == null)
			{
				return null;
			}

			var subCategory = new SubCategory()
			{
				SubCategoryId = entity.SubCategoryId,
				SubCategoryName = entity.SubCategoryName
			};

			return subCategory;

		}
		private static string GetProductImage(int? subCategoryId)
		{
			var url = string.Empty;
            url = subCategoryId switch
            {
                1 or 2 or 3 => "https://maneroimagestorage.blob.core.windows.net/images/t-shirt.png",
                4 or 5 or 6 => "https://maneroimagestorage.blob.core.windows.net/images/pants.png",
                7 => "https://maneroimagestorage.blob.core.windows.net/images/dress.png",
                8 or 9 or 10 => "https://maneroimagestorage.blob.core.windows.net/images/shoes.png",
                11 or 12 or 13 => "https://maneroimagestorage.blob.core.windows.net/images/bag.png",
                14 => "https://maneroimagestorage.blob.core.windows.net/images/suit.png",
                15 or 16 or 17 => "https://maneroimagestorage.blob.core.windows.net/images/accessory.png",
                _ => "https://maneroimagestorage.blob.core.windows.net/images/no-img.png",
            };
            return url;
		}
	}
}

