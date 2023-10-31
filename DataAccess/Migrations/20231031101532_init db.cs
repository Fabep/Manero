using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
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
                    { new Guid("005a66cd-cd69-4924-a083-52059e734c90"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1386), 97 },
                    { new Guid("00879e44-df95-4681-ae18-a4dd7a1e7bf4"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1463), 63 },
                    { new Guid("010ef2e4-f026-498e-9b30-200eff6dce45"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1491), 69 },
                    { new Guid("021b1a7a-bb59-422b-aa8a-2cf5db374783"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1371), 28 },
                    { new Guid("04d1ddb2-bf66-49af-9b2c-57ff5f26b8c6"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1367), 42 },
                    { new Guid("07fd8ddd-f7a4-4b51-8263-3a436553f365"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1369), 41 },
                    { new Guid("086d4b6b-310e-4dba-9f2c-1dcf5cf6de76"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1565), 60 },
                    { new Guid("08f5e044-0eac-4384-b9a3-2f3e55c7dbde"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1503), 56 },
                    { new Guid("0bf3cfcf-a385-4f1c-9ab7-152e3ba95e1d"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1334), 60 },
                    { new Guid("0f2ce3e6-93ef-418b-83d2-41e052c80854"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1569), 80 },
                    { new Guid("0f631b2e-3e34-422b-8057-87dd1783dc1b"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1360), 59 },
                    { new Guid("135591ba-8b87-46a2-ab16-e990d48662a5"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1451), 80 },
                    { new Guid("14f9a240-efe6-48a8-84c6-19c95406c8f6"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1428), 29 },
                    { new Guid("187e6500-161a-4d47-b6df-63e901fe2c2a"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1484), 89 },
                    { new Guid("1e49e4a4-d60f-46f1-893d-641b9c7d4f83"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1482), 35 },
                    { new Guid("1ef81754-86b0-4314-829a-ddbebe444238"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1397), 83 },
                    { new Guid("21c71088-76fe-40e0-ba66-bb78409aee6c"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1478), 68 },
                    { new Guid("227c44ef-aab6-4335-9e75-e7e0cdff8854"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1497), 62 },
                    { new Guid("239ddb4f-ca06-4b64-889f-4e31ce39ce8d"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1589), 47 },
                    { new Guid("240b8ca0-38d6-45e7-aaa0-abdf2372f0cd"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1447), 79 },
                    { new Guid("267bad5b-742e-4fc8-ae5b-973d13c81d31"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1510), 25 },
                    { new Guid("284bdf6b-3cd4-46b0-bd70-a655aca4f0dd"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1438), 92 },
                    { new Guid("2c62005a-0bb1-4d06-aad5-9a5ac3bf96ca"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1295), 70 },
                    { new Guid("2cd7c67c-1f05-4399-b5e5-be62c1edc702"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1403), 77 },
                    { new Guid("3318bb19-a09e-4893-a8c6-64b2c66eb95d"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1434), 64 },
                    { new Guid("337514d3-ced8-47a1-97e6-c8cc9c215fe9"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1399), 64 },
                    { new Guid("3689ba96-73c5-43a1-abbf-c621e0feb5d7"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1575), 53 },
                    { new Guid("3815c471-e4d4-4b1d-b6ce-0c811a3d8d61"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1224), 24 },
                    { new Guid("3d21ae85-3a60-4e37-961a-cf667f2a0190"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1461), 77 },
                    { new Guid("3eea6aa5-e1ee-4524-a8a2-16aa01d34c5d"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1343), 55 },
                    { new Guid("3fd46c49-945c-43ff-9d7c-12fb6869d7a3"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1505), 35 },
                    { new Guid("4074626f-e3de-494a-a140-87a1ad4aec5a"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1378), 94 },
                    { new Guid("4415c81c-6620-4f49-b76c-3dabac6da667"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1406), 31 },
                    { new Guid("443f1aed-b4a3-431f-82ab-d4f20233bfce"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1354), 54 },
                    { new Guid("494f8204-260b-4e64-bdba-fafd91c2c8b5"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1583), 74 },
                    { new Guid("4a94a437-bd9c-484d-bf9b-9efcd943bba0"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1373), 28 },
                    { new Guid("4afecf81-86be-4020-b0c7-f85e7927671e"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1591), 77 },
                    { new Guid("4b98ff30-b8ef-4eab-9863-fabdc62c08ac"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1325), 41 },
                    { new Guid("4dd6e0b7-53f5-42f5-bb89-f16787ca603f"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1299), 38 },
                    { new Guid("4e678c48-be6e-40b7-81e9-49abe19e142e"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1390), 91 },
                    { new Guid("4fba1700-428f-43c1-adad-788e28a9cc4f"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1297), 22 },
                    { new Guid("520a650d-69cc-4891-bb01-2e9111541850"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1595), 64 },
                    { new Guid("527f0448-a846-46b6-b74d-1749f8fc66e0"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1365), 97 },
                    { new Guid("53d83503-53e2-4cae-93f0-58a09095580e"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1430), 45 },
                    { new Guid("56025148-1929-4789-bf56-b1531ee27d6b"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1221), 72 },
                    { new Guid("563cac1f-0980-4020-8b47-d3716d041efc"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1408), 32 },
                    { new Guid("586c2aff-1997-487b-853e-581fc085624d"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1348), 66 },
                    { new Guid("586fe006-6823-4bd9-a895-456d8ded6f5c"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1527), 82 },
                    { new Guid("5894a5b0-4899-4859-adf4-3646102aa75c"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1530), 54 },
                    { new Guid("5b37f529-1274-4d74-85f3-b9498ff3cebe"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1415), 75 },
                    { new Guid("5cdc9f25-b3eb-4590-b570-0f0e9513309a"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1579), 39 },
                    { new Guid("5e911c50-d0f8-46fd-9c97-69fd9be0253b"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1375), 60 },
                    { new Guid("5ea41d06-4292-46d7-aba2-5cc07f97060d"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1501), 50 },
                    { new Guid("64be8929-d9c8-45c5-8cbc-f09fcaa19c97"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1384), 68 },
                    { new Guid("66ab8980-cd7d-47a0-b536-8a917ab04894"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1581), 42 },
                    { new Guid("673bbf30-8997-4b35-b891-d3787fe561a9"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1411), 69 },
                    { new Guid("69432b90-2132-48d8-a6be-2bf92c424ed2"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1516), 75 },
                    { new Guid("6a76e444-65b8-4f52-8e6a-cc3eca30f0ac"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1350), 66 },
                    { new Guid("6b020957-30da-4527-a376-015bc4d90129"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1332), 34 },
                    { new Guid("6dd4446b-e109-4500-9ef7-db9ebe21f180"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1508), 67 },
                    { new Guid("6e739028-dec1-45ff-b564-027889ca4641"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1521), 60 },
                    { new Guid("6fd9e0b9-0cfd-46b6-84c1-a50cd3838941"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1356), 61 },
                    { new Guid("7155c257-ebaa-4009-bb73-022a3b3c78fe"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1449), 31 },
                    { new Guid("748be502-b852-4c58-bf65-83d0db75814b"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1436), 72 },
                    { new Guid("74f787d6-2c0b-4cfc-951f-9c8a8cc867d4"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1604), 49 },
                    { new Guid("7730a1bd-352b-478a-a1be-1ca609e38104"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1303), 32 },
                    { new Guid("7765dcb3-13e0-46de-9664-ce80551c49c2"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1319), 73 },
                    { new Guid("7ae7aa9a-9417-459e-b50b-241f08f7d586"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1293), 35 },
                    { new Guid("7bceb641-91d8-48e8-9405-d215e1b954fd"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1523), 99 },
                    { new Guid("7dd7b944-b388-4c28-bcad-01696b70c478"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1417), 86 },
                    { new Guid("82ca69a3-a40c-4d0d-8f25-a501f8ef2250"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1571), 44 },
                    { new Guid("8505b958-d912-43ca-a7af-8d74e3a1976b"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1317), 25 },
                    { new Guid("871e3a4d-0f5f-4b02-85b3-398cf0bb118b"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1426), 51 },
                    { new Guid("89898340-89fe-4b89-a310-1a36fd1863cd"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1476), 20 },
                    { new Guid("8ad1ea37-f581-4c6d-897e-0f9c41fa05a7"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1587), 63 },
                    { new Guid("8e2b9dcb-86f3-4872-90db-13efa917a7c8"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1330), 69 },
                    { new Guid("8f03ae13-99a5-4688-aff4-04e3d92f2643"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1474), 26 },
                    { new Guid("8fea81a6-50fd-446f-b483-1ac041841384"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1401), 27 },
                    { new Guid("920acaec-0d56-40de-8ce5-9519f7538476"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1567), 74 },
                    { new Guid("96326fec-19dc-4628-85ce-fc04d828eb49"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1602), 70 },
                    { new Guid("988874ee-ba9a-4d1d-bf83-4732183eec39"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1306), 82 },
                    { new Guid("990bf386-16bb-4fd7-b65b-f4c33a2d4060"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1440), 23 },
                    { new Guid("996a73cc-a47b-4476-bd3d-8903940bd1df"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1380), 40 },
                    { new Guid("9a85e56f-9410-4bd3-9bd8-e49488bc391a"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1315), 93 },
                    { new Guid("9adaac89-c468-4bf6-a0a6-4ef785916bd9"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1321), 83 },
                    { new Guid("9f598cb2-4e65-40e9-8bf1-2fd4e925a3d8"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1159), 77 },
                    { new Guid("a08393a3-ad26-476d-a213-d80e09659209"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1525), 27 },
                    { new Guid("a3d3bcc6-cbb0-4e09-82fa-e9ae135fde5f"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1352), 43 },
                    { new Guid("a5c43137-c780-453f-b407-d052acc39121"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1585), 66 },
                    { new Guid("a87d1c4d-f980-4841-9a4a-d1747834fd4a"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1338), 93 },
                    { new Guid("a905d658-4525-4908-9b24-871752cee673"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1486), 53 },
                    { new Guid("a9ed6fd1-be1c-4cee-bb75-ad9b386dbbf1"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1493), 39 },
                    { new Guid("aa7e06d2-94c8-4db8-944a-e1e3ed5f2a33"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1216), 32 },
                    { new Guid("aae22b08-dd20-4f88-b21a-fd9ca26ecd98"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1393), 48 },
                    { new Guid("ac8c6b4b-a9d8-482d-9456-fdf8a772a0cc"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1489), 39 },
                    { new Guid("acf27a5f-429d-4425-a6fe-58fdef309fb5"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1606), 43 },
                    { new Guid("ae768add-a3b9-4344-b294-1e7c2a6fbbc3"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1512), 40 },
                    { new Guid("b157f4ae-a337-47ce-bb1f-b9b39677e0a0"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1230), 47 },
                    { new Guid("b2b43400-acd5-456e-8e6d-f3af17475904"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1519), 67 },
                    { new Guid("b4901bbd-08c4-4de6-b47d-1da942eb3d17"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1421), 39 },
                    { new Guid("b4bbe990-ced1-4176-bdb4-9413926f26c6"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1301), 49 },
                    { new Guid("b51cb560-6afe-4196-8f28-af64cd45ae63"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1323), 76 },
                    { new Guid("b52aa565-4b82-45a0-9a32-ba1e44bb8326"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1336), 73 },
                    { new Guid("b5c9a48d-3e1b-445d-bf63-71c320fc0107"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1313), 96 },
                    { new Guid("b8b81d55-713d-46fe-9a3c-37c5f3a4fb5b"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1455), 47 },
                    { new Guid("b992eca2-c7c9-4cf0-8563-f70424a84d03"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1423), 83 },
                    { new Guid("bba36a46-1215-4408-ab6b-4c332aefedb9"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1468), 67 },
                    { new Guid("c0cb838c-0ac9-409e-b0c8-42e7d52bbeff"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1453), 44 },
                    { new Guid("c442f47b-8703-4834-b3cb-0c4c70c50816"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1310), 21 },
                    { new Guid("c7ff05cf-cd55-45a1-9340-d9c889b35fe8"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1495), 84 },
                    { new Guid("c8d5cde7-2a5e-4f67-8dab-f493c0ed7b03"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1362), 86 },
                    { new Guid("cb85e60a-a300-48d8-a5f3-aa49092ef448"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1228), 44 },
                    { new Guid("cca9a8f9-ce9b-4703-8db7-65efbca2ae46"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1358), 80 },
                    { new Guid("cef3c84f-4ddd-4e82-9b80-fefd64bbbf1c"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1218), 29 },
                    { new Guid("cfc06d1c-5e0a-468c-b0ca-63b96ce9fcbe"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1445), 44 },
                    { new Guid("cffab235-eff2-4285-a50f-f2d68df6dca2"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1597), 55 },
                    { new Guid("d04c3fbc-d7d1-4d2b-a43c-a6d5692b2ace"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1593), 36 },
                    { new Guid("d14cd5c2-0822-48f0-9a79-36311b31e499"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1432), 57 },
                    { new Guid("d2483c4f-5e0c-4925-a049-cb2008dc39f2"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1573), 61 },
                    { new Guid("d80dbc67-5606-450e-8075-a7e5e8a3f68a"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1341), 77 },
                    { new Guid("d9df92d7-7916-494e-8528-bfbe9bd8373b"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1388), 26 },
                    { new Guid("da5c3b24-5c06-443f-976f-dbdc6735c004"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1214), 32 },
                    { new Guid("db2fa550-c93f-4081-90da-b7ae4aac0a4b"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1472), 20 },
                    { new Guid("dbc93373-e67a-40b5-8b95-3295172d3256"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1395), 59 },
                    { new Guid("dd2d308d-4b58-4773-8637-b49ab9563669"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1419), 59 },
                    { new Guid("de850779-ef8b-41f3-8e9f-ad72de69ac3a"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1327), 83 },
                    { new Guid("df03a63e-d5dd-4644-9ecd-f59189d91d08"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1562), 78 },
                    { new Guid("df053ed9-ce88-4568-8509-325c65d2cac4"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1457), 70 },
                    { new Guid("e038df3a-01a5-417d-94e8-ec1be5d2c77d"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1345), 26 },
                    { new Guid("e3f39c69-e929-4c2a-abf1-cef14fa8332f"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1480), 30 },
                    { new Guid("e4be8474-0a73-48d1-a7dd-835806bf2953"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1226), 52 },
                    { new Guid("e66a9090-a190-45a4-abe7-46f9b65fdbe4"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1499), 30 },
                    { new Guid("e70c75e7-73d4-4025-97cb-99a1e6e669f0"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1442), 80 },
                    { new Guid("ecfe3ed3-351b-4e7b-a762-3c2961d005de"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1413), 89 },
                    { new Guid("ed14d399-13d1-45c3-bb22-8ce2ab3a8ce7"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1288), 59 },
                    { new Guid("edd6915f-5d0b-4f27-a6ed-5d59da4f1e83"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1608), 28 },
                    { new Guid("ede1d3b3-4fc0-4892-be32-8d017e1a3bc2"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1459), 32 },
                    { new Guid("ee1b5e89-9621-4c1c-9667-a6703f903534"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1470), 44 },
                    { new Guid("ee41596f-e7c9-44bc-874e-962937cbe3fa"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1382), 84 },
                    { new Guid("f3479c2f-cc8e-4ed9-b0c4-b94d6d00fe52"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1465), 84 },
                    { new Guid("f474f65d-fb70-4b3c-bb3d-e1202346a0cd"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1599), 20 },
                    { new Guid("f6d7c049-6647-4ebf-a916-ed2ec049bd37"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1308), 78 },
                    { new Guid("f7b97df1-f0b3-4d7e-9091-e52c57252c75"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1291), 46 },
                    { new Guid("fe76d9c7-7fd1-4c3a-b700-b5782c423b85"), new DateTime(2023, 10, 31, 11, 15, 17, 924, DateTimeKind.Local).AddTicks(1514), 64 }
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
                    { new Guid("00879e44-df95-4681-ae18-a4dd7a1e7bf4"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 377.0, 15, 3, 1, 4 },
                    { new Guid("010ef2e4-f026-498e-9b30-200eff6dce45"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 896.0, 69, 1, 2, 4 },
                    { new Guid("086d4b6b-310e-4dba-9f2c-1dcf5cf6de76"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 399.0, 17, 3, 4, 10 },
                    { new Guid("08f5e044-0eac-4384-b9a3-2f3e55c7dbde"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 353.0, 52, 4, 2, 10 },
                    { new Guid("0f2ce3e6-93ef-418b-83d2-41e052c80854"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 751.0, 80, 1, 6, 10 },
                    { new Guid("135591ba-8b87-46a2-ab16-e990d48662a5"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 867.0, 92, 0, 1, 4 },
                    { new Guid("14f9a240-efe6-48a8-84c6-19c95406c8f6"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 198.0, 11, 2, 2, 4 },
                    { new Guid("187e6500-161a-4d47-b6df-63e901fe2c2a"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 373.0, 26, 3, 5, 4 },
                    { new Guid("1e49e4a4-d60f-46f1-893d-641b9c7d4f83"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 632.0, 56, 1, 4, 4 },
                    { new Guid("21c71088-76fe-40e0-ba66-bb78409aee6c"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 393.0, 9, 0, 2, 4 },
                    { new Guid("227c44ef-aab6-4335-9e75-e7e0cdff8854"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 731.0, 72, 3, 5, 4 },
                    { new Guid("239ddb4f-ca06-4b64-889f-4e31ce39ce8d"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 922.0, 54, 4, 3, 10 },
                    { new Guid("240b8ca0-38d6-45e7-aaa0-abdf2372f0cd"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 608.0, 68, 0, 5, 4 },
                    { new Guid("267bad5b-742e-4fc8-ae5b-973d13c81d31"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 98.0, 69, 2, 5, 10 },
                    { new Guid("284bdf6b-3cd4-46b0-bd70-a655aca4f0dd"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 438.0, 39, 1, 1, 4 },
                    { new Guid("3318bb19-a09e-4893-a8c6-64b2c66eb95d"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 815.0, 37, 4, 5, 4 },
                    { new Guid("3689ba96-73c5-43a1-abbf-c621e0feb5d7"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 333.0, 58, 2, 3, 10 },
                    { new Guid("3d21ae85-3a60-4e37-961a-cf667f2a0190"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 741.0, 11, 2, 6, 4 },
                    { new Guid("3fd46c49-945c-43ff-9d7c-12fb6869d7a3"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 248.0, 67, 1, 3, 10 },
                    { new Guid("494f8204-260b-4e64-bdba-fafd91c2c8b5"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 692.0, 32, 1, 6, 10 },
                    { new Guid("4afecf81-86be-4020-b0c7-f85e7927671e"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 660.0, 0, 0, 4, 10 },
                    { new Guid("520a650d-69cc-4891-bb01-2e9111541850"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 385.0, 90, 0, 6, 10 },
                    { new Guid("53d83503-53e2-4cae-93f0-58a09095580e"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 734.0, 5, 1, 3, 4 },
                    { new Guid("586fe006-6823-4bd9-a895-456d8ded6f5c"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 719.0, 37, 4, 1, 10 },
                    { new Guid("5894a5b0-4899-4859-adf4-3646102aa75c"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 919.0, 61, 0, 2, 10 },
                    { new Guid("5cdc9f25-b3eb-4590-b570-0f0e9513309a"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 213.0, 87, 3, 4, 10 },
                    { new Guid("5ea41d06-4292-46d7-aba2-5cc07f97060d"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 187.0, 21, 3, 1, 10 },
                    { new Guid("66ab8980-cd7d-47a0-b536-8a917ab04894"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 657.0, 25, 4, 5, 10 },
                    { new Guid("69432b90-2132-48d8-a6be-2bf92c424ed2"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 825.0, 71, 0, 2, 10 },
                    { new Guid("6dd4446b-e109-4500-9ef7-db9ebe21f180"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 574.0, 33, 1, 4, 10 },
                    { new Guid("6e739028-dec1-45ff-b564-027889ca4641"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 383.0, 85, 0, 4, 10 },
                    { new Guid("7155c257-ebaa-4009-bb73-022a3b3c78fe"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 671.0, 8, 4, 6, 4 },
                    { new Guid("748be502-b852-4c58-bf65-83d0db75814b"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 133.0, 22, 2, 6, 4 },
                    { new Guid("74f787d6-2c0b-4cfc-951f-9c8a8cc867d4"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 715.0, 4, 1, 4, 10 },
                    { new Guid("7bceb641-91d8-48e8-9405-d215e1b954fd"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 845.0, 32, 0, 5, 10 },
                    { new Guid("82ca69a3-a40c-4d0d-8f25-a501f8ef2250"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 962.0, 22, 4, 1, 10 },
                    { new Guid("871e3a4d-0f5f-4b02-85b3-398cf0bb118b"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 501.0, 19, 4, 1, 4 },
                    { new Guid("89898340-89fe-4b89-a310-1a36fd1863cd"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 638.0, 82, 2, 1, 4 },
                    { new Guid("8ad1ea37-f581-4c6d-897e-0f9c41fa05a7"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 118.0, 89, 1, 2, 10 },
                    { new Guid("8f03ae13-99a5-4688-aff4-04e3d92f2643"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 554.0, 49, 3, 6, 4 },
                    { new Guid("920acaec-0d56-40de-8ce5-9519f7538476"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 987.0, 73, 1, 5, 10 },
                    { new Guid("96326fec-19dc-4628-85ce-fc04d828eb49"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 491.0, 81, 1, 3, 10 },
                    { new Guid("990bf386-16bb-4fd7-b65b-f4c33a2d4060"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 517.0, 0, 4, 2, 4 },
                    { new Guid("a08393a3-ad26-476d-a213-d80e09659209"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 302.0, 28, 3, 6, 10 },
                    { new Guid("a5c43137-c780-453f-b407-d052acc39121"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 376.0, 41, 1, 1, 10 },
                    { new Guid("a905d658-4525-4908-9b24-871752cee673"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 669.0, 9, 4, 6, 4 },
                    { new Guid("a9ed6fd1-be1c-4cee-bb75-ad9b386dbbf1"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 721.0, 48, 4, 3, 4 },
                    { new Guid("ac8c6b4b-a9d8-482d-9456-fdf8a772a0cc"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 52.0, 65, 2, 1, 4 },
                    { new Guid("acf27a5f-429d-4425-a6fe-58fdef309fb5"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 407.0, 89, 3, 5, 10 },
                    { new Guid("ae768add-a3b9-4344-b294-1e7c2a6fbbc3"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 524.0, 38, 3, 6, 10 },
                    { new Guid("b2b43400-acd5-456e-8e6d-f3af17475904"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 154.0, 90, 4, 3, 10 },
                    { new Guid("b8b81d55-713d-46fe-9a3c-37c5f3a4fb5b"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 922.0, 23, 1, 3, 4 },
                    { new Guid("bba36a46-1215-4408-ab6b-4c332aefedb9"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 202.0, 96, 4, 3, 4 },
                    { new Guid("c0cb838c-0ac9-409e-b0c8-42e7d52bbeff"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 374.0, 36, 3, 2, 4 },
                    { new Guid("c7ff05cf-cd55-45a1-9340-d9c889b35fe8"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 866.0, 7, 2, 4, 4 },
                    { new Guid("cfc06d1c-5e0a-468c-b0ca-63b96ce9fcbe"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 111.0, 55, 2, 4, 4 },
                    { new Guid("cffab235-eff2-4285-a50f-f2d68df6dca2"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 673.0, 86, 2, 1, 10 },
                    { new Guid("d04c3fbc-d7d1-4d2b-a43c-a6d5692b2ace"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 941.0, 25, 2, 5, 10 },
                    { new Guid("d14cd5c2-0822-48f0-9a79-36311b31e499"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 779.0, 74, 4, 4, 4 },
                    { new Guid("d2483c4f-5e0c-4925-a049-cb2008dc39f2"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 518.0, 73, 2, 2, 10 },
                    { new Guid("db2fa550-c93f-4081-90da-b7ae4aac0a4b"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 453.0, 37, 1, 5, 4 },
                    { new Guid("df03a63e-d5dd-4644-9ecd-f59189d91d08"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 710.0, 24, 2, 3, 10 },
                    { new Guid("df053ed9-ce88-4568-8509-325c65d2cac4"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 287.0, 24, 2, 4, 4 },
                    { new Guid("e3f39c69-e929-4c2a-abf1-cef14fa8332f"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 91.0, 97, 1, 3, 4 },
                    { new Guid("e66a9090-a190-45a4-abe7-46f9b65fdbe4"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 309.0, 29, 0, 6, 4 },
                    { new Guid("e70c75e7-73d4-4025-97cb-99a1e6e669f0"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 159.0, 55, 2, 3, 4 },
                    { new Guid("edd6915f-5d0b-4f27-a6ed-5d59da4f1e83"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 245.0, 51, 2, 6, 10 },
                    { new Guid("ede1d3b3-4fc0-4892-be32-8d017e1a3bc2"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 134.0, 53, 0, 5, 4 },
                    { new Guid("ee1b5e89-9621-4c1c-9667-a6703f903534"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 492.0, 78, 4, 4, 4 },
                    { new Guid("f3479c2f-cc8e-4ed9-b0c4-b94d6d00fe52"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 596.0, 2, 3, 2, 4 },
                    { new Guid("f474f65d-fb70-4b3c-bb3d-e1202346a0cd"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 276.0, 31, 3, 2, 10 },
                    { new Guid("fe76d9c7-7fd1-4c3a-b700-b5782c423b85"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 447.0, 51, 3, 1, 10 }
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
