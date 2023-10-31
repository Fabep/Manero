using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initializedb : Migration
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
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductInventories_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductInventories",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "SizeId",
                        onDelete: ReferentialAction.Cascade);
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
                    { new Guid("0040b30e-13c0-4430-97b3-8d67968c7a12"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1118), 41 },
                    { new Guid("035b4542-12e7-4598-9273-f450f012e014"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1400), 58 },
                    { new Guid("035bbdfd-aa99-4ec4-92d5-72602e39da6a"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1287), 62 },
                    { new Guid("050ff641-554f-460d-a79b-f3d129a3b6af"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1098), 76 },
                    { new Guid("080c61ec-29fc-40d8-a17f-7891fba57db9"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1198), 71 },
                    { new Guid("09d307a9-9e34-467f-91d7-fc193831987f"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1162), 86 },
                    { new Guid("11059a16-794e-4206-ac51-24c1abdf90e9"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1082), 52 },
                    { new Guid("138db553-7830-4a20-b081-7bcda2dc41a0"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1228), 60 },
                    { new Guid("15320abb-b76d-4b21-9c10-50e2e3cd6721"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1079), 83 },
                    { new Guid("16f80014-2049-4556-abaf-6ebf989449b4"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1153), 79 },
                    { new Guid("1758468e-20cc-4823-bd98-9a614a85b2ee"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1332), 51 },
                    { new Guid("17c50add-42d5-48b8-bd9f-dff0ce0cb31d"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1343), 73 },
                    { new Guid("181e2024-2a13-44fa-b0c2-7f5258d415f6"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1091), 69 },
                    { new Guid("1876e8c0-896d-4025-afb6-611e72086131"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1280), 74 },
                    { new Guid("18881d33-a319-4c4e-97de-33c71afcdcc3"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1299), 27 },
                    { new Guid("1aa47020-1318-4fc1-9052-eaba4b13f162"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1293), 70 },
                    { new Guid("1ae6b54e-007e-4873-ad14-65d581ff3254"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1072), 73 },
                    { new Guid("1cd25e81-ca40-4cd4-8e68-3a35581b66c2"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1208), 23 },
                    { new Guid("1d44d193-086d-48f1-aa31-96abad9196e7"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1144), 22 },
                    { new Guid("1f7c605b-b994-4d4b-924d-438f08a1b402"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1122), 52 },
                    { new Guid("207daaa1-dc1e-4628-9c7e-84b801221c43"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1222), 59 },
                    { new Guid("21e01302-c3bd-4ab1-9ecf-5f28ff488de1"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1074), 32 },
                    { new Guid("235220fa-1a54-44a0-aa41-35d104ba865c"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1274), 39 },
                    { new Guid("25e645d6-b234-4d6c-8a8d-5cd30b2f7136"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1328), 83 },
                    { new Guid("28aaeb5a-4944-40cd-b0cc-b7bed3f66322"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1284), 73 },
                    { new Guid("2bca171c-cf56-402b-8e4b-11148dec9df9"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1178), 87 },
                    { new Guid("2c15a80f-d323-40ed-864b-37cf75633f21"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1096), 86 },
                    { new Guid("2c468f24-90a9-4c43-aa56-9a0d69d63cfe"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1111), 84 },
                    { new Guid("2cee388d-55e7-4684-85c1-52fa2fa64992"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1270), 31 },
                    { new Guid("30753f74-933b-425f-95c9-3ceb290ec5bb"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1157), 49 },
                    { new Guid("329b6698-6469-4348-a9c0-81f54663d15f"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1131), 59 },
                    { new Guid("343060b7-3f2f-45b7-866b-a469b7a9070e"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1187), 21 },
                    { new Guid("3463b40f-6fd8-4ba7-87d8-5c495d730d6e"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1272), 88 },
                    { new Guid("352835e7-5c80-4415-85c2-2c29b4eef924"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1337), 64 },
                    { new Guid("36056812-f3b1-4cef-9b04-8a451e9c822e"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1116), 98 },
                    { new Guid("3748b092-eb0d-469a-a7dc-55d2af5e8797"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1166), 30 },
                    { new Guid("3826dc7f-079a-4a88-adb2-fd41115e5281"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1104), 28 },
                    { new Guid("3986808f-3fb5-470f-b57a-830036e56c8d"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1310), 95 },
                    { new Guid("3c2940ac-876e-4570-ab8d-44ab926a509b"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1381), 77 },
                    { new Guid("400c21f6-1f79-4002-b68a-0a56759375ab"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1180), 85 },
                    { new Guid("43010c27-dcb4-4c27-91b5-7f4333fe45bc"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1305), 72 },
                    { new Guid("430bf486-122d-45be-ad77-98e5b327c796"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1364), 47 },
                    { new Guid("447481e6-de84-45aa-830d-8782e1e10920"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1345), 84 },
                    { new Guid("4671875e-b894-44bb-a40e-386724e96c1c"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1392), 94 },
                    { new Guid("49338d0a-de50-4221-97a3-b49b78adba85"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1314), 44 },
                    { new Guid("4b259df5-2fc7-4ed4-b0c5-46992a1f9c32"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1387), 26 },
                    { new Guid("4e86a840-07f7-46fc-b13d-19c80fa9b138"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1394), 44 },
                    { new Guid("4ea1e600-0584-4c5c-b5b2-83fe4ec5e38b"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1276), 62 },
                    { new Guid("4f352d46-5637-4e6a-9a4e-83a0d95ac012"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1128), 69 },
                    { new Guid("511318df-a073-4910-b63d-3a96fcab5aab"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1351), 72 },
                    { new Guid("550b2a59-d9e4-4fee-87d3-e30a866bfe6f"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1320), 45 },
                    { new Guid("566f35f6-6db4-4a1d-961b-3922af83b9d9"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1322), 50 },
                    { new Guid("5bad7b86-4726-4a5c-821e-9773e011a617"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1330), 87 },
                    { new Guid("6099ab4a-01d4-44dd-908f-7ada584d498b"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1385), 35 },
                    { new Guid("653e5e7a-46b3-4a22-95bc-b23ef4c26c1d"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1295), 35 },
                    { new Guid("662bdb8b-f37f-4f8b-b5fb-403d6897f5f6"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1266), 79 },
                    { new Guid("6df78482-352a-4252-84fd-775da2f6919e"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1139), 52 },
                    { new Guid("72fb771d-2909-447f-9104-67ffc61b611b"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1193), 44 },
                    { new Guid("7370cb33-a714-406c-98c2-eaa6af14b5a4"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1261), 42 },
                    { new Guid("73e92dab-4bc0-41ce-8103-12c06bcb6a5b"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1341), 80 },
                    { new Guid("74859212-def6-4b2c-b332-761e7d6e0348"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1135), 33 },
                    { new Guid("74f24226-60d3-4743-b7fc-a74c6bde13dd"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1147), 25 },
                    { new Guid("753c2861-0399-4788-9080-ffe292c3cb14"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1224), 61 },
                    { new Guid("7627068f-6f81-46d1-83dc-bf163984ffa9"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1268), 38 },
                    { new Guid("76364d86-9c97-4d20-8a45-34b2833a4cdf"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1160), 46 },
                    { new Guid("77e0f778-fb50-49df-a738-a65372436e75"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1084), 48 },
                    { new Guid("787ed7ae-210c-4a1e-8880-042b7cd68100"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1202), 82 },
                    { new Guid("78ce4f6f-6df2-415a-93ee-88333766e49c"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1259), 35 },
                    { new Guid("78db494a-61da-427a-8e9c-f2267f1c34dc"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1213), 21 },
                    { new Guid("7ba388f7-009b-41b0-b89c-86685bd5a17f"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1226), 20 },
                    { new Guid("7bbd3852-0d43-401c-af0a-77da4dde881c"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1185), 49 },
                    { new Guid("7c81a334-5710-496f-b981-26bc1c6d9433"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1088), 93 },
                    { new Guid("7d45fc52-2b6d-4f49-991e-723aa62b2626"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1396), 47 },
                    { new Guid("7df1695b-c2c5-41b7-8de3-49ffc3213c1b"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1289), 84 },
                    { new Guid("7e11c713-0f0a-45b2-afaf-7261c80a9dd7"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1206), 25 },
                    { new Guid("7f0abdc9-4d1d-40a8-a5fd-e4ea96b0db38"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1015), 84 },
                    { new Guid("8419f2a3-aa66-4fa8-bd9b-338d532b5d49"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1361), 49 },
                    { new Guid("84490302-0be7-4da3-8fac-fe82aa26ef13"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1195), 36 },
                    { new Guid("84d98f76-0826-4ef0-b3ef-1af8aaf0dc15"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1312), 25 },
                    { new Guid("8572fb83-8204-4925-a3d3-e113268b751b"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1339), 51 },
                    { new Guid("86b03c24-f8b0-400e-9d51-84ad92e644ed"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1094), 98 },
                    { new Guid("88ff7a2e-3f1e-4a50-a552-f1fd6beefe72"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1307), 27 },
                    { new Guid("8a06f17c-dc01-4d0d-a264-37422801009b"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1141), 96 },
                    { new Guid("8b286e36-e039-4780-8555-c319a02ebf64"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1353), 43 },
                    { new Guid("8b8a2737-2dc8-408a-98b7-c2f8129a9840"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1218), 88 },
                    { new Guid("8dc50fb8-3eeb-4d9d-9ae8-c0972e031e81"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1357), 87 },
                    { new Guid("8f421e92-e5dc-46da-9c1b-f6f2fcea286a"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1102), 84 },
                    { new Guid("9036ff4f-0812-4d49-84f4-0287fde4a514"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1291), 60 },
                    { new Guid("9091caa4-f53f-4263-a9ff-95094e52ef94"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1366), 66 },
                    { new Guid("92f743f6-e508-4af0-b0ab-f40dc15742d7"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1303), 67 },
                    { new Guid("9575f596-cd5e-49e8-9f49-8653c56746cf"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1170), 42 },
                    { new Guid("968af506-7f31-4c6d-9bee-3caa464a1369"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1316), 54 },
                    { new Guid("9b353baa-f3fa-44ee-aaf7-32f539e13317"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1318), 33 },
                    { new Guid("9df67184-6de0-4b4c-b9e9-90da0e564896"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1355), 80 },
                    { new Guid("a4a8a141-17a5-414c-bba2-e2f130d3a6e3"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1191), 83 },
                    { new Guid("a6e6c3d7-f4cf-4bd0-984d-b89f6f1b667b"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1232), 24 },
                    { new Guid("abe9ca78-ea24-4e6a-93ac-0a688dfac1be"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1282), 93 },
                    { new Guid("ad1ffa82-c876-43fc-993b-1cef6b7de525"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1204), 83 },
                    { new Guid("ae617315-f3ca-4902-87a5-0b0bc0e539a4"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1230), 50 },
                    { new Guid("b025bc50-5d18-44d3-8fba-e0f60256cdd1"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1149), 23 },
                    { new Guid("b10cc3f9-2cad-4353-b6b9-4292fa4ebbe5"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1120), 47 },
                    { new Guid("b1a100fe-2769-4aa3-b306-247bb07fe4f9"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1176), 85 },
                    { new Guid("b4e79d45-aeb5-4936-92fd-9ddd697bdb63"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1155), 56 },
                    { new Guid("b76b42fa-0d4f-476b-8f95-653cee5d2fe1"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1172), 43 },
                    { new Guid("b95036a5-c742-4759-b78f-d4a5d435d63a"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1398), 54 },
                    { new Guid("ba9c68a6-ad8e-47cf-89d3-e3088cb84dbb"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1368), 38 },
                    { new Guid("bdefb9c2-f945-4d8b-a6de-ec707d5d87bb"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1189), 25 },
                    { new Guid("bece2a74-66db-4315-9029-37713f1d3563"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1370), 85 },
                    { new Guid("bf70f0fa-2300-441b-867e-df030f53a313"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1373), 71 },
                    { new Guid("bf7325ab-6aaf-4649-b143-43a0d0ecb844"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1215), 48 },
                    { new Guid("c111a6d6-ae77-4e32-90ba-2532330984c2"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1220), 74 },
                    { new Guid("c2794943-7743-48f3-90bc-8478c9ff305d"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1210), 70 },
                    { new Guid("c5461a62-9ace-46d0-87f7-65835077d066"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1324), 21 },
                    { new Guid("c623cb61-eb50-4828-9ec8-d7276982973f"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1383), 95 },
                    { new Guid("c8ba91ae-84bc-40a3-8381-2066078a0f88"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1151), 78 },
                    { new Guid("c907bfe9-0194-4592-81b8-7965515ef48b"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1137), 27 },
                    { new Guid("ca7f7bbd-b35a-4d4e-8777-11415d119cf2"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1086), 71 },
                    { new Guid("cc834e1c-b9ce-4600-8d46-c0c7f6537c8c"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1359), 22 },
                    { new Guid("d18f97c5-0a3e-426b-a6b5-a868121becf4"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1349), 67 },
                    { new Guid("d286dbf0-f271-44d3-a455-1fd8202554aa"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1297), 55 },
                    { new Guid("d363cea0-3de4-4225-9cc3-c7fcad0b2ff3"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1278), 55 },
                    { new Guid("d4c57867-2b0e-4328-84c6-ca10a7322999"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1100), 79 },
                    { new Guid("d5ba7ff4-edd8-4f98-93c7-901d55670aa2"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1390), 40 },
                    { new Guid("d5ffd00b-ff33-4f45-adb0-53ceb5f446e4"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1377), 71 },
                    { new Guid("d603254d-2b06-4320-8d3f-1b3dcf25bf4a"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1182), 54 },
                    { new Guid("d75afb63-5f36-4d0c-911c-1db174779df6"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1076), 43 },
                    { new Guid("d791784d-edad-4f5e-bc9c-5f81aab5fad0"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1133), 56 },
                    { new Guid("db1062e5-5e21-461e-a33b-2753c9ef603a"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1106), 58 },
                    { new Guid("db913d42-c68e-40ed-8e74-89954a58497d"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1375), 32 },
                    { new Guid("dba0ee99-0bf0-4ea4-b5a4-3ba57867bab9"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1124), 87 },
                    { new Guid("dd327f53-9d67-45d9-b048-73ecc4328f54"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1164), 33 },
                    { new Guid("df5fb88d-c402-4196-956e-bf99cb383b69"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1326), 29 },
                    { new Guid("df6e5219-6771-4d36-a03d-9d9640031c9e"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1200), 80 },
                    { new Guid("e0b510ad-96e2-4f0f-adab-512bc1102e63"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1347), 27 },
                    { new Guid("e72cf714-8fed-448b-8a23-33fa36d63e79"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1264), 36 },
                    { new Guid("e983d430-2b7e-4197-a6f0-95a9a3e5f498"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1379), 69 },
                    { new Guid("ea54059b-6cb4-41e5-b12a-b11d30856313"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1174), 52 },
                    { new Guid("eb5c0258-15e0-4188-b9f5-64f948455bb5"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1126), 58 },
                    { new Guid("f09dbbc2-c201-4810-974c-15b9ff954707"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1301), 58 },
                    { new Guid("f267ff83-8041-460a-9b10-de703ef8c424"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1113), 54 },
                    { new Guid("f8fe305c-c097-4582-9f23-300981d4ba9e"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1402), 38 },
                    { new Guid("fa9530d8-c687-497a-8a82-e2cd829780cb"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1109), 20 },
                    { new Guid("fba7d54b-aa0d-4009-8eaf-9c69e37c5e47"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1334), 51 },
                    { new Guid("fdccae73-fd43-4d26-b8eb-3278dcf5c448"), new DateTime(2023, 10, 31, 13, 54, 29, 495, DateTimeKind.Local).AddTicks(1168), 53 }
                });

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
                columns: new[] { "ProductId", "ColorId", "ProductDescription", "ProductName", "ProductPrice", "Quantity", "Rating", "SizeId", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("035b4542-12e7-4598-9273-f450f012e014"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 993.0, 51, 2, 5, 1 },
                    { new Guid("035bbdfd-aa99-4ec4-92d5-72602e39da6a"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 590.0, 37, 2, 5, 7 },
                    { new Guid("138db553-7830-4a20-b081-7bcda2dc41a0"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 121.0, 62, 3, 1, 7 },
                    { new Guid("1758468e-20cc-4823-bd98-9a614a85b2ee"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 91.0, 19, 3, 3, 1 },
                    { new Guid("17c50add-42d5-48b8-bd9f-dff0ce0cb31d"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 691.0, 64, 2, 2, 1 },
                    { new Guid("1876e8c0-896d-4025-afb6-611e72086131"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 620.0, 33, 2, 2, 7 },
                    { new Guid("18881d33-a319-4c4e-97de-33c71afcdcc3"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 420.0, 65, 0, 5, 7 },
                    { new Guid("1aa47020-1318-4fc1-9052-eaba4b13f162"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 912.0, 41, 1, 2, 7 },
                    { new Guid("235220fa-1a54-44a0-aa41-35d104ba865c"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 838.0, 63, 4, 5, 7 },
                    { new Guid("25e645d6-b234-4d6c-8a8d-5cd30b2f7136"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 861.0, 42, 4, 1, 1 },
                    { new Guid("28aaeb5a-4944-40cd-b0cc-b7bed3f66322"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 647.0, 21, 1, 4, 7 },
                    { new Guid("2cee388d-55e7-4684-85c1-52fa2fa64992"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 523.0, 87, 1, 3, 7 },
                    { new Guid("3463b40f-6fd8-4ba7-87d8-5c495d730d6e"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 840.0, 60, 4, 4, 7 },
                    { new Guid("352835e7-5c80-4415-85c2-2c29b4eef924"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 802.0, 97, 4, 5, 1 },
                    { new Guid("3986808f-3fb5-470f-b57a-830036e56c8d"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 722.0, 6, 1, 4, 7 },
                    { new Guid("3c2940ac-876e-4570-ab8d-44ab926a509b"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 427.0, 38, 1, 2, 1 },
                    { new Guid("43010c27-dcb4-4c27-91b5-7f4333fe45bc"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 878.0, 58, 3, 2, 7 },
                    { new Guid("430bf486-122d-45be-ad77-98e5b327c796"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 189.0, 81, 2, 6, 1 },
                    { new Guid("447481e6-de84-45aa-830d-8782e1e10920"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 927.0, 2, 1, 3, 1 },
                    { new Guid("4671875e-b894-44bb-a40e-386724e96c1c"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 638.0, 2, 0, 1, 1 },
                    { new Guid("49338d0a-de50-4221-97a3-b49b78adba85"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 560.0, 17, 1, 6, 7 },
                    { new Guid("4b259df5-2fc7-4ed4-b0c5-46992a1f9c32"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 623.0, 23, 3, 5, 1 },
                    { new Guid("4e86a840-07f7-46fc-b13d-19c80fa9b138"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 327.0, 25, 3, 2, 1 },
                    { new Guid("4ea1e600-0584-4c5c-b5b2-83fe4ec5e38b"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 122.0, 80, 3, 6, 7 },
                    { new Guid("511318df-a073-4910-b63d-3a96fcab5aab"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 189.0, 31, 4, 6, 1 },
                    { new Guid("550b2a59-d9e4-4fee-87d3-e30a866bfe6f"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 475.0, 36, 4, 3, 7 },
                    { new Guid("566f35f6-6db4-4a1d-961b-3922af83b9d9"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 908.0, 67, 0, 4, 7 },
                    { new Guid("5bad7b86-4726-4a5c-821e-9773e011a617"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 423.0, 45, 0, 2, 1 },
                    { new Guid("6099ab4a-01d4-44dd-908f-7ada584d498b"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 747.0, 45, 0, 4, 1 },
                    { new Guid("653e5e7a-46b3-4a22-95bc-b23ef4c26c1d"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 969.0, 60, 0, 3, 7 },
                    { new Guid("662bdb8b-f37f-4f8b-b5fb-403d6897f5f6"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 408.0, 16, 0, 1, 7 },
                    { new Guid("7370cb33-a714-406c-98c2-eaa6af14b5a4"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 363.0, 85, 3, 5, 7 },
                    { new Guid("73e92dab-4bc0-41ce-8103-12c06bcb6a5b"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 567.0, 33, 0, 1, 1 },
                    { new Guid("7627068f-6f81-46d1-83dc-bf163984ffa9"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 517.0, 91, 4, 2, 7 },
                    { new Guid("78ce4f6f-6df2-415a-93ee-88333766e49c"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 863.0, 62, 4, 4, 7 },
                    { new Guid("7d45fc52-2b6d-4f49-991e-723aa62b2626"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 178.0, 87, 4, 3, 1 },
                    { new Guid("7df1695b-c2c5-41b7-8de3-49ffc3213c1b"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 315.0, 49, 2, 6, 7 },
                    { new Guid("8419f2a3-aa66-4fa8-bd9b-338d532b5d49"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 773.0, 28, 2, 5, 1 },
                    { new Guid("84d98f76-0826-4ef0-b3ef-1af8aaf0dc15"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 99.0, 54, 4, 5, 7 },
                    { new Guid("8572fb83-8204-4925-a3d3-e113268b751b"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 241.0, 63, 3, 6, 1 },
                    { new Guid("88ff7a2e-3f1e-4a50-a552-f1fd6beefe72"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 485.0, 71, 2, 3, 7 },
                    { new Guid("8b286e36-e039-4780-8555-c319a02ebf64"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 419.0, 12, 0, 1, 1 },
                    { new Guid("8dc50fb8-3eeb-4d9d-9ae8-c0972e031e81"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 159.0, 55, 1, 3, 1 },
                    { new Guid("9036ff4f-0812-4d49-84f4-0287fde4a514"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 294.0, 72, 2, 1, 7 },
                    { new Guid("9091caa4-f53f-4263-a9ff-95094e52ef94"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 723.0, 68, 0, 1, 1 },
                    { new Guid("92f743f6-e508-4af0-b0ab-f40dc15742d7"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 518.0, 44, 2, 1, 7 },
                    { new Guid("968af506-7f31-4c6d-9bee-3caa464a1369"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 529.0, 80, 4, 1, 7 },
                    { new Guid("9b353baa-f3fa-44ee-aaf7-32f539e13317"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 669.0, 42, 2, 2, 7 },
                    { new Guid("9df67184-6de0-4b4c-b9e9-90da0e564896"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 126.0, 39, 2, 2, 1 },
                    { new Guid("a6e6c3d7-f4cf-4bd0-984d-b89f6f1b667b"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 629.0, 36, 1, 3, 7 },
                    { new Guid("abe9ca78-ea24-4e6a-93ac-0a688dfac1be"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 665.0, 2, 4, 3, 7 },
                    { new Guid("ae617315-f3ca-4902-87a5-0b0bc0e539a4"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 158.0, 88, 2, 2, 7 },
                    { new Guid("b95036a5-c742-4759-b78f-d4a5d435d63a"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 396.0, 68, 2, 4, 1 },
                    { new Guid("ba9c68a6-ad8e-47cf-89d3-e3088cb84dbb"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 616.0, 66, 1, 2, 1 },
                    { new Guid("bece2a74-66db-4315-9029-37713f1d3563"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 468.0, 55, 4, 3, 1 },
                    { new Guid("bf70f0fa-2300-441b-867e-df030f53a313"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 470.0, 72, 4, 4, 1 },
                    { new Guid("c5461a62-9ace-46d0-87f7-65835077d066"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 461.0, 65, 2, 5, 7 },
                    { new Guid("c623cb61-eb50-4828-9ec8-d7276982973f"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 879.0, 16, 1, 3, 1 },
                    { new Guid("cc834e1c-b9ce-4600-8d46-c0c7f6537c8c"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 891.0, 88, 4, 4, 1 },
                    { new Guid("d18f97c5-0a3e-426b-a6b5-a868121becf4"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 844.0, 99, 3, 5, 1 },
                    { new Guid("d286dbf0-f271-44d3-a455-1fd8202554aa"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 448.0, 65, 3, 4, 7 },
                    { new Guid("d363cea0-3de4-4225-9cc3-c7fcad0b2ff3"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 521.0, 96, 3, 1, 7 },
                    { new Guid("d5ba7ff4-edd8-4f98-93c7-901d55670aa2"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 173.0, 1, 4, 6, 1 },
                    { new Guid("d5ffd00b-ff33-4f45-adb0-53ceb5f446e4"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 270.0, 10, 2, 6, 1 },
                    { new Guid("db913d42-c68e-40ed-8e74-89954a58497d"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 610.0, 98, 2, 5, 1 },
                    { new Guid("df5fb88d-c402-4196-956e-bf99cb383b69"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 781.0, 51, 3, 6, 7 },
                    { new Guid("e0b510ad-96e2-4f0f-adab-512bc1102e63"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 84.0, 19, 0, 4, 1 },
                    { new Guid("e72cf714-8fed-448b-8a23-33fa36d63e79"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 417.0, 55, 4, 6, 7 },
                    { new Guid("e983d430-2b7e-4197-a6f0-95a9a3e5f498"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 855.0, 22, 3, 1, 1 },
                    { new Guid("f09dbbc2-c201-4810-974c-15b9ff954707"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 902.0, 50, 2, 6, 7 },
                    { new Guid("f8fe305c-c097-4582-9f23-300981d4ba9e"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 886.0, 33, 2, 6, 1 },
                    { new Guid("fba7d54b-aa0d-4009-8eaf-9c69e37c5e47"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable T-Shirt", 785.0, 32, 2, 4, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColorId",
                table: "Products",
                column: "ColorId");

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
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "PrimaryCategories");
        }
    }
}
