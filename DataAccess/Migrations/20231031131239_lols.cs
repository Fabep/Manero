using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class lols : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("26cc1c21-6d0c-4228-ac4b-92be56feddee"));

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: new Guid("e02cec60-83b8-4990-a9e6-ff3b010f097f"));

            migrationBuilder.AddColumn<double>(
                name: "DiscountedPrice",
                table: "Products",
                type: "float",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "DiscountedPrice", "ProductDescription", "ProductName", "ProductPrice", "PromotionId", "Quantity", "Rating" },
                values: new object[,]
                {
                    { new Guid("1e950ef1-2592-4c7e-8a69-76e00f9cbeef"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Dress Green", 103.0, null, 99, 2 },
                    { new Guid("3f62d3d0-bb2f-49c1-8188-2510926c4c31"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Dress Blue", 930.0, null, 61, 2 },
                    { new Guid("41e7aac0-98d5-4249-a3a4-69cdf223395a"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Suit Blue", 892.0, null, 49, 4 },
                    { new Guid("44c02081-a41a-444e-9ff9-78e1e2e03e1f"), null, "Description", "Cool T-Shirt", 1000.0, null, 1, 5 },
                    { new Guid("5e3cbeb7-8338-4751-a81e-55384e1d81b0"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Pants Black", 594.0, null, 64, 2 },
                    { new Guid("6c160482-a2fa-4ef4-bf2f-26351e34b814"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "T-Shirt White", 738.0, null, 55, 0 },
                    { new Guid("7f433824-0c50-44c9-a035-e20874d2f5da"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Pants Black", 701.0, null, 57, 0 },
                    { new Guid("88af9726-85dc-4b73-b9ad-34db7c602a5a"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Suit White", 369.0, null, 32, 0 },
                    { new Guid("a429a8b7-2d45-4e9a-9c94-f0ea120971e7"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Suit Blue", 552.0, null, 53, 4 },
                    { new Guid("af2e8e44-42a2-496c-bdfd-781acf167792"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Dress Blue", 243.0, null, 54, 0 },
                    { new Guid("bec4228d-247c-444c-adc5-8382754ed451"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Pants Green", 539.0, null, 51, 0 },
                    { new Guid("c01279b1-01e6-443f-872c-3690434bec5a"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Pants Yellow", 489.0, null, 45, 0 },
                    { new Guid("c77753b8-bd16-4afb-9fd2-3de97787bdbe"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "T-Shirt Red", 151.0, null, 58, 2 },
                    { new Guid("d8c734a9-5c50-47ef-a43c-8e5b03686d08"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Suit Blue", 489.0, null, 83, 1 },
                    { new Guid("db8f691a-2673-4024-b870-da8528624e15"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Shoes Green", 620.0, null, 49, 2 },
                    { new Guid("ddc8d365-20fb-4304-bad3-94578c8b95af"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Bag Yellow", 355.0, null, 16, 3 },
                    { new Guid("e46116fd-5bc2-47f9-984b-3adf120ffa86"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "T-Shirt Black", 751.0, null, 30, 1 },
                    { new Guid("e7e30caa-6127-4ad2-ac75-cac285a8a960"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Dress Blue", 365.0, null, 68, 0 },
                    { new Guid("eb72981c-dace-4fb6-80e7-1502c20517ac"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Bag Green", 727.0, null, 60, 1 },
                    { new Guid("f186a42c-bd9e-48c8-ba16-2850ccb5663b"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Bag Yellow", 893.0, null, 86, 2 },
                    { new Guid("f79b69ed-bf9e-40cb-9944-4b67ea3ffd75"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Bag Yellow", 576.0, null, 24, 0 },
                    { new Guid("f9a7125a-4e6e-4bc4-87cb-1194af801ce5"), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Suit Green", 852.0, null, 0, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1e950ef1-2592-4c7e-8a69-76e00f9cbeef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3f62d3d0-bb2f-49c1-8188-2510926c4c31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("41e7aac0-98d5-4249-a3a4-69cdf223395a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("44c02081-a41a-444e-9ff9-78e1e2e03e1f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5e3cbeb7-8338-4751-a81e-55384e1d81b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6c160482-a2fa-4ef4-bf2f-26351e34b814"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7f433824-0c50-44c9-a035-e20874d2f5da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("88af9726-85dc-4b73-b9ad-34db7c602a5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a429a8b7-2d45-4e9a-9c94-f0ea120971e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("af2e8e44-42a2-496c-bdfd-781acf167792"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bec4228d-247c-444c-adc5-8382754ed451"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c01279b1-01e6-443f-872c-3690434bec5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c77753b8-bd16-4afb-9fd2-3de97787bdbe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d8c734a9-5c50-47ef-a43c-8e5b03686d08"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("db8f691a-2673-4024-b870-da8528624e15"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ddc8d365-20fb-4304-bad3-94578c8b95af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e46116fd-5bc2-47f9-984b-3adf120ffa86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e7e30caa-6127-4ad2-ac75-cac285a8a960"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("eb72981c-dace-4fb6-80e7-1502c20517ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f186a42c-bd9e-48c8-ba16-2850ccb5663b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f79b69ed-bf9e-40cb-9944-4b67ea3ffd75"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f9a7125a-4e6e-4bc4-87cb-1194af801ce5"));

            migrationBuilder.DropColumn(
                name: "DiscountedPrice",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "PromotionId", "Description", "DiscountRate", "EndDate", "Name", "StartDate" },
                values: new object[] { new Guid("e02cec60-83b8-4990-a9e6-ff3b010f097f"), "Big discounts for the summer season", 0.20000000000000001, new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Summer Sale", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductDescription", "ProductName", "ProductPrice", "PromotionId", "Quantity", "Rating" },
                values: new object[] { new Guid("26cc1c21-6d0c-4228-ac4b-92be56feddee"), "Beskrivning av exempelprodukten", "Exempelprodukt", 19.989999999999998, new Guid("e02cec60-83b8-4990-a9e6-ff3b010f097f"), null, null });
        }
    }
}
