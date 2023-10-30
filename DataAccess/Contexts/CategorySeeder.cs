using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
    internal class CategorySeeder
    {
        private static string[] PrimaryCategories = new string[] { "Men", "Women", "Unisex" };

        private static string[] SubCategories = new string[]
        {
            "T-Shirts Men", "T-Shirts Women", "T-Shirts Unisex",
            "Pants Men", "Pants Women", "Pants Unisex","Dresses",
            "Shoes Men", "Shoes Women", "Shoes Unisex",
            "Bags Men", "Bags Women", "Bags Unisex","Suits",
            "Accessories Men", "Accessories Women", "Accessories Unisex"
        };

        private static readonly Random random = new Random();

        internal static IEnumerable<PrimaryCategoryEntity> SeedPrimaryCategories()
        {
            var primaryCategories = new List<PrimaryCategoryEntity>();
            for (int i = 0; i < PrimaryCategories.Length; i++)
            {
                PrimaryCategoryEntity entity = new PrimaryCategoryEntity()
                {
                    PrimaryCategoryId = i + 1,
                    PrimaryCategoryName = PrimaryCategories[i]
                };
                primaryCategories.Add(entity);
            }

            return primaryCategories;
        }

        internal static IEnumerable<SubCategoryEntity> SeedSubCategories()
        {
            var subCategories = new List<SubCategoryEntity>();
            for (int i = 0; i < SubCategories.Length; i++)
            {
                SubCategoryEntity entity = new SubCategoryEntity()
                {
                    SubCategoryId = i + 1,
                    SubCategoryName = SubCategories[i]
                };
                subCategories.Add(entity);
            }

            return subCategories;
        }


        internal static int GetPrimaryCategoryId(string clothingName)
        {
            switch (clothingName.ToLower())
            {
                case "suit":
                    return 1;
                case "suits":
                    return 1;
                case "dress":
                    return 2;
                case "dresses":
                    return 2;

            }

            return random.Next(1, 4);

        }


        internal static int GetSubCategoryId(string clothingName)
        {
            switch (clothingName.ToLower())
            {
                case "t-shirt":
                    return random.Next(1,4);
                case "t-shirts":
                    return random.Next(1, 4);
                case "pants":
                    return random.Next(4, 7);
                case "dress":
                    return 7;
                case "dresses":
                    return 7;
                case "shoes":
                    return random.Next(8, 11);
                case "bag":
                    return random.Next(11, 14);
                case "bags":
                    return random.Next(11, 14);
                case "suit":
                    return 14;
                case "suits":
                    return 14;
                case "accessories":
                    return random.Next(15, 18);
                default:
                    return 0;

            }
        }

        //internal static IEnumerable<PrimarySubCategoryEntity> SeedPrimarySubCategories()
        //{
        //    var primarySubCategories = new List<PrimarySubCategoryEntity>();
        //    for (int i = 0; i < SubCategories.Length; i++)
        //    {
        //        PrimarySubCategoryEntity entity;

        //        if (SubCategories[i].ToLower() == "suits")
        //        {
        //            entity = new PrimarySubCategoryEntity()
        //            {
        //                PrimaryCategoryId = 1,
        //                SubCategoryId = GetSubCategoryId(SubCategories[i])
        //            };

        //            primarySubCategories.Add(entity);

        //        }

        //        else if (SubCategories[i].ToLower() == "dresses")
        //        {
        //            entity = new PrimarySubCategoryEntity()
        //            {
        //                PrimaryCategoryId = 2,
        //                SubCategoryId = GetSubCategoryId(SubCategories[i])
        //            };

        //            primarySubCategories.Add(entity);

        //        }

        //        else
        //        {
        //            entity = new PrimarySubCategoryEntity()
        //            {
        //                PrimaryCategoryId = 1,
        //                SubCategoryId = GetSubCategoryId(SubCategories[i])
        //            };
        //            primarySubCategories.Add(entity);

        //            entity = new PrimarySubCategoryEntity()
        //            {
        //                PrimaryCategoryId = 2,
        //                SubCategoryId = GetSubCategoryId(SubCategories[i])
        //            };
        //            primarySubCategories.Add(entity);

        //            entity = new PrimarySubCategoryEntity()
        //            {
        //                PrimaryCategoryId = 3,
        //                SubCategoryId = GetSubCategoryId(SubCategories[i])
        //            };

        //            primarySubCategories.Add(entity);


        //        }



        //    }

        //    return primarySubCategories;

        //}


    }


}
