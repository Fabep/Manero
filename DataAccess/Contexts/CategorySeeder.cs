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
            { "T-Shirts", "Pants", "Dresses", "Shoes", "Bags", "Suits", "Accessories" };

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
                    return 1;
                case "t-shirts":
                    return 1;
                case "pants":
                    return 2;
                case "dress":
                    return 3;
                case "dresses":
                    return 3;
                case "shoes":
                    return 4;
                case "bag":
                    return 5;
                case "bags":
                    return 5;
                case "suit":
                    return 6;
                case "suits":
                    return 6;
                case "accessories":
                    return 7;
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
