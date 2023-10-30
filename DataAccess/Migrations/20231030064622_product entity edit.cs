using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class productentityedit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f6f76468-2183-411f-9fe1-e20b1245da22"));

            migrationBuilder.RenameColumn(
                name: "SubCategoryId",
                table: "SubCategory",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PrimaryCategoryId",
                table: "PrimaryCategory",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "PrimaryCategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "PrimaryCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Men");

            migrationBuilder.InsertData(
                table: "PrimaryCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Women" },
                    { 3, "Unisex" }
                });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "T-Shirts");

            migrationBuilder.InsertData(
                table: "SubCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Pants" },
                    { 3, "Dresses" },
                    { 4, "Shoes" },
                    { 5, "Bags" },
                    { 6, "Suits" },
                    { 7, "Accessories" }
                });

            migrationBuilder.InsertData(
                table: "PrimarySubCategory",
                columns: new[] { "PrimaryCategoryId", "SubCategoryId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 7 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 7 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "PrimaryCategoryId", "ProductDescription", "ProductName", "ProductPrice", "Quantity", "Rating", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("0daa7259-5687-4386-a084-89abb9606271"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Bag Red", 496.0, 17, 0, 5 },
                    { new Guid("0db079b0-5586-43a7-9219-69e12a88e46e"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Dress Blue", 693.0, 95, 1, 3 },
                    { new Guid("15f12228-fef6-4ed7-8441-502eebf2fdc7"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Suit White", 818.0, 9, 0, 6 },
                    { new Guid("17875954-9eb2-4e9e-8d22-d17f9bd1efd4"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Dress Yellow", 428.0, 0, 2, 3 },
                    { new Guid("2fd8d54f-4a97-4331-b5b2-d0b87b3b663a"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Shoes Red", 84.0, 79, 1, 4 },
                    { new Guid("325ebfc2-ef90-4feb-bbfe-e85ca76b30bb"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Pants Green", 258.0, 1, 0, 2 },
                    { new Guid("34b7a738-e48c-4677-aff8-3b0c5eeb5fb2"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Pants Green", 872.0, 32, 4, 2 },
                    { new Guid("362cdaa4-2803-4c32-99fe-451d7714093d"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Suit Blue", 248.0, 90, 4, 6 },
                    { new Guid("3e6c6d67-5e30-4965-93a3-712da506143c"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Shoes Black", 593.0, 44, 4, 4 },
                    { new Guid("418ac393-8591-4cad-b53e-1b4880521335"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Bag White", 443.0, 90, 0, 5 },
                    { new Guid("468a48da-2033-4c4a-adf4-6c0650c21a71"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Pants Green", 665.0, 72, 1, 2 },
                    { new Guid("51839267-0fa5-4ef1-bd1d-177fcaa25917"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Shoes Blue", 352.0, 37, 1, 4 },
                    { new Guid("6f35745c-8195-4fed-b7d8-0a0b8a7a59d5"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Pants Black", 428.0, 5, 2, 2 },
                    { new Guid("74d99315-fb8f-4d8d-aedc-475ad76414e8"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Shoes Yellow", 965.0, 69, 3, 4 },
                    { new Guid("794191c5-d56d-4b3c-95b2-b7c45bbc9452"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " T-Shirt Yellow", 419.0, 95, 1, 1 },
                    { new Guid("9e27eb80-db90-481c-a1b6-760b8ee1456c"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Suit Yellow", 128.0, 17, 3, 6 },
                    { new Guid("aae98eee-b2a0-4af8-8531-14afa388adda"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Pants Blue", 473.0, 23, 3, 2 },
                    { new Guid("d7de5cb2-f019-4133-89de-24b696f04932"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Dress White", 194.0, 4, 3, 3 },
                    { new Guid("da9fb991-b219-4f27-a66d-0632c328ad0c"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Pants Red", 490.0, 83, 2, 2 },
                    { new Guid("ebad6b11-a3f8-41a0-bb10-5f8ea0e24e67"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Shoes Black", 690.0, 6, 1, 4 },
                    { new Guid("fd7a01a8-f607-45e7-ab04-90ca7ba701a1"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", " Shoes Yellow", 245.0, 22, 0, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_PrimaryCategoryId",
                table: "Products",
                column: "PrimaryCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PrimaryCategory_PrimaryCategoryId",
                table: "Products",
                column: "PrimaryCategoryId",
                principalTable: "PrimaryCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_PrimaryCategory_PrimaryCategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_PrimaryCategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "PrimarySubCategory",
                keyColumns: new[] { "PrimaryCategoryId", "SubCategoryId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PrimarySubCategory",
                keyColumns: new[] { "PrimaryCategoryId", "SubCategoryId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "PrimarySubCategory",
                keyColumns: new[] { "PrimaryCategoryId", "SubCategoryId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "PrimarySubCategory",
                keyColumns: new[] { "PrimaryCategoryId", "SubCategoryId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "PrimarySubCategory",
                keyColumns: new[] { "PrimaryCategoryId", "SubCategoryId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "PrimarySubCategory",
                keyColumns: new[] { "PrimaryCategoryId", "SubCategoryId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PrimarySubCategory",
                keyColumns: new[] { "PrimaryCategoryId", "SubCategoryId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "PrimarySubCategory",
                keyColumns: new[] { "PrimaryCategoryId", "SubCategoryId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "PrimarySubCategory",
                keyColumns: new[] { "PrimaryCategoryId", "SubCategoryId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "PrimarySubCategory",
                keyColumns: new[] { "PrimaryCategoryId", "SubCategoryId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "PrimarySubCategory",
                keyColumns: new[] { "PrimaryCategoryId", "SubCategoryId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "PrimarySubCategory",
                keyColumns: new[] { "PrimaryCategoryId", "SubCategoryId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "PrimarySubCategory",
                keyColumns: new[] { "PrimaryCategoryId", "SubCategoryId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "PrimarySubCategory",
                keyColumns: new[] { "PrimaryCategoryId", "SubCategoryId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "PrimarySubCategory",
                keyColumns: new[] { "PrimaryCategoryId", "SubCategoryId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "PrimarySubCategory",
                keyColumns: new[] { "PrimaryCategoryId", "SubCategoryId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0daa7259-5687-4386-a084-89abb9606271"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0db079b0-5586-43a7-9219-69e12a88e46e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("15f12228-fef6-4ed7-8441-502eebf2fdc7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("17875954-9eb2-4e9e-8d22-d17f9bd1efd4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2fd8d54f-4a97-4331-b5b2-d0b87b3b663a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("325ebfc2-ef90-4feb-bbfe-e85ca76b30bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("34b7a738-e48c-4677-aff8-3b0c5eeb5fb2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("362cdaa4-2803-4c32-99fe-451d7714093d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3e6c6d67-5e30-4965-93a3-712da506143c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("418ac393-8591-4cad-b53e-1b4880521335"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("468a48da-2033-4c4a-adf4-6c0650c21a71"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("51839267-0fa5-4ef1-bd1d-177fcaa25917"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6f35745c-8195-4fed-b7d8-0a0b8a7a59d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("74d99315-fb8f-4d8d-aedc-475ad76414e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("794191c5-d56d-4b3c-95b2-b7c45bbc9452"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9e27eb80-db90-481c-a1b6-760b8ee1456c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("aae98eee-b2a0-4af8-8531-14afa388adda"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d7de5cb2-f019-4133-89de-24b696f04932"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("da9fb991-b219-4f27-a66d-0632c328ad0c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ebad6b11-a3f8-41a0-bb10-5f8ea0e24e67"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fd7a01a8-f607-45e7-ab04-90ca7ba701a1"));

            migrationBuilder.DeleteData(
                table: "PrimaryCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PrimaryCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "PrimaryCategoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SubCategory",
                newName: "SubCategoryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PrimaryCategory",
                newName: "PrimaryCategoryId");

            migrationBuilder.UpdateData(
                table: "PrimaryCategory",
                keyColumn: "PrimaryCategoryId",
                keyValue: 1,
                column: "Name",
                value: "Women");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductDescription", "ProductName", "ProductPrice", "Quantity", "Rating", "SubCategoryId" },
                values: new object[] { new Guid("f6f76468-2183-411f-9fe1-e20b1245da22"), "Description", "Fine dress", 1000.0, 1, 5, 1 });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "SubCategoryId",
                keyValue: 1,
                column: "Name",
                value: "Dress");
        }
    }
}
