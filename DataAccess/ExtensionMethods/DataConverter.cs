using DataAccess.Models.Entities;
using DataAccess.Models;
using DataAccess.Models.Schemas;
using System.Diagnostics;

namespace DataAccess.ExtensionMethods
{
    public static class DataConverter
    {
        public static Product ConvertProductEntityToProduct(this ProductEntity p)
        {
            try
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
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;
        }

        public static Promotion ConvertPromotionEntityToPromotion(this PromotionEntity promotionEntity)
        {
            try
            {
                if (promotionEntity == null)
                {
                    return null!; // Returnera null om ingen kampanj hittades
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
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;
        }

        public static ProductEntity ConvertProductSchemaToProductEntity(this ProductSchema p)
        {
            try
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
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;
        }

        public static PrimaryCategory ConvertPrimaryCategoryEntityToPrimaryCategory(this PrimaryCategoryEntity entity)
        {
            try
            {
                if (entity == null)
                {
                    return null!;
                }

                var primaryCategory = new PrimaryCategory()
                {
                    PrimaryCategoryId = entity.PrimaryCategoryId,
                    PrimaryCategoryName = entity.PrimaryCategoryName
                };
                return primaryCategory;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;
        }



        public static SubCategory ConvertSubCategoryEntityToSubCategory(this SubCategoryEntity entity)
        {
            try
            {
                if (entity == null)
                {
                    return null!;
                }

                var subCategory = new SubCategory()
                {
                    SubCategoryId = entity.SubCategoryId,
                    SubCategoryName = entity.SubCategoryName
                };

                return subCategory;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;
        }


        public static CustomerAddress ConvertCustomerAddressEntityToCustomerAddress(this CustomerAddressEntity entity)
        {
            try
            {
                return new CustomerAddress()
                {
                    StreetAddress = entity.StreetAddress,
                    Streetnumber = entity.Streetnumber,
                    City = entity.City,
                    PostalCode = entity.PostalCode,
                    Country = entity.Country,
                };
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;
        }

        public static AddressSchema ConvertCustomerAddressToShippingAddressSchema(this CustomerAddress address)
        {
            try
            {
                return new AddressSchema()
                {
                    StreetAddress = address.StreetAddress,
                    Streetnumber = address.Streetnumber,
                    City = address.City,
                    Country = address.Country,
                    PostalCode = address.PostalCode,
                    Region = address.Region,
                };
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;

        }

        private static string GetProductImage(int? subCategoryId)
        {
            try
            {
                var url = string.Empty;
                url = subCategoryId switch
                {
                    1 or 2 or 3 => "https://maneroimagestorage.blob.core.windows.net/images/t-shirt.png",
                    4 or 5 or 6 => "https://maneroimagestorage.blob.core.windows.net/images/pants.png",
                    7 => "https://maneroimagestorage.blob.core.windows.net/images/dress.png",
                    8 or 9 or 10 => "https://maneroimagestorage.blob.core.windows.net/images/shoe.png",
                    11 or 12 or 13 => "https://maneroimagestorage.blob.core.windows.net/images/bag.png",
                    14 => "https://maneroimagestorage.blob.core.windows.net/images/suit.png",
                    15 or 16 or 17 => "https://maneroimagestorage.blob.core.windows.net/images/accessory.png",
                    _ => "https://maneroimagestorage.blob.core.windows.net/images/no-img.png",
                };
                return url;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;
           
        }

        public static Order ConvertOrderEntityToOrder(this OrdersEntity orderEntity)
        {
            try
            {
                if (orderEntity == null)
                {
                    return null!;
                }

                var order = new Order()
                {
                    OrderId = orderEntity.OrderId,
                    CustomerId = orderEntity.CustomerId,
                    OrderDate = orderEntity.OrderDate,
                    PaymentMethod = new PaymentMethodEntity()
                    {
                        CardNumber = orderEntity.PaymentMethod.CardNumber,
                        PaymentId = orderEntity.PaymentMethod.PaymentId,
                    },
                    StatusId = orderEntity.StatusId,
                    Status = orderEntity.Status,
                    TotalAmount = orderEntity.TotalAmount,
                };
                return order;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;           
        }

        public static OrderItem ConvertOrderItemEntityToOrderItem(this OrderItemsEntity orderItemsEntity)
        {
            try
            {
                if (orderItemsEntity == null)
                {
                    return null!;
                }

                var order = new OrderItem()
                {
                    OrderItermsId = orderItemsEntity.OrderItemsId,
                    OrderId = orderItemsEntity.OrderId,
                    DiscountPrice = orderItemsEntity.DiscountPrice,
                    ProductId = orderItemsEntity.ProductId,
                    ProductName = orderItemsEntity.ProductName,
                    Quantity = orderItemsEntity.Quantity,
                    TotalAmount = orderItemsEntity.TotalAmount
                };
                return order;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;           
        }


        public static OrdersEntity ConvertOrderSchemaToOrderEntity(this OrderSchema orderSchema)
        {
            try
            {
                if (orderSchema == null)
                {
                    return null!;
                }
                var orderEntity = new OrdersEntity()
                {
                    CustomerId = orderSchema.CustomerId,
                    TotalAmount = orderSchema.TotalAmount,
                    OrderDate = DateTime.Now,
                    PaymentMethod = new PaymentMethodEntity()
                    {
                        CardNumber = orderSchema.PaymentMethod.CardNumber,
                    },
                };
                return orderEntity;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;
        }



        public static PromotionCode ConvertPromotionCodeEntityToPromotionCode(this PromotionCodeEntity promotionCodeEntity)
        {
            try
            {
                if (promotionCodeEntity == null)
                {
                    return null!;
                }

                var promotionCode = new PromotionCode()
                {
                    Name = promotionCodeEntity.Name,
                    Description = promotionCodeEntity.Description,
                    DiscountRate = promotionCodeEntity.DiscountRate,
                    StartDate = promotionCodeEntity.StartDate,
                    EndDate = promotionCodeEntity.EndDate,

                };
                return promotionCode;
            }           
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;
        }
    }
}
