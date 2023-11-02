using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "PrimaryCategories",
                columns: table => new
                {
                    PrimaryCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimaryCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryCategories", x => x.PrimaryCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ProductInventories",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    LastInventory = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInventories", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    PromotionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountRate = table.Column<double>(type: "float", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.PromotionId);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    SizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.SizeId);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategoryId);
                    table.ForeignKey(
                        name: "FK_SubCategories_PrimaryCategories_PrimaryCategoryId",
                        column: x => x.PrimaryCategoryId,
                        principalTable: "PrimaryCategories",
                        principalColumn: "PrimaryCategoryId");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<double>(type: "float", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: true),
                    SizeId = table.Column<int>(type: "int", nullable: true),
                    PromotionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "ColorId");
                    table.ForeignKey(
                        name: "FK_Products_ProductInventories_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductInventories",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Promotions_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Promotions",
                        principalColumn: "PromotionId");
                    table.ForeignKey(
                        name: "FK_Products_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "SizeId");
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "SubCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorId", "Color" },
                values: new object[,]
                {
                    { 1, "Red" },
                    { 2, "Blue" },
                    { 3, "Green" },
                    { 4, "Yellow" },
                    { 5, "White" },
                    { 6, "Black" }
                });

            migrationBuilder.InsertData(
                table: "PrimaryCategories",
                columns: new[] { "PrimaryCategoryId", "PrimaryCategoryName" },
                values: new object[,]
                {
                    { 1, "Men" },
                    { 2, "Women" },
                    { 3, "Unisex" }
                });

            migrationBuilder.InsertData(
                table: "ProductInventories",
                columns: new[] { "ProductId", "LastInventory", "Quantity" },
                values: new object[,]
                {
                    { new Guid("00b5068e-3720-4923-aec1-18b4a5785cd2"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6417), 73 },
                    { new Guid("020df910-b5b6-48a2-9b63-906b510c680b"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6368), 53 },
                    { new Guid("021fda70-f179-4eef-92f2-9c0ac96d379e"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6428), 26 },
                    { new Guid("035f142b-7c49-4f40-9427-ecdd51759bbb"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6381), 66 },
                    { new Guid("08da6310-7872-44d7-bcd7-9aa835a1d0b0"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6376), 94 },
                    { new Guid("09a2eb56-c887-4725-80eb-8ec1e2684b79"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6585), 28 },
                    { new Guid("09a7e040-1205-468b-9cac-3496e0d348aa"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6296), 20 },
                    { new Guid("0a3e0e49-d8f4-43f9-9039-faed1c9edcc2"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6554), 68 },
                    { new Guid("0a8f8650-9c65-4d2e-9f68-8915625679af"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6444), 38 },
                    { new Guid("0beb8353-e1db-4bae-b491-b09388744b7f"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6336), 36 },
                    { new Guid("0c9ac2c7-a3e2-44d0-aab8-34fb51e57917"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6362), 83 },
                    { new Guid("0fcc511e-40f5-49dc-918e-2d06c96f75e6"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6415), 31 },
                    { new Guid("12fb1ac5-cbc3-440c-8b86-1ddde07b1858"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6514), 79 },
                    { new Guid("139db1fb-805c-4b7b-a1a1-afc758dd7163"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6421), 84 },
                    { new Guid("1799e8d4-6bb3-4466-93f7-aaa99556e973"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6348), 58 },
                    { new Guid("18257a4a-9e0b-4a07-9b34-28c1f45d54f6"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6370), 26 },
                    { new Guid("1a044451-f610-4fa0-8186-f3bf0f9dae73"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6471), 99 },
                    { new Guid("1b36b647-770b-4e27-b300-def0d3f39ea0"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6500), 73 },
                    { new Guid("1c803110-2a15-4236-9a1d-b2c62cd7968a"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6455), 81 },
                    { new Guid("1d1e2fe9-368e-4ad4-8f4b-7047a1b22f40"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6346), 93 },
                    { new Guid("1d5ce34e-2165-46ff-a6c2-468e337dec42"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6393), 62 },
                    { new Guid("22994067-d42f-4397-8402-b2d85f590942"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6495), 42 },
                    { new Guid("2307d6a3-3d1a-4d32-95b0-56878adfe7e7"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6512), 79 },
                    { new Guid("2441a5b2-5be5-4a93-946e-1b8d74b12415"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6434), 78 },
                    { new Guid("24ceb19b-bb80-4618-a4da-7fed72484f85"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6504), 33 },
                    { new Guid("25e393a8-c170-4ecc-8581-9585fb03f7bc"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6217), 89 },
                    { new Guid("27255093-23e3-45c9-a584-896f3dc634dd"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6581), 61 },
                    { new Guid("27cfeeb4-0082-4a23-a013-8a9c8038adc8"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6485), 33 },
                    { new Guid("28db1565-544f-47d2-95a8-6ca898832c3b"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6568), 41 },
                    { new Guid("29013894-97f9-4b61-a368-6f7c8de79d0d"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6335), 52 },
                    { new Guid("2ffcba91-e432-421f-bba0-7956d20be655"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6461), 95 },
                    { new Guid("303471fa-9d6a-4f6e-8d5c-65bbdc12dfdc"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6340), 57 },
                    { new Guid("31aba41b-6b64-40cd-b799-16f5a5c02a08"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6405), 25 },
                    { new Guid("357f3f83-e2b6-4e27-9dac-f13bc97744de"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6559), 60 },
                    { new Guid("361cc4d9-4f33-4a0e-baef-6e06df633607"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6484), 69 },
                    { new Guid("37d7b18b-dc7a-4263-a328-992fd476af59"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6361), 39 },
                    { new Guid("37e6e8ea-e16f-41b9-9209-b73b26702290"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6489), 46 },
                    { new Guid("3bc1f3e3-eb5e-4fe4-b356-4d807e1dad53"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6521), 43 },
                    { new Guid("40b7fee5-1723-4b8c-aad0-9eb67934e4f7"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6380), 67 },
                    { new Guid("4535473c-f997-4b61-a36a-b28c9eab30a8"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6424), 97 },
                    { new Guid("45f01e2a-925e-4a6d-a62a-2ef8a17935ee"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6590), 23 },
                    { new Guid("4b14cf35-41aa-48d4-95dd-4d7a66494f52"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6437), 88 },
                    { new Guid("4b519506-f925-45e5-9dde-d1d38b3f25df"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6342), 57 },
                    { new Guid("4bfc6305-0ae5-42d0-b76c-46c80fd7b344"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6447), 87 },
                    { new Guid("4ce5a009-4574-4966-964b-5f0e07d57161"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6292), 27 },
                    { new Guid("4d01b38b-31a5-4137-a138-73d92142729c"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6404), 86 },
                    { new Guid("4e9f08c4-111d-4c16-91f4-ddcd2ec35bbb"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6441), 83 },
                    { new Guid("501f1be5-7653-48b0-8ae6-3f3da2775698"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6499), 43 },
                    { new Guid("5070d174-c632-4c8d-8e74-6b3f89f7d112"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6476), 56 },
                    { new Guid("51bc0ce4-6f78-4bc8-9a32-e8692d117d25"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6345), 58 },
                    { new Guid("54b23357-3642-4906-90c2-dbba8c683da6"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6396), 47 },
                    { new Guid("54e97d76-82c2-4c4d-b818-23a9418c9f00"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6452), 60 },
                    { new Guid("57d3b9a4-2842-436e-aca8-90c0c1c03659"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6354), 90 },
                    { new Guid("5a937347-de31-44e0-9026-933f2c9ea2ef"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6467), 67 },
                    { new Guid("5b7bbd41-da26-4c6b-98ea-735e859fcbb0"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6556), 78 },
                    { new Guid("5b8b3ca2-1eb9-4e66-a5bf-e58165ed3e50"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6439), 42 },
                    { new Guid("62e5fb89-22d9-4182-b5a0-c5a9d127a72f"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6402), 30 },
                    { new Guid("649b00d1-5e31-445e-8a6a-163594233348"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6364), 27 },
                    { new Guid("65858241-09b9-4739-bef6-6bc2e809dea0"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6374), 77 },
                    { new Guid("6731590c-3c6c-41fc-8ac8-2c3eea1a4756"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6423), 78 },
                    { new Guid("6b6a04ef-232f-49a2-afab-6f6d498457f6"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6282), 89 },
                    { new Guid("6be712ec-13b9-4f6c-9e6a-3f7f1693be4b"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6567), 25 },
                    { new Guid("6d0febdd-d522-4e65-a467-be1961634324"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6372), 32 },
                    { new Guid("6d4d659f-2cb7-488b-a021-396c10cf6525"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6338), 72 },
                    { new Guid("71d02733-fcd2-44f2-b7b2-72c4e2080ff3"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6329), 69 },
                    { new Guid("72a67224-3fdf-4d5b-86e1-31ba5c081ba6"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6454), 30 },
                    { new Guid("73021975-117c-44fd-ab69-bf0c39959089"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6285), 33 },
                    { new Guid("79ce3b8d-de56-4183-a55b-8658ede4fe26"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6445), 36 },
                    { new Guid("7c8fc23e-4ffe-420e-a583-a8f15226d173"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6287), 57 },
                    { new Guid("7c97f6f0-3950-4c52-830b-e226741d7db1"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6502), 65 },
                    { new Guid("7cdc4992-2b63-4dc0-af7a-022e42f9d9c0"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6391), 87 },
                    { new Guid("7d119c75-91fc-41ed-a6c1-778b817afaa2"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6298), 93 },
                    { new Guid("7d524561-bfae-49bf-8c62-baac6ae93cd4"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6557), 22 },
                    { new Guid("837f2e54-e5ea-4bff-9135-147b53e32ac2"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6466), 21 },
                    { new Guid("86c57405-589e-4060-9ae6-4930d880f3e2"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6462), 56 },
                    { new Guid("898522c0-2979-4c73-b24f-ede6a462dd98"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6550), 33 },
                    { new Guid("8a4b24e2-4f47-4257-b1c8-c4b7da53cb57"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6583), 80 },
                    { new Guid("8d2f31fe-9fb2-4d90-8487-6e3f1b15f118"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6432), 50 },
                    { new Guid("9065ebf7-7770-4a40-82b7-d7a919a2c938"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6357), 22 },
                    { new Guid("91d9cfe5-0a4a-4f7e-be72-d5569a0d0ba0"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6580), 57 },
                    { new Guid("9387c92d-365f-4b0b-84b0-f0f64257a39e"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6578), 41 },
                    { new Guid("9492a32a-437d-4ce9-bf85-b551542d0e6a"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6575), 20 },
                    { new Guid("94c30f1d-2d2a-4408-a985-12917b9d6fe3"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6414), 21 },
                    { new Guid("96a5cf03-6994-4bb0-a45c-77d7764e0a48"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6410), 73 },
                    { new Guid("9ab91532-1aa2-40e4-9f2e-067f88654c7f"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6359), 97 },
                    { new Guid("9b10735a-57d7-4e20-a30c-4d015ec24228"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6570), 21 },
                    { new Guid("9b437761-ab4a-434b-8f51-b3101ba87105"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6386), 59 },
                    { new Guid("9e05e5cc-1182-421b-a4b8-bd9562e01f2a"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6333), 81 },
                    { new Guid("9f60ec70-a732-4960-805b-c37f9a019c02"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6577), 63 },
                    { new Guid("9fcde278-ed43-4d12-935f-f46924844599"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6509), 24 },
                    { new Guid("a11fa9b4-31d6-4cb2-919a-12b04e5c0cf1"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6505), 85 },
                    { new Guid("a415dd05-faaa-4cbe-be8b-c1274f2f7327"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6442), 39 },
                    { new Guid("a7249eff-d5f4-46b0-8317-99142761efae"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6459), 57 },
                    { new Guid("a76b27d7-e2c1-4642-903c-97f0bf645a62"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6482), 21 },
                    { new Guid("a798a35d-07d6-4165-9717-ee14006adf73"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6419), 36 },
                    { new Guid("a82587ea-26e8-46e5-a7fc-de496d0e96d1"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6400), 25 },
                    { new Guid("a864a153-e552-4eef-86f8-6f424d75eb3a"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6294), 58 },
                    { new Guid("a93042cb-973b-42ea-b49b-cc03578235f7"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6409), 54 },
                    { new Guid("a9dcb6ba-0fb5-4926-8b19-458a515720f8"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6366), 21 },
                    { new Guid("abe32add-b546-4269-8597-69e755b145de"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6395), 68 },
                    { new Guid("adcad6e1-f569-49d0-80f5-c983917c1aef"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6383), 32 },
                    { new Guid("af45ee20-5571-4396-8505-0fe30703a6b7"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6451), 21 },
                    { new Guid("b01eab87-994d-4a17-8c10-d352ce582746"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6426), 79 },
                    { new Guid("b24c36b7-afff-49b3-8a32-024a556ec6f2"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6412), 49 },
                    { new Guid("b3eb5dbf-ad17-4dd8-996b-ea71df591b0b"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6573), 25 },
                    { new Guid("b5039594-aec7-4733-8a35-bdbf2e66ead6"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6479), 60 },
                    { new Guid("b8bdf01e-0380-4b69-b2b4-6da5452fcfbf"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6388), 53 },
                    { new Guid("b8d63018-5737-4832-aa3b-e73c79c6c44b"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6572), 46 },
                    { new Guid("b9393f4a-29d3-4b31-b5a1-de904c996953"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6564), 21 },
                    { new Guid("ba1a5ec3-6c5d-4295-97f4-feb1937fe43e"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6497), 30 },
                    { new Guid("bbb946df-3daa-446e-8f4e-51274ad27a62"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6464), 73 },
                    { new Guid("bca8af9c-69bb-4f8d-98af-1b97e945464d"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6350), 78 },
                    { new Guid("bdcf62ce-11bc-456b-b1db-879f4f395ff5"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6407), 48 },
                    { new Guid("c0037902-5483-49aa-a364-5f02217ccc69"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6587), 81 },
                    { new Guid("c1fff8da-706c-4440-86f1-ce5925c9b097"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6385), 83 },
                    { new Guid("c24b0108-9905-48c4-a3e7-f2bd2446126d"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6430), 22 },
                    { new Guid("c9d056ea-e564-42f9-b4f2-cd8822515ebb"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6378), 61 },
                    { new Guid("ca8bff7e-c742-4736-8d93-75d889e37d7d"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6507), 42 },
                    { new Guid("cc124937-02ff-4fea-82bd-e25fb30cb866"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6477), 66 },
                    { new Guid("d10c664c-4f77-4f1c-a75c-559fd9bc6940"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6435), 22 },
                    { new Guid("d61da5a6-16bc-4b1b-9550-3e6d3dbe5ff3"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6474), 42 },
                    { new Guid("d8564eb5-0241-449d-a223-927df12542f2"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6511), 55 },
                    { new Guid("db6b33ea-7d31-4992-8e52-5eaf074a281b"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6490), 67 },
                    { new Guid("dc489db7-67ef-44df-8820-5702864099ab"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6355), 94 },
                    { new Guid("dcd77f7d-384b-451b-aefd-df6cc215aa06"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6457), 78 },
                    { new Guid("df7a1764-8ea2-42f9-9018-24820785ffa2"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6390), 53 },
                    { new Guid("e22c77b7-3cec-42b5-a178-d747caa11ecf"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6289), 79 },
                    { new Guid("e456dd96-8bbc-41a5-a5cb-c94bf57f6ccc"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6562), 95 },
                    { new Guid("e64ae761-d931-43b6-9b67-fc672bb26ace"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6449), 77 },
                    { new Guid("e75b5bcc-93f6-404e-99f2-75093ef45a4e"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6469), 47 },
                    { new Guid("ea190833-11d8-4fb6-9279-f8a1aae47915"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6331), 62 },
                    { new Guid("ea74fa73-fff2-4df9-98f5-718f3ecc2500"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6480), 62 },
                    { new Guid("ed696137-0e9d-4caf-8242-0857caf2db06"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6472), 82 },
                    { new Guid("ef609052-bc52-4351-85ff-8e1629359eeb"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6552), 61 },
                    { new Guid("f098d261-4900-466a-82e8-9c7edb385cd6"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6487), 48 },
                    { new Guid("f10c8605-1b62-4d87-8889-7a49c3654812"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6494), 99 },
                    { new Guid("f17a8994-ea4e-41c5-b518-49601e6f4508"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6516), 71 },
                    { new Guid("f3538bbb-1dd6-425b-a1f3-ce1a42cb4095"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6492), 62 },
                    { new Guid("f55792dc-2890-49aa-a88f-ae333c029db7"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6519), 61 },
                    { new Guid("f612349b-3965-4689-9307-e66d13613b01"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6561), 62 },
                    { new Guid("f70e9032-b853-4408-a533-18583d7f24c3"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6352), 29 },
                    { new Guid("fd59a822-c91c-422e-a450-7b7922863b88"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6589), 31 },
                    { new Guid("fe3b5150-1152-43c6-a344-717dcd554681"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6398), 43 },
                    { new Guid("ff6def3a-0823-42e2-b7f0-a664b9201f06"), new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6518), 56 }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "PromotionId", "Description", "DiscountRate", "EndDate", "Name", "StartDate" },
                values: new object[] { 1, "Manero's best sale yet!", 0.10000000000000001, new DateTime(2023, 12, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6657), "Autumn Sale", new DateTime(2023, 11, 2, 11, 26, 32, 678, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeId", "Size" },
                values: new object[,]
                {
                    { 1, "XS" },
                    { 2, "S" },
                    { 3, "M" },
                    { 4, "L" },
                    { 5, "XL" },
                    { 6, "XXL" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "SubCategoryId", "PrimaryCategoryId", "SubCategoryName" },
                values: new object[,]
                {
                    { 1, 1, "T-Shirts Men" },
                    { 2, 2, "T-Shirts Women" },
                    { 3, 3, "T-Shirts Unisex" },
                    { 4, 1, "Pants Men" },
                    { 5, 2, "Pants Women" },
                    { 6, 3, "Pants Unisex" },
                    { 7, 2, "Dresses" },
                    { 8, 1, "Shoes Men" },
                    { 9, 2, "Shoes Women" },
                    { 10, 3, "Shoes Unisex" },
                    { 11, 1, "Bags Men" },
                    { 12, 2, "Bags Women" },
                    { 13, 3, "Bags Unisex" },
                    { 14, 1, "Suits" },
                    { 15, 1, "Accessories Men" },
                    { 16, 2, "Accessories Women" },
                    { 17, 3, "Accessories Unisex" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ColorId", "ProductDescription", "ProductName", "ProductPrice", "PromotionId", "Quantity", "Rating", "SizeId", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("09a2eb56-c887-4725-80eb-8ec1e2684b79"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 173.0, 1, null, 4, 3, 14 },
                    { new Guid("0a3e0e49-d8f4-43f9-9039-faed1c9edcc2"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 915.0, 1, null, 1, 3, 14 },
                    { new Guid("0a8f8650-9c65-4d2e-9f68-8915625679af"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 938.0, 1, null, 0, 2, 5 },
                    { new Guid("12fb1ac5-cbc3-440c-8b86-1ddde07b1858"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 644.0, 1, null, 3, 2, 14 },
                    { new Guid("1a044451-f610-4fa0-8186-f3bf0f9dae73"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 339.0, 1, null, 3, 6, 5 },
                    { new Guid("1b36b647-770b-4e27-b300-def0d3f39ea0"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 470.0, 1, null, 0, 6, 5 },
                    { new Guid("1c803110-2a15-4236-9a1d-b2c62cd7968a"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 101.0, 1, null, 1, 3, 5 },
                    { new Guid("22994067-d42f-4397-8402-b2d85f590942"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 905.0, 1, null, 4, 3, 5 },
                    { new Guid("2307d6a3-3d1a-4d32-95b0-56878adfe7e7"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 461.0, 1, null, 2, 1, 14 },
                    { new Guid("24ceb19b-bb80-4618-a4da-7fed72484f85"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 542.0, 1, null, 2, 2, 14 },
                    { new Guid("27255093-23e3-45c9-a584-896f3dc634dd"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 935.0, 1, null, 4, 1, 14 },
                    { new Guid("27cfeeb4-0082-4a23-a013-8a9c8038adc8"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 653.0, 1, null, 2, 3, 5 },
                    { new Guid("28db1565-544f-47d2-95a8-6ca898832c3b"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 829.0, 1, null, 3, 5, 14 },
                    { new Guid("2ffcba91-e432-421f-bba0-7956d20be655"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 669.0, 1, null, 3, 6, 5 },
                    { new Guid("357f3f83-e2b6-4e27-9dac-f13bc97744de"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 686.0, 1, null, 2, 6, 14 },
                    { new Guid("361cc4d9-4f33-4a0e-baef-6e06df633607"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 536.0, 1, null, 2, 2, 5 },
                    { new Guid("37e6e8ea-e16f-41b9-9209-b73b26702290"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 888.0, 1, null, 4, 5, 5 },
                    { new Guid("3bc1f3e3-eb5e-4fe4-b356-4d807e1dad53"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 59.0, 1, null, 4, 6, 14 },
                    { new Guid("45f01e2a-925e-4a6d-a62a-2ef8a17935ee"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 563.0, 1, null, 1, 6, 14 },
                    { new Guid("4bfc6305-0ae5-42d0-b76c-46c80fd7b344"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 349.0, 1, null, 3, 4, 5 },
                    { new Guid("501f1be5-7653-48b0-8ae6-3f3da2775698"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 793.0, 1, null, 0, 5, 5 },
                    { new Guid("5070d174-c632-4c8d-8e74-6b3f89f7d112"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 270.0, 1, null, 1, 3, 5 },
                    { new Guid("54e97d76-82c2-4c4d-b818-23a9418c9f00"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 126.0, 1, null, 0, 1, 5 },
                    { new Guid("5a937347-de31-44e0-9026-933f2c9ea2ef"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 132.0, 1, null, 4, 4, 5 },
                    { new Guid("5b7bbd41-da26-4c6b-98ea-735e859fcbb0"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 973.0, 1, null, 1, 4, 14 },
                    { new Guid("6be712ec-13b9-4f6c-9e6a-3f7f1693be4b"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 216.0, 1, null, 2, 4, 14 },
                    { new Guid("72a67224-3fdf-4d5b-86e1-31ba5c081ba6"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 804.0, 1, null, 4, 2, 5 },
                    { new Guid("79ce3b8d-de56-4183-a55b-8658ede4fe26"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 342.0, 1, null, 0, 3, 5 },
                    { new Guid("7c97f6f0-3950-4c52-830b-e226741d7db1"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 804.0, 1, null, 1, 1, 14 },
                    { new Guid("7d524561-bfae-49bf-8c62-baac6ae93cd4"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 297.0, 1, null, 1, 5, 14 },
                    { new Guid("837f2e54-e5ea-4bff-9135-147b53e32ac2"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 511.0, 1, null, 1, 3, 5 },
                    { new Guid("86c57405-589e-4060-9ae6-4930d880f3e2"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 913.0, 1, null, 4, 1, 5 },
                    { new Guid("898522c0-2979-4c73-b24f-ede6a462dd98"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 171.0, 1, null, 2, 1, 14 },
                    { new Guid("8a4b24e2-4f47-4257-b1c8-c4b7da53cb57"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 456.0, 1, null, 0, 2, 14 },
                    { new Guid("91d9cfe5-0a4a-4f7e-be72-d5569a0d0ba0"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 314.0, 1, null, 2, 6, 14 },
                    { new Guid("9387c92d-365f-4b0b-84b0-f0f64257a39e"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 444.0, 1, null, 3, 5, 14 },
                    { new Guid("9492a32a-437d-4ce9-bf85-b551542d0e6a"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 281.0, 1, null, 2, 3, 14 },
                    { new Guid("9b10735a-57d7-4e20-a30c-4d015ec24228"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 971.0, 1, null, 4, 6, 14 },
                    { new Guid("9f60ec70-a732-4960-805b-c37f9a019c02"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 436.0, 1, null, 3, 4, 14 },
                    { new Guid("9fcde278-ed43-4d12-935f-f46924844599"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 450.0, 1, null, 1, 5, 14 },
                    { new Guid("a11fa9b4-31d6-4cb2-919a-12b04e5c0cf1"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 503.0, 1, null, 0, 3, 14 },
                    { new Guid("a415dd05-faaa-4cbe-be8b-c1274f2f7327"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 827.0, 1, null, 4, 1, 5 },
                    { new Guid("a7249eff-d5f4-46b0-8317-99142761efae"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 710.0, 1, null, 0, 5, 5 },
                    { new Guid("a76b27d7-e2c1-4642-903c-97f0bf645a62"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 840.0, 1, null, 1, 1, 5 },
                    { new Guid("af45ee20-5571-4396-8505-0fe30703a6b7"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 361.0, 1, null, 0, 6, 5 },
                    { new Guid("b3eb5dbf-ad17-4dd8-996b-ea71df591b0b"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 375.0, 1, null, 0, 2, 14 },
                    { new Guid("b5039594-aec7-4733-8a35-bdbf2e66ead6"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 961.0, 1, null, 0, 5, 5 },
                    { new Guid("b8d63018-5737-4832-aa3b-e73c79c6c44b"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 917.0, 1, null, 4, 1, 14 },
                    { new Guid("b9393f4a-29d3-4b31-b5a1-de904c996953"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 826.0, 1, null, 4, 3, 14 },
                    { new Guid("ba1a5ec3-6c5d-4295-97f4-feb1937fe43e"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 204.0, 1, null, 4, 4, 5 },
                    { new Guid("bbb946df-3daa-446e-8f4e-51274ad27a62"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 380.0, 1, null, 3, 2, 5 },
                    { new Guid("c0037902-5483-49aa-a364-5f02217ccc69"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 290.0, 1, null, 3, 4, 14 },
                    { new Guid("ca8bff7e-c742-4736-8d93-75d889e37d7d"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 647.0, 1, null, 1, 4, 14 },
                    { new Guid("cc124937-02ff-4fea-82bd-e25fb30cb866"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 621.0, 1, null, 0, 4, 5 },
                    { new Guid("d61da5a6-16bc-4b1b-9550-3e6d3dbe5ff3"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 608.0, 1, null, 2, 2, 5 },
                    { new Guid("d8564eb5-0241-449d-a223-927df12542f2"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 151.0, 1, null, 3, 6, 14 },
                    { new Guid("db6b33ea-7d31-4992-8e52-5eaf074a281b"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 697.0, 1, null, 3, 6, 5 },
                    { new Guid("dcd77f7d-384b-451b-aefd-df6cc215aa06"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 123.0, 1, null, 4, 4, 5 },
                    { new Guid("e456dd96-8bbc-41a5-a5cb-c94bf57f6ccc"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 303.0, 1, null, 3, 2, 14 },
                    { new Guid("e64ae761-d931-43b6-9b67-fc672bb26ace"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 107.0, 1, null, 2, 5, 5 },
                    { new Guid("e75b5bcc-93f6-404e-99f2-75093ef45a4e"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 395.0, 1, null, 2, 5, 5 },
                    { new Guid("ea74fa73-fff2-4df9-98f5-718f3ecc2500"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 71.0, 1, null, 4, 6, 5 },
                    { new Guid("ed696137-0e9d-4caf-8242-0857caf2db06"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 806.0, 1, null, 0, 1, 5 },
                    { new Guid("ef609052-bc52-4351-85ff-8e1629359eeb"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 244.0, 1, null, 1, 2, 14 },
                    { new Guid("f098d261-4900-466a-82e8-9c7edb385cd6"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 937.0, 1, null, 1, 4, 5 },
                    { new Guid("f10c8605-1b62-4d87-8889-7a49c3654812"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 634.0, 1, null, 0, 2, 5 },
                    { new Guid("f17a8994-ea4e-41c5-b518-49601e6f4508"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 862.0, 1, null, 2, 3, 14 },
                    { new Guid("f3538bbb-1dd6-425b-a1f3-ce1a42cb4095"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 405.0, 1, null, 0, 1, 5 },
                    { new Guid("f55792dc-2890-49aa-a88f-ae333c029db7"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 950.0, 1, null, 1, 5, 14 },
                    { new Guid("f612349b-3965-4689-9307-e66d13613b01"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 430.0, 1, null, 0, 1, 14 },
                    { new Guid("fd59a822-c91c-422e-a450-7b7922863b88"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 578.0, 1, null, 3, 5, 14 },
                    { new Guid("ff6def3a-0823-42e2-b7f0-a664b9201f06"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 518.0, 1, null, 3, 4, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColorId",
                table: "Products",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PromotionId",
                table: "Products",
                column: "PromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeId",
                table: "Products",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_PrimaryCategoryId",
                table: "SubCategories",
                column: "PrimaryCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "ProductInventories");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "PrimaryCategories");
        }
    }
}
