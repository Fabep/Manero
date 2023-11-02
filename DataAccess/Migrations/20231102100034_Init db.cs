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
                    { new Guid("000145b5-8303-42f9-88bb-2a5ea97d2791"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2297), 80 },
                    { new Guid("005b0eab-4337-427f-8459-02a9c306b67e"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2381), 35 },
                    { new Guid("0514bb47-c1d3-42cc-be9f-884c2c8a40e4"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2144), 29 },
                    { new Guid("0709bfde-954b-4bfc-8cdb-164227128333"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2370), 45 },
                    { new Guid("09bb6c51-ab4a-4193-988e-7a640fe00dcc"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2098), 28 },
                    { new Guid("0a0dab29-8e98-4a06-84fe-d6b230de6a53"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2388), 39 },
                    { new Guid("0dcc6ef2-ab4a-4c57-b521-3bed7b54e172"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2304), 39 },
                    { new Guid("11a658b9-7ef6-449a-bd26-40cbbca1a1dc"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2293), 75 },
                    { new Guid("11a95451-7f6a-4b6d-84f7-b3529825dfd9"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2231), 58 },
                    { new Guid("1380e859-edcc-4ade-98c2-c3bafc5293ca"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2133), 73 },
                    { new Guid("147829e7-1a03-40fe-9372-7d38c77b9045"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2347), 60 },
                    { new Guid("1629e81c-7d85-4549-94c5-335dd302ef90"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2174), 21 },
                    { new Guid("163f9c0b-b39c-4320-8f3f-e5158e21b5fc"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2138), 51 },
                    { new Guid("175b5416-bd36-4887-8565-47dae67e4466"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2342), 37 },
                    { new Guid("194b012a-d1eb-405b-b58d-2876da3ad380"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2066), 36 },
                    { new Guid("1bcc5d72-4bb9-4c96-8708-bbbe7c337d68"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2024), 83 },
                    { new Guid("1cb57692-8a97-477e-a1bf-b45770e8eab1"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2291), 85 },
                    { new Guid("1cc986c5-2568-4d16-8048-07f92350e6e5"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2336), 50 },
                    { new Guid("1deb549d-d39f-4779-9924-dbca7442f7fa"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2282), 84 },
                    { new Guid("1e8fdc33-e450-409f-b385-21e4e71793fa"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2349), 52 },
                    { new Guid("1eae13ba-9a40-42cf-9f17-1cb187b4ba7a"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2127), 68 },
                    { new Guid("1f444cce-a7a1-4ff1-9b27-ddf68fc5e95e"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2040), 47 },
                    { new Guid("20f59cb9-35ed-4637-b2ad-2e417358e762"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(1954), 64 },
                    { new Guid("234417b0-992b-4f14-905f-f2bf2426aa89"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2125), 85 },
                    { new Guid("24fa3aab-0589-4e77-b97b-32c8790635bd"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2169), 23 },
                    { new Guid("26d6fb2a-0590-4722-a567-d37c5c690936"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2229), 47 },
                    { new Guid("28869d87-6870-439c-8eed-f042c2cf564f"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2238), 32 },
                    { new Guid("2d79b4cd-b2b2-488d-970f-5d1bb700e570"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2222), 58 },
                    { new Guid("2dfc556f-6d35-4421-9a01-95b03ae187d2"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2364), 55 },
                    { new Guid("31e4c178-d185-4d7d-bd82-920b99bc3631"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2313), 20 },
                    { new Guid("32849363-41b7-4591-8c23-51bd33cc8e8e"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2060), 91 },
                    { new Guid("32d1a79f-d347-4007-a625-e38898f225aa"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2226), 68 },
                    { new Guid("32f26ff8-da19-49e7-a719-688bb2d3b6c6"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2140), 32 },
                    { new Guid("3397b776-add5-4a9f-b0d7-c94681f4e54a"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2122), 58 },
                    { new Guid("33cf4b68-c4cb-492c-b8b9-4fe771854ad3"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2080), 78 },
                    { new Guid("3507bd20-ea60-4f29-857b-6fa731315b69"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2284), 74 },
                    { new Guid("3a14a647-31b8-4dc7-a1dd-9a9e76edd9db"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2045), 50 },
                    { new Guid("3c9e645d-1589-4271-8b87-422044ca16f9"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2240), 66 },
                    { new Guid("3d840284-3bde-4f68-884b-64794f6a31e9"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2310), 76 },
                    { new Guid("3db16df6-048a-487d-8ab2-eb04cd1772e9"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2155), 88 },
                    { new Guid("3ffbdcd2-8b22-46d6-a486-5eaf3dffa81b"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2146), 53 },
                    { new Guid("40c630a0-ff37-4eba-be04-a4005a519cae"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2317), 21 },
                    { new Guid("419bb2bc-935f-417f-b6f0-f670e2cb740a"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2324), 92 },
                    { new Guid("446ec002-c23c-4d5b-905b-c90bbb9300fe"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2368), 61 },
                    { new Guid("4524a53a-ffb1-44c9-852a-eae3527c126d"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2357), 98 },
                    { new Guid("4701e9cd-9cca-4943-a5d8-5c50d81603b0"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2062), 43 },
                    { new Guid("48db9ee5-5998-4595-9205-c1678e17136b"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2055), 41 },
                    { new Guid("49945a56-9550-47ba-9ac1-c133d32c2c88"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2104), 95 },
                    { new Guid("4af9a09f-12bf-4b6d-975b-aaee87afb1c4"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2075), 97 },
                    { new Guid("4b3f5e4e-3664-4763-b09c-b7f2b299961d"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2164), 84 },
                    { new Guid("4cb5d58c-ce57-46da-8307-65757ea52fb6"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2215), 53 },
                    { new Guid("4e25ec20-e3cc-4d51-aff3-079ccedfc028"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2109), 64 },
                    { new Guid("4eba924b-af20-45b9-ac83-2e0832e02444"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2267), 47 },
                    { new Guid("519c97e5-4aa5-47f8-b4d3-fd9d81941563"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2118), 76 },
                    { new Guid("52682625-f2a6-4a2e-b79b-e287b4eef02d"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2302), 76 },
                    { new Guid("52daac5a-8a9c-490f-951e-791c1f62a93e"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2315), 23 },
                    { new Guid("5807ad4e-34d5-4461-a3e8-499f0f89724e"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2131), 30 },
                    { new Guid("58ff4ab7-f310-49c4-8b0d-ec68196eccb8"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2252), 38 },
                    { new Guid("59bd06db-e5d3-491b-bd1a-af3cb096289e"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2224), 37 },
                    { new Guid("5f835c24-5811-4739-ab73-e3bd460a7134"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2295), 89 },
                    { new Guid("625e3a6f-307d-4e31-ba66-01075ad16b19"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2233), 55 },
                    { new Guid("64080320-9935-4cf0-92ff-5bad061db36e"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2245), 67 },
                    { new Guid("649fd63e-2131-49e4-8fd5-6e970ad8c3c6"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2276), 90 },
                    { new Guid("677c8211-9867-4964-8d53-853a4249ea6d"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2160), 55 },
                    { new Guid("67e075a2-e1e8-4959-abf7-4ccd76dda16c"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2021), 45 },
                    { new Guid("698d4819-293d-48f9-a0e4-0461a1077a5b"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2111), 82 },
                    { new Guid("709a7316-5de7-4c56-a2b8-585a500bfe6a"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2260), 29 },
                    { new Guid("75500b5a-720a-4d30-b242-4216c9272b06"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2247), 96 },
                    { new Guid("75954e33-5af0-477c-b9e7-05d115bfe808"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2171), 48 },
                    { new Guid("77fe7fc4-8fc7-4a4a-a5f9-54ef6abb4a08"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2353), 89 },
                    { new Guid("78b50d61-e71f-4238-9d9e-a8f65a638f43"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2162), 35 },
                    { new Guid("79f0e7c1-195f-4cb5-80fe-588e072dc37a"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2094), 45 },
                    { new Guid("7a19632a-8818-4c9d-887d-6c806b7f80f0"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2265), 46 },
                    { new Guid("7d30a75e-92a9-4f19-9e91-b8c00c1f8650"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2351), 66 },
                    { new Guid("7de6175e-c3a7-455d-bafd-11574d79da88"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2280), 43 },
                    { new Guid("81582963-c91b-4433-9eda-f2e0881f64e2"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2167), 68 },
                    { new Guid("8299f8a3-f109-45ae-9c7d-dc7d71c2c2a1"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2384), 50 },
                    { new Guid("84115bc6-c1b1-42e4-b172-8971f08e62f3"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2377), 74 },
                    { new Guid("856e2d07-260d-4996-9c5c-1f399c961e25"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2050), 21 },
                    { new Guid("86035c9f-8ae6-4470-9b8d-a07265d3e200"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2271), 43 },
                    { new Guid("87a50d46-0b0d-417b-af2f-bca9605584a9"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2329), 27 },
                    { new Guid("89a775e6-b1c3-41ae-b770-476be4366a87"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2142), 78 },
                    { new Guid("8a40a15c-f666-48cf-a599-dcb016a24df4"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2101), 58 },
                    { new Guid("8af52399-7e43-4051-8590-de503347453f"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2256), 84 },
                    { new Guid("935eaebe-99aa-41fa-a235-80080728b3a0"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2366), 59 },
                    { new Guid("93e8ddb7-be20-4f6b-8e6a-f02a15f75efa"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2058), 93 },
                    { new Guid("943638b4-5ceb-4874-b556-d94b49ff715d"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2286), 48 },
                    { new Guid("94a619a4-a06a-4856-b2a2-ad9e5559b235"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2220), 86 },
                    { new Guid("97af6a8c-ddae-4da0-b91d-5a96f5b61870"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2037), 49 },
                    { new Guid("9874a762-90fa-4a1f-87ac-4c73f8973a3b"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2078), 27 },
                    { new Guid("98b106db-5ef3-483e-a768-faebc31fb7f7"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2242), 67 },
                    { new Guid("9b609605-fd94-44ea-8885-ec3e153a74b2"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2258), 60 },
                    { new Guid("9bde0289-df4e-462c-bde2-4847bff26236"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2153), 77 },
                    { new Guid("9ce61b72-afa5-49e4-9dc2-200ba087fe1a"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2372), 21 },
                    { new Guid("9e65ea44-6f08-46a1-9347-3860ad2d9035"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2386), 54 },
                    { new Guid("9e6e7a74-1076-4fc7-ad67-57aaedc26f82"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2068), 48 },
                    { new Guid("9fa0f3a8-2ea7-4a1f-bc04-d458c8d480b7"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2362), 66 },
                    { new Guid("a09d2dc0-0565-40a5-9f68-ef1df666f0f9"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2073), 99 },
                    { new Guid("a5e6d7bc-7774-4a3c-9b43-c58a6d467c6f"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2327), 53 },
                    { new Guid("a7a6efc7-9e77-4a93-a987-f76a223c0137"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2300), 43 },
                    { new Guid("a7fc8006-6b15-49bd-b588-8db3ab377cb9"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2136), 92 },
                    { new Guid("affa2073-ba43-467b-8c4b-c9a2ac6a5c5d"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2344), 75 },
                    { new Guid("b0c4c7d2-3219-4c19-b7ab-b850d98aa7dc"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2053), 57 },
                    { new Guid("b15b4ca0-911f-40e1-bdd1-b784baeedf90"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2030), 36 },
                    { new Guid("b3469892-366b-4b1e-a562-3ef8ef34a870"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2254), 89 },
                    { new Guid("b51d8510-07a0-489e-9223-e2e5f23b5360"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2308), 48 },
                    { new Guid("b65ca087-490f-436a-bd04-177758d3786d"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2319), 80 },
                    { new Guid("b8c8baf7-ecf9-408e-a534-fc867c5f9d01"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2269), 90 },
                    { new Guid("bb44b2ea-3cc4-4498-9aa5-2997656eb150"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2048), 34 },
                    { new Guid("bb9be3d7-3a70-4b1d-9701-cc16ef556d12"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2306), 22 },
                    { new Guid("be98a5a5-0301-47b2-b142-43a7bb1ca305"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2107), 73 },
                    { new Guid("c1221340-d21b-4f13-9488-9006f8624202"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2213), 50 },
                    { new Guid("c197b22b-c28b-404f-8038-be56ae6d3d55"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2157), 64 },
                    { new Guid("c2dd6e99-e407-49e0-9474-45bb8cefdbad"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2092), 77 },
                    { new Guid("c34832e4-66e9-477f-95a3-ce3a41108627"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2089), 53 },
                    { new Guid("ca851500-5edd-456b-95d0-2e7fce37b1db"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2338), 27 },
                    { new Guid("cec66a09-339a-4c28-a758-0c2f5b561ba3"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2278), 39 },
                    { new Guid("d15e9629-56d9-4327-9188-b0e04707ee7c"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2340), 74 },
                    { new Guid("d26e9ad0-e491-409c-8eff-0d34cb609c54"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2151), 83 },
                    { new Guid("d313d72f-1fe1-452a-b874-d7aed357e23a"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2034), 59 },
                    { new Guid("d6016dfd-fbd2-471f-bbaf-7196e60b4639"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2148), 99 },
                    { new Guid("d8406140-15f3-4394-b125-3ae66dcef65d"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2085), 99 },
                    { new Guid("dbb6c017-dee8-498f-b291-4eb45ddb213a"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2262), 85 },
                    { new Guid("dcd48625-cc28-4e3f-ae0c-050c35b1eabf"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2082), 72 },
                    { new Guid("dcd8cb64-a4ac-4832-adaa-f0c3b077b768"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2096), 27 },
                    { new Guid("dd44c213-16be-4d90-a0e4-13650240f2f4"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2113), 85 },
                    { new Guid("dd997435-8ab3-490c-926e-92da1b059c34"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2235), 62 },
                    { new Guid("e0b4b715-167e-467e-98e9-1b9aa8ee71b5"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2120), 64 },
                    { new Guid("e0bdee7b-a570-437b-ace4-1d997b7322ae"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2115), 29 },
                    { new Guid("e23d2568-4f60-4358-ad16-547f0ab185af"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2375), 22 },
                    { new Guid("e257dac6-9e8c-49da-8072-2f843b7afaf8"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2070), 22 },
                    { new Guid("e32172a2-5a42-4039-9e98-116e9a38a308"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2042), 78 },
                    { new Guid("e3760630-299d-4042-ad75-8f54fe0684a8"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2273), 93 },
                    { new Guid("e5340118-c5d1-4bf3-b9c3-178100b588cf"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2322), 51 },
                    { new Guid("e6a1d3dd-a298-419f-9446-0c9a4ef8c216"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2331), 56 },
                    { new Guid("e8d51b9a-5d9b-4096-a801-d3f7ebb009ff"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2087), 72 },
                    { new Guid("ead8ac79-89b2-416f-93ee-6e474d55fdc6"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2333), 63 },
                    { new Guid("ebebe4c3-118e-462b-8515-158e0e4a30c3"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2249), 92 },
                    { new Guid("eda05ceb-2a6e-4e92-8139-68b9a3e90163"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2379), 84 },
                    { new Guid("f11147a9-7bd7-4c21-84ee-e25ba58e8c4e"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2289), 43 },
                    { new Guid("f3b303b9-6933-4f4f-b026-ea94a2230ba2"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2027), 53 },
                    { new Guid("f3fcb983-8574-4062-991c-ba6a70a7f7b4"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2218), 82 },
                    { new Guid("f556fbcf-558a-474c-9e48-6749f4fe7270"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2129), 20 },
                    { new Guid("f78ddbf5-b39e-4c49-ad39-45312a9ddd4b"), new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2359), 33 }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "PromotionId", "Description", "DiscountRate", "EndDate", "Name", "StartDate" },
                values: new object[] { 1, "Manero's best sale yet!", 0.10000000000000001, new DateTime(2023, 12, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2516), "Autumn Sale", new DateTime(2023, 11, 2, 11, 0, 34, 191, DateTimeKind.Local).AddTicks(2512) });

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
                    { new Guid("000145b5-8303-42f9-88bb-2a5ea97d2791"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 254.0, 1, null, 4, 2, 7 },
                    { new Guid("005b0eab-4337-427f-8459-02a9c306b67e"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 933.0, 1, null, 3, 3, 5 },
                    { new Guid("0709bfde-954b-4bfc-8cdb-164227128333"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 358.0, 1, null, 1, 4, 5 },
                    { new Guid("0a0dab29-8e98-4a06-84fe-d6b230de6a53"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 527.0, 1, null, 1, 6, 5 },
                    { new Guid("0dcc6ef2-ab4a-4c57-b521-3bed7b54e172"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 947.0, 1, null, 3, 5, 7 },
                    { new Guid("11a658b9-7ef6-449a-bd26-40cbbca1a1dc"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 492.0, 1, null, 1, 6, 7 },
                    { new Guid("11a95451-7f6a-4b6d-84f7-b3529825dfd9"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 802.0, 1, null, 3, 2, 7 },
                    { new Guid("147829e7-1a03-40fe-9372-7d38c77b9045"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 182.0, 1, null, 4, 6, 5 },
                    { new Guid("175b5416-bd36-4887-8565-47dae67e4466"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 219.0, 1, null, 3, 4, 5 },
                    { new Guid("1cb57692-8a97-477e-a1bf-b45770e8eab1"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 737.0, 1, null, 4, 5, 7 },
                    { new Guid("1cc986c5-2568-4d16-8048-07f92350e6e5"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 97.0, 1, null, 3, 1, 5 },
                    { new Guid("1deb549d-d39f-4779-9924-dbca7442f7fa"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 802.0, 1, null, 0, 1, 7 },
                    { new Guid("1e8fdc33-e450-409f-b385-21e4e71793fa"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 402.0, 1, null, 2, 1, 5 },
                    { new Guid("26d6fb2a-0590-4722-a567-d37c5c690936"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 557.0, 1, null, 2, 1, 7 },
                    { new Guid("28869d87-6870-439c-8eed-f042c2cf564f"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 750.0, 1, null, 1, 5, 7 },
                    { new Guid("2dfc556f-6d35-4421-9a01-95b03ae187d2"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 672.0, 1, null, 0, 1, 5 },
                    { new Guid("31e4c178-d185-4d7d-bd82-920b99bc3631"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 485.0, 1, null, 2, 3, 5 },
                    { new Guid("3507bd20-ea60-4f29-857b-6fa731315b69"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 89.0, 1, null, 3, 2, 7 },
                    { new Guid("3c9e645d-1589-4271-8b87-422044ca16f9"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 647.0, 1, null, 2, 6, 7 },
                    { new Guid("3d840284-3bde-4f68-884b-64794f6a31e9"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 473.0, 1, null, 4, 2, 5 },
                    { new Guid("40c630a0-ff37-4eba-be04-a4005a519cae"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 168.0, 1, null, 2, 5, 5 },
                    { new Guid("419bb2bc-935f-417f-b6f0-f670e2cb740a"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 771.0, 1, null, 3, 2, 5 },
                    { new Guid("446ec002-c23c-4d5b-905b-c90bbb9300fe"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 184.0, 1, null, 3, 3, 5 },
                    { new Guid("4524a53a-ffb1-44c9-852a-eae3527c126d"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 428.0, 1, null, 3, 4, 5 },
                    { new Guid("4eba924b-af20-45b9-ac83-2e0832e02444"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 529.0, 1, null, 4, 6, 7 },
                    { new Guid("52682625-f2a6-4a2e-b79b-e287b4eef02d"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 956.0, 1, null, 2, 4, 7 },
                    { new Guid("52daac5a-8a9c-490f-951e-791c1f62a93e"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 764.0, 1, null, 1, 4, 5 },
                    { new Guid("58ff4ab7-f310-49c4-8b0d-ec68196eccb8"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 726.0, 1, null, 0, 5, 7 },
                    { new Guid("5f835c24-5811-4739-ab73-e3bd460a7134"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 385.0, 1, null, 2, 1, 7 },
                    { new Guid("625e3a6f-307d-4e31-ba66-01075ad16b19"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 309.0, 1, null, 0, 3, 7 },
                    { new Guid("64080320-9935-4cf0-92ff-5bad061db36e"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 567.0, 1, null, 4, 2, 7 },
                    { new Guid("649fd63e-2131-49e4-8fd5-6e970ad8c3c6"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 99.0, 1, null, 3, 4, 7 },
                    { new Guid("709a7316-5de7-4c56-a2b8-585a500bfe6a"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 955.0, 1, null, 3, 3, 7 },
                    { new Guid("75500b5a-720a-4d30-b242-4216c9272b06"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 650.0, 1, null, 0, 3, 7 },
                    { new Guid("77fe7fc4-8fc7-4a4a-a5f9-54ef6abb4a08"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 794.0, 1, null, 0, 3, 5 },
                    { new Guid("7a19632a-8818-4c9d-887d-6c806b7f80f0"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 434.0, 1, null, 3, 5, 7 },
                    { new Guid("7d30a75e-92a9-4f19-9e91-b8c00c1f8650"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 197.0, 1, null, 0, 2, 5 },
                    { new Guid("7de6175e-c3a7-455d-bafd-11574d79da88"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 186.0, 1, null, 2, 6, 7 },
                    { new Guid("8299f8a3-f109-45ae-9c7d-dc7d71c2c2a1"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 759.0, 1, null, 1, 4, 5 },
                    { new Guid("84115bc6-c1b1-42e4-b172-8971f08e62f3"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 120.0, 1, null, 4, 1, 5 },
                    { new Guid("86035c9f-8ae6-4470-9b8d-a07265d3e200"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 513.0, 1, null, 2, 2, 7 },
                    { new Guid("87a50d46-0b0d-417b-af2f-bca9605584a9"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 182.0, 1, null, 1, 4, 5 },
                    { new Guid("8af52399-7e43-4051-8590-de503347453f"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 334.0, 1, null, 1, 1, 7 },
                    { new Guid("935eaebe-99aa-41fa-a235-80080728b3a0"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 593.0, 1, null, 3, 2, 5 },
                    { new Guid("943638b4-5ceb-4874-b556-d94b49ff715d"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 334.0, 1, null, 3, 3, 7 },
                    { new Guid("98b106db-5ef3-483e-a768-faebc31fb7f7"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 181.0, 1, null, 0, 1, 7 },
                    { new Guid("9b609605-fd94-44ea-8885-ec3e153a74b2"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 812.0, 1, null, 3, 2, 7 },
                    { new Guid("9ce61b72-afa5-49e4-9dc2-200ba087fe1a"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 864.0, 1, null, 3, 5, 5 },
                    { new Guid("9e65ea44-6f08-46a1-9347-3860ad2d9035"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 733.0, 1, null, 1, 5, 5 },
                    { new Guid("9fa0f3a8-2ea7-4a1f-bc04-d458c8d480b7"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 244.0, 1, null, 2, 6, 5 },
                    { new Guid("a5e6d7bc-7774-4a3c-9b43-c58a6d467c6f"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 113.0, 1, null, 0, 3, 5 },
                    { new Guid("a7a6efc7-9e77-4a93-a987-f76a223c0137"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 582.0, 1, null, 2, 3, 7 },
                    { new Guid("affa2073-ba43-467b-8c4b-c9a2ac6a5c5d"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 852.0, 1, null, 0, 5, 5 },
                    { new Guid("b3469892-366b-4b1e-a562-3ef8ef34a870"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 687.0, 1, null, 3, 6, 7 },
                    { new Guid("b51d8510-07a0-489e-9223-e2e5f23b5360"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 624.0, 1, null, 2, 1, 5 },
                    { new Guid("b65ca087-490f-436a-bd04-177758d3786d"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 449.0, 1, null, 1, 6, 5 },
                    { new Guid("b8c8baf7-ecf9-408e-a534-fc867c5f9d01"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 179.0, 1, null, 0, 1, 7 },
                    { new Guid("bb9be3d7-3a70-4b1d-9701-cc16ef556d12"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 873.0, 1, null, 2, 6, 7 },
                    { new Guid("ca851500-5edd-456b-95d0-2e7fce37b1db"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 897.0, 1, null, 1, 2, 5 },
                    { new Guid("cec66a09-339a-4c28-a758-0c2f5b561ba3"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 682.0, 1, null, 0, 5, 7 },
                    { new Guid("d15e9629-56d9-4327-9188-b0e04707ee7c"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 472.0, 1, null, 3, 3, 5 },
                    { new Guid("dbb6c017-dee8-498f-b291-4eb45ddb213a"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 785.0, 1, null, 0, 4, 7 },
                    { new Guid("dd997435-8ab3-490c-926e-92da1b059c34"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 939.0, 1, null, 0, 4, 7 },
                    { new Guid("e23d2568-4f60-4358-ad16-547f0ab185af"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 457.0, 1, null, 4, 6, 5 },
                    { new Guid("e3760630-299d-4042-ad75-8f54fe0684a8"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 770.0, 1, null, 0, 3, 7 },
                    { new Guid("e5340118-c5d1-4bf3-b9c3-178100b588cf"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 768.0, 1, null, 2, 1, 5 },
                    { new Guid("e6a1d3dd-a298-419f-9446-0c9a4ef8c216"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 786.0, 1, null, 3, 5, 5 },
                    { new Guid("ead8ac79-89b2-416f-93ee-6e474d55fdc6"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 513.0, 1, null, 1, 6, 5 },
                    { new Guid("ebebe4c3-118e-462b-8515-158e0e4a30c3"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 469.0, 1, null, 0, 4, 7 },
                    { new Guid("eda05ceb-2a6e-4e92-8139-68b9a3e90163"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 729.0, 1, null, 0, 2, 5 },
                    { new Guid("f11147a9-7bd7-4c21-84ee-e25ba58e8c4e"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 54.0, 1, null, 4, 4, 7 },
                    { new Guid("f78ddbf5-b39e-4c49-ad39-45312a9ddd4b"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 397.0, 1, null, 0, 5, 5 }
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
