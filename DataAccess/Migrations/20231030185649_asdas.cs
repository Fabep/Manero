using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class asdas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d13dd170-f8e8-422b-a338-f8f552db2290"));

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: new Guid("ee534c19-1650-4db5-8b92-e8225ee2ef16"));

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "PromotionId", "Description", "DiscountRate", "EndDate", "Name", "StartDate" },
                values: new object[] { new Guid("e02cec60-83b8-4990-a9e6-ff3b010f097f"), "Big discounts for the summer season", 0.20000000000000001, new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Summer Sale", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductDescription", "ProductName", "ProductPrice", "PromotionId", "Quantity", "Rating" },
                values: new object[] { new Guid("26cc1c21-6d0c-4228-ac4b-92be56feddee"), "Beskrivning av exempelprodukten", "Exempelprodukt", 19.989999999999998, new Guid("e02cec60-83b8-4990-a9e6-ff3b010f097f"), null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("26cc1c21-6d0c-4228-ac4b-92be56feddee"));

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: new Guid("e02cec60-83b8-4990-a9e6-ff3b010f097f"));

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "PromotionId", "Description", "DiscountRate", "EndDate", "Name", "StartDate" },
                values: new object[] { new Guid("ee534c19-1650-4db5-8b92-e8225ee2ef16"), "Big discounts for the summer season", 0.20000000000000001, new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Summer Sale", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductDescription", "ProductName", "ProductPrice", "PromotionId", "Quantity", "Rating" },
                values: new object[] { new Guid("d13dd170-f8e8-422b-a338-f8f552db2290"), "Beskrivning av exempelprodukten", "Exempelprodukt", 19.989999999999998, new Guid("ee534c19-1650-4db5-8b92-e8225ee2ef16"), null, null });
        }
    }
}
