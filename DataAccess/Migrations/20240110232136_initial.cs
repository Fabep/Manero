using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
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
                name: "OrderStatuses",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.PaymentId);
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
                name: "PromotionCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    PromotionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_PaymentMethods_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "PaymentMethods",
                        principalColumn: "PaymentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "money", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentMethodPaymentId = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "OrderStatuses",
                        principalColumn: "StatusId");
                    table.ForeignKey(
                        name: "FK_Orders_PaymentMethods_PaymentMethodPaymentId",
                        column: x => x.PaymentMethodPaymentId,
                        principalTable: "PaymentMethods",
                        principalColumn: "PaymentId");
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
                name: "CustomerAddresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    AddressName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Streetnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_CustomerAddresses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WishLists",
                columns: table => new
                {
                    WishListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishLists", x => x.WishListId);
                    table.ForeignKey(
                        name: "FK_WishLists_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    AddressType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Streetnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderAddresses_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "money", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "money", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemsId);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: true),
                    SizeId = table.Column<int>(type: "int", nullable: true),
                    PromotionId = table.Column<int>(type: "int", nullable: true),
                    IsBestSeller = table.Column<bool>(type: "bit", nullable: true),
                    IsFeaturedProduct = table.Column<bool>(type: "bit", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "WishListItems",
                columns: table => new
                {
                    WishListItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WishListId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishListItems", x => x.WishListItemId);
                    table.ForeignKey(
                        name: "FK_WishListItems_WishLists_WishListId",
                        column: x => x.WishListId,
                        principalTable: "WishLists",
                        principalColumn: "WishListId",
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
                    { new Guid("00335b7b-b571-40c6-8357-b9d308ef4b4e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9055), 39 },
                    { new Guid("00a016b3-fa94-4f75-8e73-c758b4881f7d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8729), 31 },
                    { new Guid("00a1553a-dffe-4751-9f17-bfea73d256dc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9071), 38 },
                    { new Guid("00e238c0-bdde-491a-a39b-25755a42399a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8394), 81 },
                    { new Guid("00ebb8a9-7bdc-4a0e-a359-f4b531c0515a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8804), 92 },
                    { new Guid("00fc85fb-6ffd-4683-9bff-abdfc0bf15fd"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8735), 97 },
                    { new Guid("01038915-f311-40d3-b97c-baae154c8d19"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8674), 59 },
                    { new Guid("01a035a3-d493-4480-bdb7-d69358423139"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9119), 87 },
                    { new Guid("02485097-bbb3-4391-a901-04a990f640d1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9072), 60 },
                    { new Guid("0298c6d2-8976-4862-b85d-a167ff58ab6f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8728), 84 },
                    { new Guid("03202eef-e93a-4c55-8841-0eb1c8f97362"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8730), 24 },
                    { new Guid("035ffa07-9e8b-41e4-9129-b718b0be68ea"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8504), 41 },
                    { new Guid("0364444b-15de-43ed-8fc7-05b4a1ec3d17"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8546), 63 },
                    { new Guid("03a5a86c-e799-464a-908e-213275f8c1a6"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9221), 22 },
                    { new Guid("04bcc056-3631-455d-9b2f-d92684a0bfff"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9116), 93 },
                    { new Guid("04f9960f-ec65-44d2-bc8d-07ad4070e397"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8584), 82 },
                    { new Guid("0510bf8c-5936-4d03-b50a-4bd7875948d7"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9099), 76 },
                    { new Guid("0648a6ac-263e-4d8c-940e-e72ef23a9c26"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8891), 21 },
                    { new Guid("0679f864-4788-4670-aa82-a613ddd59d99"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8892), 88 },
                    { new Guid("0693cdeb-5989-4654-935e-de18f775b828"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9175), 93 },
                    { new Guid("07849e8b-431b-4d24-9d87-3a30d42eb10a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8920), 63 },
                    { new Guid("07af6686-3102-4362-b932-6fe174059136"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9132), 58 },
                    { new Guid("07f150e1-7de4-4c33-806f-c3eb3ab2a601"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8913), 88 },
                    { new Guid("082bf078-e5a6-4675-a272-8832e310abca"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8406), 31 },
                    { new Guid("086a7eb4-a9ce-4928-8ea6-2fdcbf56ac2e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8858), 93 },
                    { new Guid("086ffade-0a02-4774-a9ca-206baae1eb97"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8790), 36 },
                    { new Guid("08e2d35d-c9bf-4979-8b82-4726e0827b78"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9020), 54 },
                    { new Guid("0904a5fc-71ee-4e64-b73a-c400025896cb"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9283), 56 },
                    { new Guid("092878b0-79cd-493a-b930-3a3a8325a2ce"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9019), 77 },
                    { new Guid("0930e51c-bece-4769-92ee-4a707313fa6a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9056), 98 },
                    { new Guid("0960f4bc-1d2f-4b79-8940-09563d068421"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8644), 30 },
                    { new Guid("09c52c6a-1999-4c0b-8138-0f4c2a603ba2"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8746), 59 },
                    { new Guid("09c9467f-2dda-47e8-b747-93b3d6d393c7"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8740), 27 },
                    { new Guid("09f9b234-a644-4406-bdc7-5a001e9e87f7"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8687), 74 },
                    { new Guid("0a9bbd60-0814-479f-a234-979e7ebda937"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8890), 52 },
                    { new Guid("0ad38ad0-455a-4639-a173-7d398f358a5f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8943), 71 },
                    { new Guid("0b0ff98c-a83f-4e1d-b37b-256e2c8d8736"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8652), 82 },
                    { new Guid("0b3c5151-336d-4ffb-8548-b4e7ae17330a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9130), 29 },
                    { new Guid("0b897408-3343-45d1-b6f7-0ca29c10cd6e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9160), 50 },
                    { new Guid("0badccd3-7759-4e13-b47f-b7ab4955a4d9"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8613), 23 },
                    { new Guid("0bed5eeb-a48e-4a3f-888b-ced840be0460"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9078), 65 },
                    { new Guid("0bff02c8-4f2a-412e-bf53-23a1b5e3bd23"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8575), 38 },
                    { new Guid("0c21b309-693b-4b2f-b453-986f151f9a4f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9006), 94 },
                    { new Guid("0d23e87c-09f3-41b8-9e96-ca5dc3593c52"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8994), 34 },
                    { new Guid("0d41888c-2fdf-4d86-b52d-544250ce1d67"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8947), 93 },
                    { new Guid("0d50d7a7-3c11-4e33-a483-dbcfc3ee25eb"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8541), 33 },
                    { new Guid("0d6b1521-6006-4a33-a06c-f6221469e375"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8773), 97 },
                    { new Guid("0d92fd84-95fb-410c-b6ab-81ad1ffa1543"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8828), 94 },
                    { new Guid("0e0013cd-8c3b-4123-8fde-14af985930a7"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8395), 76 },
                    { new Guid("0e1fbc0e-1c88-43c9-b5c3-8e997a72cffd"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9232), 25 },
                    { new Guid("0e44f392-0b4b-4db0-abd3-a047c161ca16"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8742), 96 },
                    { new Guid("0f351724-d988-415c-9b22-f8f0d2df91b6"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9144), 56 },
                    { new Guid("0f630371-288d-43c4-8a83-fef25d0f208a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9204), 28 },
                    { new Guid("0f81fe95-74d9-4666-bac3-aee1dd4d9392"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8843), 90 },
                    { new Guid("0f94fe05-fb78-4597-9a17-ca378c4caa08"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9184), 86 },
                    { new Guid("108eee96-9912-40f6-b9e2-170b400934ec"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8829), 96 },
                    { new Guid("10d98537-f447-4662-8340-381e20a6c788"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9129), 74 },
                    { new Guid("1100c781-2c56-46a8-a74a-e2b2c44f692b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8459), 99 },
                    { new Guid("11ae315d-74c3-4dbd-b3ca-8b5d207943cb"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8896), 85 },
                    { new Guid("11ba15ad-c2fe-4337-803b-8ccec09c1d9f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9239), 66 },
                    { new Guid("11f6f03d-a93e-45d2-aff4-a74aa6a8b035"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8531), 21 },
                    { new Guid("1217a894-0d61-4718-8d59-8234ee0da06e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8826), 82 },
                    { new Guid("126ef642-8ed5-4ef9-8713-5e4c51b1c7b8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9166), 20 },
                    { new Guid("128bbef8-8d29-4dac-87f4-03196d24003d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8549), 35 },
                    { new Guid("1298095f-312c-4ed5-b1fe-1dc29e8ae2bc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9039), 88 },
                    { new Guid("12983a0b-f849-4a98-82ee-7076c9a3c3db"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8419), 88 },
                    { new Guid("132f05f1-6862-4c52-935c-02a2a8c7b4d1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9024), 46 },
                    { new Guid("13aea49a-a6de-471a-82c3-849026de8125"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9290), 54 },
                    { new Guid("13eb96df-779e-4b51-acbd-14fc2da9d6f1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9034), 89 },
                    { new Guid("140e92fb-5959-429f-9153-c3b0f667152b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9048), 42 },
                    { new Guid("144d7a1e-05b9-494b-a96f-d3b234710e4a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9180), 34 },
                    { new Guid("1494349e-c8fc-4760-96de-0c9a57ea9daf"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8789), 37 },
                    { new Guid("14d5a14d-c191-4a42-86b6-d0ccd2f1332e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8654), 85 },
                    { new Guid("153fece0-db09-40d4-bdf0-d9a3f2b1fa13"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9273), 97 },
                    { new Guid("15a166ec-10fa-4718-a1c0-7b62df57d0d2"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8431), 63 },
                    { new Guid("15b05f8e-c2ba-4adc-8c95-416d25f82825"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8621), 81 },
                    { new Guid("1629897a-cd5e-4a5f-89c0-ba5418884665"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8664), 65 },
                    { new Guid("16b2c485-66d0-41b5-936d-536dce066332"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8603), 87 },
                    { new Guid("16e2d2b9-ee59-4b36-b367-89f203e72b7a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9122), 26 },
                    { new Guid("18873faa-7886-4203-b7d6-407a6119db71"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9093), 31 },
                    { new Guid("18e636ad-7a57-4f50-a508-b4392a97bb51"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8783), 57 },
                    { new Guid("18f970eb-3606-480f-ac2f-e57684bdb6fc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9047), 23 },
                    { new Guid("191741f9-6139-44b8-b055-1052692544fb"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9189), 91 },
                    { new Guid("19286193-207c-42a8-b2d8-bfec59d5ad6e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9104), 51 },
                    { new Guid("1944edf0-7047-4a72-8c8c-dbacd0c50d76"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9157), 71 },
                    { new Guid("198c3b01-1691-4c2c-82d9-4faff9149572"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8700), 36 },
                    { new Guid("1ae3aa3c-8f4c-4626-8eb3-13368a891736"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8460), 61 },
                    { new Guid("1aeaa3c9-4c6a-42e0-84d2-c9a2a3b39ae5"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8376), 28 },
                    { new Guid("1b151a58-a2cc-47a5-aeaf-67bdd8ed61ed"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9191), 65 },
                    { new Guid("1cb12184-eef0-4f68-9050-22d4ea78d131"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9031), 26 },
                    { new Guid("1d78a173-8e62-499a-b9c5-3c090b0b3ad0"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9237), 89 },
                    { new Guid("1dc4bd9b-d9df-47b0-a801-822541490b46"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8986), 94 },
                    { new Guid("1dc7b26f-6cd7-4e3a-86a4-86c889569939"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8364), 33 },
                    { new Guid("1e737201-b205-4371-bb44-8982e4ca2a52"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8332), 57 },
                    { new Guid("1eade78e-3452-458e-807a-336ca1afd613"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9026), 59 },
                    { new Guid("1eed524f-434e-40a1-86bc-67918a011c78"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8984), 82 },
                    { new Guid("1f26222b-414b-4e24-b18d-d6694d43b816"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8766), 49 },
                    { new Guid("201cbe3c-c2bf-47f6-a857-045df225b232"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9179), 93 },
                    { new Guid("2056fa9c-85ec-43e5-b38a-202780e537d3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9073), 32 },
                    { new Guid("206a6624-b97f-4ef8-8430-98f8cdd978c2"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8879), 75 },
                    { new Guid("20977c7f-be87-4fc9-a53e-86b33355fba8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9208), 49 },
                    { new Guid("20b23b8f-4ae5-459b-826c-66b199f576ad"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9289), 32 },
                    { new Guid("20eac844-b6ef-41fa-a15a-e612f347d767"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8402), 36 },
                    { new Guid("2165da0c-e811-4656-bb78-0b6899d7091d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9227), 22 },
                    { new Guid("218304ff-ddee-4d75-8347-7ad0195e195b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8834), 47 },
                    { new Guid("21e92b8c-5e30-476d-b5d0-0e765c2c8d43"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8573), 40 },
                    { new Guid("21f2b78f-415e-4826-9252-3d3065174dc5"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9044), 69 },
                    { new Guid("21f30fb8-0a2f-4a62-b114-bbdcf85cbe20"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9127), 51 },
                    { new Guid("21fcdca9-3da0-41a6-93da-c2a03c079e07"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8965), 87 },
                    { new Guid("2203442e-88f5-4b2d-9264-6a5c4aadcb58"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8597), 97 },
                    { new Guid("22040289-4005-456a-b042-838290866351"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8827), 33 },
                    { new Guid("22f8cf58-9927-4e04-a5a3-c6f1862e02c8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8358), 60 },
                    { new Guid("231e1864-5470-4849-a989-1e00419cc372"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8560), 70 },
                    { new Guid("232c4ff4-dcfc-439c-91de-b52ceb49d8e3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9134), 48 },
                    { new Guid("233c0bd5-c27d-4496-bb68-4c415b9b5ebd"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8443), 69 },
                    { new Guid("233edce2-62b5-4335-888c-b54bd4f241fa"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9094), 55 },
                    { new Guid("23811f46-1579-42f8-b00f-9ce19f204080"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9136), 28 },
                    { new Guid("23b1b186-effb-461b-b901-3af7f85bab9a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8995), 50 },
                    { new Guid("23ddcd69-5ca9-471d-ab7b-41c85fc65465"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8463), 88 },
                    { new Guid("2403c486-e65f-44e0-abfb-a0e85b996c7f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8599), 91 },
                    { new Guid("24069a1d-8d6c-45f8-b929-901b3f00bf2f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8645), 22 },
                    { new Guid("240fd5b3-3518-4736-909d-267c8e2f4fdb"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8547), 57 },
                    { new Guid("2456cec4-fbef-452e-aa96-107ff99ebda8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8363), 84 },
                    { new Guid("24ae7658-577f-493d-9e1b-b0f6113c3f8a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9081), 23 },
                    { new Guid("254d8b1c-d441-4d60-9ec6-eadedf4a3001"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9097), 79 },
                    { new Guid("256b3229-2031-4c3b-9815-fa122992c86a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8472), 95 },
                    { new Guid("259020ca-dcf3-4438-9de9-c4799c2cc04f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8568), 45 },
                    { new Guid("26745b67-50ad-40a3-8064-2f38774d943e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9215), 37 },
                    { new Guid("26e93d96-5427-4f98-8658-2f6f4d0b0225"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9017), 36 },
                    { new Guid("26f687cc-01b1-4eae-b7f8-1b0993844aa4"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9186), 75 },
                    { new Guid("2750279c-49e1-4097-b976-e3337ac4de51"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8638), 53 },
                    { new Guid("276450e0-60e2-48c3-bfb9-f795e1a659d9"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8952), 34 },
                    { new Guid("2765f606-4257-4136-9057-3e2542f4e57f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8680), 52 },
                    { new Guid("27c175f7-c8e4-4231-98f9-df7d3a83dda6"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8330), 35 },
                    { new Guid("280d55c8-5f87-4f32-a6d4-146468c58c8c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9291), 91 },
                    { new Guid("2810311c-7c16-4c92-a775-3a41cfc32a84"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8998), 41 },
                    { new Guid("285043b3-3c61-4983-ae80-bc833c81df04"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9145), 80 },
                    { new Guid("29171ed4-c43c-4e1c-bb77-42070bf33b26"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9296), 86 },
                    { new Guid("29605a3b-9d35-473c-af13-3a19896e1c54"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8777), 67 },
                    { new Guid("29cd426e-1a33-483d-896a-ce82f5ba1a43"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9259), 72 },
                    { new Guid("2a61afbd-8208-49ff-8e26-a1860644b11f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8367), 88 },
                    { new Guid("2a749a74-e448-4031-9272-23f1659eb168"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8901), 73 },
                    { new Guid("2aa1881c-855b-4179-b263-850a1b784dcc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8710), 93 },
                    { new Guid("2b585b68-af9c-4552-b441-59064416cb86"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8688), 55 },
                    { new Guid("2bb5d9e5-ead5-4070-bf98-f2c408cef07e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8662), 21 },
                    { new Guid("2bf2e6ef-31d5-432a-9757-4178c03da6b8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8448), 94 },
                    { new Guid("2c00a5e0-9ec1-4fcf-983d-c1102618cf4a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8953), 93 },
                    { new Guid("2c0589e9-283b-4899-8d2f-6807a39072e8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9076), 45 },
                    { new Guid("2cfb6b79-71d7-4cb5-83f0-9c0078fd6e3e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8944), 31 },
                    { new Guid("2d9f7152-b4ac-44a1-95c9-577d4fc12682"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8779), 58 },
                    { new Guid("2da6e084-2c8e-417e-8e43-ed9bad64dc78"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8801), 27 },
                    { new Guid("2da8af19-f17e-42f5-96d5-6eceefd77792"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8409), 77 },
                    { new Guid("2dc7e3fd-5672-47d6-87a2-98c519e4551f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8929), 53 },
                    { new Guid("2e1e60af-5b49-4ea7-aad1-4ee3b17437c8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8538), 75 },
                    { new Guid("2e1f4e4a-e57a-4b97-8289-61a9e7840370"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9241), 32 },
                    { new Guid("2e255d49-4c6d-431d-b56f-3fd5d37bc305"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9033), 46 },
                    { new Guid("2e434449-d335-4d5b-9c67-99942d49ea31"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8887), 74 },
                    { new Guid("2e8438ac-e2ad-412c-b1fc-f7b4da262dbc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9171), 99 },
                    { new Guid("2ef5ab80-8abc-43d0-a8bc-326622acb9e2"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8762), 44 },
                    { new Guid("2f2613ae-8554-4016-b47d-dcf050cd3cb1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8753), 50 },
                    { new Guid("2f58b9ac-6059-4e7d-9750-ddf5c5840169"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8954), 49 },
                    { new Guid("2f80a1bc-e492-454f-8f39-c6bfcabc3b6b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8353), 42 },
                    { new Guid("3007aa54-c502-4f86-8cf5-6e68376961a7"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8781), 64 },
                    { new Guid("3045e18e-661e-46e3-98ab-6efc693fef89"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8655), 73 },
                    { new Guid("30c628cb-1988-4cb2-b4bb-82d3b759e657"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8494), 59 },
                    { new Guid("30d24adf-3d47-479a-92a6-05326d31c8df"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9169), 82 },
                    { new Guid("319a39d7-dca7-40eb-86f9-b74f71a1df1b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9300), 63 },
                    { new Guid("31a1cea6-7842-4b64-adeb-357440911eab"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9007), 37 },
                    { new Guid("31d42351-4c2c-48b9-acb8-dfcad1b30ca8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8598), 70 },
                    { new Guid("32657e44-da22-40c9-97e0-9e405fa09724"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9245), 33 },
                    { new Guid("327696be-2223-4898-aa22-a822e8ef3d77"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8449), 48 },
                    { new Guid("32f2b76d-5132-4909-8412-c1c99a252a83"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9226), 52 },
                    { new Guid("32f2dee3-8554-4afd-8657-5bad8d54af51"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9258), 50 },
                    { new Guid("3306496b-70fc-4ba2-9e60-87cbcc12bf90"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8642), 51 },
                    { new Guid("33569aab-1a02-4c91-8981-315ee4ccc53d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9190), 55 },
                    { new Guid("33685e6f-9d4b-4274-afd8-79a42a9c2865"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8631), 99 },
                    { new Guid("3372f91d-012e-4a16-87c0-689c275b1843"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8589), 66 },
                    { new Guid("33eb8107-f924-469f-85ff-cb2869f6b2d3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8835), 63 },
                    { new Guid("34568a2c-48a4-47c6-9684-b22af382dcfe"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8577), 75 },
                    { new Guid("345dd49f-d696-465d-851a-a841e8e588bd"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8657), 28 },
                    { new Guid("34b7ac91-e92b-4959-b2f7-464ba01ca513"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9054), 88 },
                    { new Guid("34e0b6e8-7b50-47a8-a844-84e043464ca7"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8684), 75 },
                    { new Guid("351355cf-9bec-4bfc-9823-87de2857d1a5"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8918), 46 },
                    { new Guid("359c8c7d-30a3-4bd7-ae09-ed36153f276d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8985), 61 },
                    { new Guid("35d8d439-6d1b-4f00-b9ea-71b0074a273f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8473), 33 },
                    { new Guid("36534f05-f290-4145-897b-8aae054fb410"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8370), 28 },
                    { new Guid("371421bc-847c-4e40-92ae-0da252be330f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9279), 41 },
                    { new Guid("3724af63-6c29-49d8-a61a-133dd6220b9c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9210), 94 },
                    { new Guid("3748b64b-3b9c-40b3-9018-89ed93f43282"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8675), 84 },
                    { new Guid("377fd82d-ac24-4d78-9d24-074bdb0fa637"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8726), 27 },
                    { new Guid("37b5fed3-9dea-4740-9af2-6622888188a4"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8713), 56 },
                    { new Guid("37fcf694-c8bb-4299-b7a0-9a9c681088cb"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8724), 33 },
                    { new Guid("3832d06d-5e02-4541-b438-61c98ee3fe92"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8928), 39 },
                    { new Guid("3857b649-289f-4b92-8cd2-638e1f340648"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9220), 81 },
                    { new Guid("385fd591-a529-483e-a7cf-4bbfa5043ea4"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9088), 31 },
                    { new Guid("386a1bcc-cb7c-4490-88ec-904991487cd0"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9242), 35 },
                    { new Guid("387ab56a-8cdc-4ffe-8ca8-9eaa88c5e0fa"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9199), 88 },
                    { new Guid("38a06c36-7620-46f5-b175-a40c14154609"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8492), 46 },
                    { new Guid("38a851bd-3a8c-4b90-bcc5-f9d51d6876e3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9123), 75 },
                    { new Guid("38c0857f-83c0-4d30-aba1-d62f43bbcd92"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9265), 32 },
                    { new Guid("39166984-50b5-4e7c-b1a8-822654fb03c0"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8712), 87 },
                    { new Guid("39bbf06e-3312-4e82-93e4-1898af5b7751"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8623), 53 },
                    { new Guid("39c60466-8221-4249-bad4-0805ca929965"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8479), 31 },
                    { new Guid("39f4942d-e564-494c-a59a-2570b003c870"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8963), 49 },
                    { new Guid("3a784548-e1a9-469c-ad87-31795b6eb198"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8359), 50 },
                    { new Guid("3a9f9a73-8003-4b75-88d4-cfe8af51f939"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8467), 26 },
                    { new Guid("3ade6709-2eee-402a-8131-c273589d7797"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8627), 59 },
                    { new Guid("3b719ed4-876a-40a6-a47a-c3a08c1a33de"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8731), 79 },
                    { new Guid("3b720c66-d878-498b-82bd-24bd5a531583"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8570), 27 },
                    { new Guid("3baffa72-8e47-4a5e-a0f5-dfffe85b7c3a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8403), 45 },
                    { new Guid("3ca66575-15db-4f04-8c2b-736b7daadec3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8646), 23 },
                    { new Guid("3cdef85c-1858-4338-be99-f3a5181190be"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8275), 43 },
                    { new Guid("3d2d9e16-d29e-43e5-a5d5-e952cce5cbbe"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8859), 27 },
                    { new Guid("3dc6165d-f17e-443e-b9ff-7197b074c4d0"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9255), 64 },
                    { new Guid("3ebde6ab-0dc0-4320-b3d1-a9a8d1491443"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9138), 79 },
                    { new Guid("3ec12e4d-b054-40f5-9aa1-b75d0c39e721"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8451), 68 },
                    { new Guid("3f5bf581-c516-405e-bdc5-aa230a8a20f7"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8518), 43 },
                    { new Guid("3f5ea9ff-bacc-48c5-a88c-f3f717f2e8eb"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8912), 61 },
                    { new Guid("3f9a8596-e9c9-47dd-a3c7-b86ba644a804"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8351), 31 },
                    { new Guid("3fb99f19-e710-482e-ade3-3b193176276d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8734), 49 },
                    { new Guid("4103ee30-40ef-41cf-abcb-cf22ded8f3e5"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9173), 46 },
                    { new Guid("42152dca-5fa3-43f5-b910-750fddb9f01e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9060), 51 },
                    { new Guid("421d4ece-c1b0-4ae0-b185-bff30d74856e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8661), 52 },
                    { new Guid("4229477c-ab5c-46fb-ba53-6131654ba873"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8993), 87 },
                    { new Guid("425dbd8b-4312-43b5-8c3c-6d92c103dbc3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9131), 22 },
                    { new Guid("42d1ac34-e3c9-417c-99ee-0a264ac3019c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8519), 21 },
                    { new Guid("42f31633-a986-4f7f-b05d-50de7746f28c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8969), 35 },
                    { new Guid("44184fb5-fab5-4c0a-b66c-694bd17c4a90"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8600), 96 },
                    { new Guid("44559750-6daa-40a7-8aee-9c0ade2426d6"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8555), 97 },
                    { new Guid("445af8ab-15f2-4f18-bac1-5f62c1fd42b1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8942), 48 },
                    { new Guid("44de754a-64b8-48f2-a426-8f1b5e8b95d6"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8699), 22 },
                    { new Guid("44dfdc04-3bae-4c4b-8f85-2d9757366d46"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8911), 82 },
                    { new Guid("453c0e09-16fe-48ad-8d6c-709019c25665"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8520), 43 },
                    { new Guid("45af366e-ef27-4a07-9a37-5e77e3c9c486"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8853), 30 },
                    { new Guid("45c4355f-a28f-4853-94f4-8c2e55293637"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8488), 80 },
                    { new Guid("46496001-3a66-468f-9e88-b7b0814c8b2d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8398), 22 },
                    { new Guid("4652e73b-baff-4543-97f3-52d7e59da51b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8389), 29 },
                    { new Guid("471ad904-ccc2-4d44-b2ad-b7182c732a22"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8484), 84 },
                    { new Guid("48b46d2e-9366-4d67-8eb5-c4e981808ea5"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8932), 67 },
                    { new Guid("4a4be4f5-86f7-47d5-b34d-ef190f87dae4"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9050), 42 },
                    { new Guid("4a4d0314-4963-4444-ac05-69f0a7b0b2ea"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8572), 83 },
                    { new Guid("4a7302b1-b444-44d7-90ac-e9f5f1c098ba"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8392), 90 },
                    { new Guid("4b665619-01f7-4780-b084-8d408fc105fd"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8604), 57 },
                    { new Guid("4bc6391d-a74b-4a92-9b22-2cac50ca330f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9121), 67 },
                    { new Guid("4d023935-1d72-4e4b-b988-cb597145bf5f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8384), 47 },
                    { new Guid("4db80c47-32b2-4e05-996a-cc9f4122a1d1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8594), 61 },
                    { new Guid("4dd4ef93-f381-4fbf-95b8-7abbe78241a9"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9085), 31 },
                    { new Guid("4e861536-8415-4229-814a-5eab719a668f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9216), 72 },
                    { new Guid("4eabdc5b-4f4a-40e2-8765-f68e3591a6ff"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8800), 83 },
                    { new Guid("4f2856b2-6788-4e06-a17f-184b956d7324"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8996), 22 },
                    { new Guid("4f4346a5-cb39-4dd9-bedd-22aae248c0bf"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8733), 90 },
                    { new Guid("4f85d697-d979-466a-9699-112d1a533301"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8903), 69 },
                    { new Guid("50279adc-4e55-4dc7-8b76-2b4ca882d2ab"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9046), 81 },
                    { new Guid("50ca5bfa-63e5-4f3d-a9a3-96d012bd593c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8583), 43 },
                    { new Guid("50ecc5af-49f1-4e2d-99ab-d58cc85bf3dc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9270), 73 },
                    { new Guid("50f0a07a-74d8-4700-b93c-8f04cd8dabe3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8811), 44 },
                    { new Guid("518bfe8d-b409-4790-a8cf-8e4c7464e23e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8668), 55 },
                    { new Guid("51944397-68f6-49da-a658-3bc2035bf02b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8898), 99 },
                    { new Guid("527cc483-32c8-43fe-b77a-9d345debffc1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8846), 97 },
                    { new Guid("52f6879e-2281-47a2-9a5d-22afbaea9477"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8864), 27 },
                    { new Guid("530c64f0-01fd-408f-acd7-5e36502c5206"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8440), 35 },
                    { new Guid("5320be36-ed93-4c8c-9b60-0fba95e72ddd"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8690), 41 },
                    { new Guid("534ff47a-b902-4a83-93fd-3a094cef8091"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8548), 55 },
                    { new Guid("53fc745b-a7da-42ac-af8e-32621d44bb23"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9013), 78 },
                    { new Guid("541a7022-29c0-44e8-a1e2-a9f95c20b280"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8813), 73 },
                    { new Guid("543c114a-be8e-4689-a3a9-533e2a4eb370"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9137), 50 },
                    { new Guid("54814442-97cb-4506-80be-e47ff97c8617"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8499), 38 },
                    { new Guid("5499cafb-45db-482b-9619-ab4630da1749"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8397), 95 },
                    { new Guid("5504e0d8-8505-4eb0-b6ce-64dac36680cc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8474), 27 },
                    { new Guid("552bcb23-c1e1-4846-a48f-1a2ebac909b6"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8593), 55 },
                    { new Guid("5542e750-bf36-43b2-8726-9fe5e75a5862"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8400), 97 },
                    { new Guid("55757349-85df-4ec6-b669-7815e3eb5d74"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8796), 23 },
                    { new Guid("558642cc-8ef8-4a75-b841-cc7a863f9bde"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9154), 43 },
                    { new Guid("55a81ed4-1d20-49bd-83ed-af83d6bb0a0c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8990), 85 },
                    { new Guid("55e9a4cb-5243-4c7c-b09a-a0f4547c806e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9295), 20 },
                    { new Guid("56df1835-53b7-4c68-aa5d-c610ef809525"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8821), 91 },
                    { new Guid("56e2a939-8b0f-4162-aca6-649f6ee1427f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8981), 99 },
                    { new Guid("56edfc09-6b3d-40b0-9a4c-a7fb68e2a343"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8820), 55 },
                    { new Guid("575e8d38-aacf-4489-a43e-5b123d36d887"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8841), 90 },
                    { new Guid("57625036-aaf7-43a1-874c-5872942efd5c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9061), 80 },
                    { new Guid("587c71ee-746d-4cfc-b024-24276fad8cdc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8457), 69 },
                    { new Guid("5a44d419-381d-4e97-b757-f7367e44b524"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9205), 94 },
                    { new Guid("5a6c7a2d-c3a1-4ff8-ac13-1d7e4959e76e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8601), 29 },
                    { new Guid("5afdb535-3d2f-45ca-90d3-9252629a7e35"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8544), 70 },
                    { new Guid("5b040185-f2e5-4011-b294-d7ade3ff1663"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8855), 47 },
                    { new Guid("5b32457f-5c61-462b-828e-25ebb183492a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8937), 88 },
                    { new Guid("5bb44323-2fa4-45bf-ae39-f25da3e1308a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8444), 31 },
                    { new Guid("5bc1df00-9093-438c-bd36-34bdd15af8e1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8425), 58 },
                    { new Guid("5c031f90-6712-4ce2-9765-055a955fea21"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8862), 97 },
                    { new Guid("5c0aa62c-583c-4f30-93d2-1de79b9fd076"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9106), 31 },
                    { new Guid("5c26416c-5f42-4372-9233-99fc25a1aa81"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8838), 69 },
                    { new Guid("5c64421e-705f-4bb6-967d-8a41687ccc4f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8691), 83 },
                    { new Guid("5c84e767-b6bd-4217-97d7-33d0089706b3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8756), 65 },
                    { new Guid("5c943b4f-fbe0-4ad5-8f8f-1729b2c11840"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8416), 58 },
                    { new Guid("5c96b681-9068-4d42-a22a-a3c2e9868064"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8337), 32 },
                    { new Guid("5d0e0254-2aef-45b6-b55d-bbe9b42d0c30"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8558), 29 },
                    { new Guid("5d3bd2b8-96c5-4ad9-a9e9-9b63c87481bc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8987), 33 },
                    { new Guid("5ec71c97-d60b-4d6f-95db-58d15a5a0b2f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9243), 99 },
                    { new Guid("5f61d44c-5191-4618-856c-d56d9e6a5c76"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8388), 85 },
                    { new Guid("5ffea7e1-15c0-404d-bbf6-d424546b08d6"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9156), 87 },
                    { new Guid("60158010-a35e-4047-891c-b470faaee4dc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8816), 66 },
                    { new Guid("602bdd0e-1e58-4eb7-b5b6-afb2ed89db9a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8737), 94 },
                    { new Guid("603773b2-c291-4888-b360-cc21989db1f1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8876), 93 },
                    { new Guid("61020aaa-f65c-4726-ba6b-c41f701dd0d3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9298), 79 },
                    { new Guid("61f0c901-5f2d-4326-963e-1d760cb34d26"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9293), 41 },
                    { new Guid("6283a230-9b33-4b3b-b05b-257a8c1d7db8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8401), 87 },
                    { new Guid("6286f7ac-19a9-4f51-807d-ac1c0f6ef7db"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9135), 79 },
                    { new Guid("629ef9eb-02e5-4ad5-a3e7-852d0acd1a64"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9202), 54 },
                    { new Guid("62c36bfa-f570-4ca6-9286-15ac0133dacc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9091), 28 },
                    { new Guid("62fcc0ad-c83f-4f7a-884f-59d682a6aad6"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8578), 63 },
                    { new Guid("63495400-f02f-4a9b-9762-8db99837cd21"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8435), 78 },
                    { new Guid("63b2c65a-dcf6-4672-8b15-b84a6d7dfcc3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8770), 60 },
                    { new Guid("63e37004-b5a5-4f7a-8969-9f76772dbace"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8345), 96 },
                    { new Guid("644843a8-8c56-4089-b821-5ddbfb17870f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8854), 63 },
                    { new Guid("64f2bfc0-3516-455d-87a9-7c172c7509ea"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8506), 36 },
                    { new Guid("6552f50b-d436-484d-ab7f-7fb998b0b29a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8930), 72 },
                    { new Guid("6565d32a-3a46-43f5-af21-1a381609b936"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8976), 82 },
                    { new Guid("6580c6aa-e1e7-48c8-85dc-c78cc3b1efe7"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8767), 97 },
                    { new Guid("6607063c-af63-4b19-8e53-174809e771c0"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8393), 54 },
                    { new Guid("669dd026-3c29-4e6d-9612-8a508b3ab3e4"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9251), 48 },
                    { new Guid("67417f46-65aa-495a-a1a9-1731667b4d43"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8429), 53 },
                    { new Guid("674d6317-6b2d-488c-aadd-ee7682e7c0b3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8971), 33 },
                    { new Guid("6770205c-7118-416b-9295-15c7df399694"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8806), 39 },
                    { new Guid("6793adaf-d6f3-478d-990c-3043bd5a86b6"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8867), 74 },
                    { new Guid("6872ad94-cf07-40ef-97fe-e6ac3450fd03"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8356), 37 },
                    { new Guid("68ce1b2d-95dc-4e06-ae2f-af24ce70cc16"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8471), 40 },
                    { new Guid("68ee7580-e3c8-4704-b3a9-b3f3586f6878"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8852), 89 },
                    { new Guid("697c33a5-1f1c-4607-962d-43439d669ffd"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9207), 63 },
                    { new Guid("698bc882-bb77-4e98-80e0-4c5a1d81d9a7"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9288), 36 },
                    { new Guid("69a8a230-9ccf-43c0-944e-e18a733adfa1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8725), 33 },
                    { new Guid("6a05a158-bded-4a97-83ab-434737879f5e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8840), 72 },
                    { new Guid("6ad999d8-e649-4ba2-af5b-4a4039240b91"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8886), 98 },
                    { new Guid("6c780df4-b986-46eb-8e05-182e226e9c54"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9065), 93 },
                    { new Guid("6c7c051d-ed92-47df-ba23-2aebbd26dffa"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8408), 89 },
                    { new Guid("6c8e10c7-6a54-4c99-a84d-a908b5ff29d9"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8997), 32 },
                    { new Guid("6d7148e9-a62a-4c14-858a-09103fffcb53"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8848), 74 },
                    { new Guid("6d87f025-0075-4e64-a28b-948ab96056a7"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8755), 27 },
                    { new Guid("6d89c851-9c87-477f-b977-a2c5785da170"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8371), 62 },
                    { new Guid("6df843d7-2b99-484e-8c37-746118241a98"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8941), 71 },
                    { new Guid("6e0292ed-b4b2-4200-a3ee-bcccdf8ba5f0"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9070), 36 },
                    { new Guid("6e7a1a91-e4e7-410b-afe3-d57ef524d805"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8836), 57 },
                    { new Guid("6ef7c344-9aee-470a-a00c-83fd9a45692e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8822), 72 },
                    { new Guid("6f928eb4-89e9-477c-8b97-8cb8a55a2ede"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9254), 42 },
                    { new Guid("6febb98f-b454-42bd-a5fe-45c411f0d5fd"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8562), 69 },
                    { new Guid("70640a1a-d89a-4409-aaeb-e9b754ad5a61"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8454), 37 },
                    { new Guid("70baa966-3fe0-4e49-a48b-060bfeb259fc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8552), 31 },
                    { new Guid("70f927ea-e1c1-4118-a66c-4baaa73fc087"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8685), 52 },
                    { new Guid("7142cf3c-41ef-43b4-ba88-6179ad3d8cdb"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9015), 84 },
                    { new Guid("724ed4f3-6d20-41b8-a6e9-dfcc7d4db8b1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8917), 90 },
                    { new Guid("727a59b7-725a-4fcb-a08e-07b0fb45acfe"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8697), 90 },
                    { new Guid("736bd7d1-8347-44a4-b3dd-8e18fb7c58e3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8672), 34 },
                    { new Guid("73bf898a-8b59-4de9-97af-2e0e2d6f8791"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8442), 30 },
                    { new Guid("74005336-70f3-435b-a50c-83a50849dc4f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9052), 34 },
                    { new Guid("7434e45d-680a-4b40-8fd0-80faa85957c3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9028), 38 },
                    { new Guid("7483e2e1-1fce-43bf-ac14-170817694413"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8509), 56 },
                    { new Guid("75f60c0a-7224-4585-901a-d6a5435f559e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8940), 67 },
                    { new Guid("76112a83-787e-4d3c-b38e-d49b9a97285a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9062), 91 },
                    { new Guid("76339a73-b778-40f1-ae68-7901f3ee1166"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8521), 49 },
                    { new Guid("77149d71-2ca4-4383-aa44-1eb180ef296b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8908), 79 },
                    { new Guid("77244440-571e-4868-8b5b-8fe4d32760fa"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8803), 99 },
                    { new Guid("7877780e-64e5-488e-a869-a93f9cffcee1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8771), 56 },
                    { new Guid("789f564d-08ac-41f1-a48b-38f5a7ce882e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8683), 61 },
                    { new Guid("78baffc3-64db-4b64-a5bf-77f4b948fcdd"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8434), 80 },
                    { new Guid("78d121aa-e421-4675-87c5-a0f0b6e1bf05"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8893), 43 },
                    { new Guid("78e6854b-b710-493c-b6c4-dfe01fe94287"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8377), 88 },
                    { new Guid("79aaa1ad-3290-4824-adc0-3434d9bd8591"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8557), 28 },
                    { new Guid("7a2c3ffe-1c39-474f-ba3a-57cf3698e417"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8871), 46 },
                    { new Guid("7a56fc1f-f46b-4267-a05c-070aededfb7d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9268), 58 },
                    { new Guid("7aabd037-be1a-49e2-b6e1-f989a87495f7"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8366), 85 },
                    { new Guid("7aeea360-8ab1-406c-81e2-3399bd206989"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9253), 85 },
                    { new Guid("7b103cf0-f4dc-49f9-9050-acaa91c47b92"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8567), 20 },
                    { new Guid("7b2bbc9e-a67f-4403-bce1-e395decc4bd2"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9005), 99 },
                    { new Guid("7c03eb39-c455-43b9-ad49-65f9ab616bac"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9140), 59 },
                    { new Guid("7c3fb23c-dffb-437a-9566-d0e1ba0dd5d6"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9172), 81 },
                    { new Guid("7c436550-93e9-404e-812b-7edd0be08320"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8934), 84 },
                    { new Guid("7c8abeda-d6a5-43e5-bfa6-781662074d7f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9084), 97 },
                    { new Guid("7c9e2e78-8b86-4e5c-a492-1676bcbbd90e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8423), 63 },
                    { new Guid("7ca06a4e-7fcc-44fd-9a2e-393ec10ace4b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8620), 74 },
                    { new Guid("7d1dff8f-bdcf-4896-a3c3-112dd8ee8e53"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8480), 38 },
                    { new Guid("7e1b15f2-9eb8-4004-9b2e-d70089a0a256"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8539), 43 },
                    { new Guid("7e25fa73-ccfd-4b28-9c80-801ce44a0ae8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8778), 89 },
                    { new Guid("7e7b7439-c6de-46bb-8e22-c60918bdbde4"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8856), 92 },
                    { new Guid("7eaaeba6-b5c0-43ee-8282-6d468b78886f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8390), 22 },
                    { new Guid("7f353e2b-1995-488d-8c8d-ceb904fb072a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8606), 49 },
                    { new Guid("7f4a2560-f636-46ca-9063-7bbd73322889"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8579), 32 },
                    { new Guid("7f4b099d-3052-499c-8ffb-8da5f1417d55"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8516), 92 },
                    { new Guid("7fa806fe-6e0e-4b40-8fe0-cbc52b32ce1b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8374), 36 },
                    { new Guid("801f8e16-401c-4e8f-922f-4483c005b8db"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8447), 37 },
                    { new Guid("8044fe68-a47e-4233-b126-5f63de11ce9c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8618), 63 },
                    { new Guid("827a8e57-90e0-4235-b429-16b10fa8cef8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8617), 30 },
                    { new Guid("8303b030-a1b0-43f4-b58e-b6812926c68f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8802), 87 },
                    { new Guid("832bd9cf-9caf-4f0e-8f41-518734cdfdcc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8540), 81 },
                    { new Guid("8374560a-65e3-416a-81b7-9c40b0fa527d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9201), 23 },
                    { new Guid("839524ce-6583-4533-854c-0edeb03301d2"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9164), 32 },
                    { new Guid("84efaa1c-1176-4d54-95c3-48f324ca9ae8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8823), 83 },
                    { new Guid("85064944-05ac-4e08-b739-901e942d6b44"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8711), 36 },
                    { new Guid("85213768-ffa5-4057-91ab-ecb9b3bced2d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8357), 21 },
                    { new Guid("865a7307-316c-427b-a2bb-5a03e03bc3e0"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8786), 39 },
                    { new Guid("868229bf-c774-41ab-bb4f-1ac78f0bfd3f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8966), 99 },
                    { new Guid("86db8cf9-e068-4c1c-82bd-03e429b46847"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9083), 40 },
                    { new Guid("86edb9e5-7e09-497e-a921-fc683141b08f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8739), 97 },
                    { new Guid("8753e456-1934-46fc-b8ee-6da2a3b9ea8e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8452), 89 },
                    { new Guid("87645324-d0c0-4821-91e3-08aa62c6c60d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9274), 83 },
                    { new Guid("876863e5-dc7a-4995-a4b3-00fd62fc239d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9100), 35 },
                    { new Guid("87c79fc2-4ccf-4454-9bd4-602341dfd9dc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8640), 60 },
                    { new Guid("87c863d8-c208-42bd-84c3-63947f323302"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8875), 68 },
                    { new Guid("87df281d-1fd8-485f-b24f-d8add7e659e3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8720), 71 },
                    { new Guid("88497b2d-4619-4da1-af65-c50aecfe3017"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8741), 77 },
                    { new Guid("8871753b-bfa2-4e2b-a8ac-bdfbd23d7b91"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8576), 82 },
                    { new Guid("889ac3f0-bd2a-4d92-9098-2636d7cd30be"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9212), 56 },
                    { new Guid("88c59ee6-3c3b-4d09-b573-57e4b31b3e32"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8769), 72 },
                    { new Guid("88f56339-d79f-4af8-9f02-4ccf085f987d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9229), 84 },
                    { new Guid("89905f69-1a31-426e-90b2-2cb0c1cf9789"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9023), 61 },
                    { new Guid("89ecfc3c-f706-4ec1-8755-ab96a2c2c384"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8805), 41 },
                    { new Guid("8ad98035-c8b7-47a2-a163-868beff2f7c9"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9236), 61 },
                    { new Guid("8af44159-feda-4acb-827f-5ca7ed545035"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9276), 53 },
                    { new Guid("8baffdcc-8286-4a8d-a1f0-55963d5a0091"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8763), 89 },
                    { new Guid("8bb07f49-a6d3-4ce9-b18e-125f1510a021"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8751), 87 },
                    { new Guid("8bbc53a2-6e4f-4e96-8364-1106729120a6"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8380), 55 },
                    { new Guid("8bc3c06c-d1df-4e5a-83d5-6bfe8fa02687"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8950), 94 },
                    { new Guid("8c103add-53bf-43de-b6b7-c9b74c0598c4"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8799), 61 },
                    { new Guid("8c3a25c3-4d17-41d5-8eba-6cf65a0710df"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9112), 95 },
                    { new Guid("8caa6a3f-7687-4f00-859b-024dfccfa1ae"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9063), 24 },
                    { new Guid("8d016827-d1c1-4339-9fa4-69848bc9e096"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8554), 57 },
                    { new Guid("8d45e22f-9d77-42df-bfc9-8a5f02db7d84"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8678), 86 },
                    { new Guid("8d64e97a-4a60-4d3b-8ab5-5ebfd43a591d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8814), 65 },
                    { new Guid("8d7d88ef-e223-42cc-a610-4e8fb0fbe310"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8716), 37 },
                    { new Guid("8e1a56af-641e-4da9-b7fb-aaf3e8256385"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8666), 48 },
                    { new Guid("8e3dfb6f-e87c-4bea-bba2-4372fd4b062a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8660), 90 },
                    { new Guid("8e4c4024-4106-479e-af99-d21040edd8c2"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8596), 67 },
                    { new Guid("8eea2c5d-5aa5-4d1a-868b-f83b1410e684"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9068), 86 },
                    { new Guid("8f396dbf-9808-4633-9079-a01caf42fe0a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8772), 34 },
                    { new Guid("8f616f3f-383b-45a2-9667-514f4f6045f3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9038), 58 },
                    { new Guid("8f786884-89e6-406e-ae18-0a01b038afc8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9269), 30 },
                    { new Guid("8fab2c43-6136-4b31-96cb-7158e6f2ce77"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9275), 53 },
                    { new Guid("8fc3e16c-7671-4281-a184-255bb12fb027"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8670), 62 },
                    { new Guid("8ff5fc11-4229-496f-8ef3-afa6f732358f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8915), 64 },
                    { new Guid("9012dcb6-6121-46a4-be97-4c35073a8de3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9284), 45 },
                    { new Guid("9040286d-97d7-4cd3-9c52-457e6ca0a20e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8491), 41 },
                    { new Guid("9056361d-cc44-4d6b-8c9c-a8a1135866dc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9285), 30 },
                    { new Guid("91b00a2b-52af-484e-8370-b2155a284929"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9282), 30 },
                    { new Guid("92081e0a-80ee-4385-be3d-f81d7748d31d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9111), 26 },
                    { new Guid("9246c6de-72ac-49ef-b379-3e34bb9a6c81"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8333), 86 },
                    { new Guid("9286132c-d926-40d9-936a-dff40bb380c4"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8693), 30 },
                    { new Guid("92905b3c-b282-4276-a7b5-295e5f03a626"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8788), 81 },
                    { new Guid("92998891-9518-4771-bf57-ea8ec18a8004"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8505), 22 },
                    { new Guid("92a9e1e0-f510-4692-aa56-0e58234cea87"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8765), 32 },
                    { new Guid("92c3b323-fbba-4a72-a7f5-ccc34d6816dd"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8847), 99 },
                    { new Guid("930db3d7-16d1-458b-954e-a25ee607d5a9"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8817), 98 },
                    { new Guid("933bc8b7-1ba6-4021-b4df-c675c0072c6e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8513), 89 },
                    { new Guid("936b033a-6720-4b3b-9283-abf26945d979"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8809), 32 },
                    { new Guid("93d506bd-6b9c-4ae9-a1a9-4f769458e5ef"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8441), 26 },
                    { new Guid("955808b2-db83-4eaa-a3ca-ad8eec39edbe"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8760), 43 },
                    { new Guid("9585325e-04f5-4638-8d1b-051a9ad9c66e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9181), 77 },
                    { new Guid("95c18898-a71e-4a8e-936e-1091efe4b219"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8502), 57 },
                    { new Guid("96029cf0-e8b2-4eae-ae7e-a0fad7337473"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9087), 29 },
                    { new Guid("963ab65c-8516-4159-a67b-0028f366eb23"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9053), 57 },
                    { new Guid("96ab86bf-5a09-4ff2-8665-01baa77f788e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8619), 64 },
                    { new Guid("9740a98f-3a27-4a52-b8cb-b68e510d7b66"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8988), 79 },
                    { new Guid("97844e08-7143-4ffb-bf9e-77fdd9050dd7"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8694), 91 },
                    { new Guid("978b9b48-3b3f-4f79-a090-666a367b1fa9"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8455), 66 },
                    { new Guid("97f66afa-a92e-4966-b80e-6cb9364edeb4"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9074), 94 },
                    { new Guid("982fe586-0127-42eb-a8ce-1e7e16b5898d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8437), 38 },
                    { new Guid("98a1f90f-7315-4411-8bfd-6ac7f5a6a2cb"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8534), 67 },
                    { new Guid("98e5dbbb-75b5-45e5-9e7c-91dd8ab17b0a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8850), 68 },
                    { new Guid("99369ab0-dd1b-4bcb-9839-d46c4296710b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8581), 86 },
                    { new Guid("9943fc79-c69c-4a30-95c2-0f180b33e4e3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9257), 22 },
                    { new Guid("99561164-fc55-4823-85e4-d6d4556503a1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8433), 73 },
                    { new Guid("99c9f271-9ec6-40e4-a763-fc0fd8f409bc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9272), 87 },
                    { new Guid("99fa4af7-223b-4990-a094-e8bbc84eedb9"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8797), 26 },
                    { new Guid("9a78f8ae-7b17-49c9-93b5-accb841b08ee"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8656), 79 },
                    { new Guid("9b77661a-8908-4bb8-b4a0-64ba2411e68e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8608), 93 },
                    { new Guid("9bc9f591-ed5c-4f71-bb6b-2e4bc3fa42c0"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8514), 58 },
                    { new Guid("9bed93b6-1266-4ff2-942b-becc5a5b64b7"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8888), 61 },
                    { new Guid("9c5692bc-6ae0-44e3-931c-e8183dc7f5b9"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9147), 34 },
                    { new Guid("9cc67266-1ec8-45c3-bbc1-da4a5d36bac8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9280), 37 },
                    { new Guid("9ce8b2a7-d12b-440c-bf80-017e9707aba1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9264), 49 },
                    { new Guid("9d375fb9-bf48-440e-925a-a583a87ae56a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8863), 51 },
                    { new Guid("9d948c40-1424-4451-9c6d-64c77bd94d45"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8383), 85 },
                    { new Guid("9d9aadd3-4139-4cba-bcd8-5795c8c5a2d8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8924), 88 },
                    { new Guid("9dad03e1-972c-47c7-8866-1387dd02f296"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8468), 66 },
                    { new Guid("9e3c2727-426a-4223-b85a-b2dd6ac59cb9"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8695), 81 },
                    { new Guid("9f305f26-a420-49d7-a91c-9cb17fdab3d3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9041), 58 },
                    { new Guid("9f690473-50dc-4ef0-9bcc-bfe78275785f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9000), 32 },
                    { new Guid("9f88932c-2e08-44cb-84f5-d8d1487d67fc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9090), 64 },
                    { new Guid("9fdecb44-94d6-4421-be4b-1822cbb915d3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8883), 23 },
                    { new Guid("a0785db4-25c4-4b91-9607-70ce0b3be90b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8747), 22 },
                    { new Guid("a0a37579-6898-4d99-a827-6b5fc13f8c43"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8948), 62 },
                    { new Guid("a230a936-f388-45b3-90b9-94db6372871c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8382), 43 },
                    { new Guid("a2539452-224c-4bd8-a4e7-1da30cab6175"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8350), 94 },
                    { new Guid("a27c1481-9474-4085-abf8-5cbe9ee22868"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8590), 91 },
                    { new Guid("a2e629c4-ed4d-4c9c-b98f-15f495a7b3d3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9126), 63 },
                    { new Guid("a306eaa0-eed3-467e-b3a1-bf2842b7d69f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8338), 98 },
                    { new Guid("a38ce262-9084-412d-a37c-16887c9dd9bd"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8522), 23 },
                    { new Guid("a3a3eae8-522e-403d-be8d-2209ace66771"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8465), 90 },
                    { new Guid("a43ad412-a284-4b32-b388-32c19c22e575"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8878), 70 },
                    { new Guid("a4703a6e-f0f4-44f4-97b8-6be472a80f12"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8717), 97 },
                    { new Guid("a4813b16-0999-4680-94c6-54ae5ac1fb4a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8902), 42 },
                    { new Guid("a48200b6-9608-4c09-bb35-84c93a052100"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9301), 26 },
                    { new Guid("a4deb141-c015-4920-be53-293399e1023e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8430), 58 },
                    { new Guid("a4e7b52a-032e-48f0-9478-bd0c227fa90b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8761), 39 },
                    { new Guid("a5f738ff-d2de-4163-8f21-21c678aff0b1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8689), 26 },
                    { new Guid("a60c0854-e876-43e5-b4cf-42dab20e5d75"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8418), 97 },
                    { new Guid("a685f2d6-ea7c-413e-8098-ea4e033ab731"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9077), 26 },
                    { new Guid("a709eb67-1197-4531-bfac-233187880795"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8757), 29 },
                    { new Guid("a80f48b0-306f-4b96-94be-577fad968de6"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8977), 96 },
                    { new Guid("a8167c4c-b6ec-46db-9ef4-e0f0612dd984"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8483), 91 },
                    { new Guid("a8e510ea-cc45-4e08-be3c-69c4544d7cd2"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9187), 25 },
                    { new Guid("a907003c-f083-4d47-a91c-681c964c448e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8705), 36 },
                    { new Guid("a9789309-e686-4ce8-9302-81ac9591a2b0"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8466), 98 },
                    { new Guid("a9bfd6c3-4e12-4fef-b231-36ff1f7a7d74"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9211), 68 },
                    { new Guid("aa3533ed-42b9-4f8f-b4f8-f0709d2fd4bd"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8698), 83 },
                    { new Guid("aa671f8f-1cd6-4986-98b3-7ebf89658c4d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8489), 80 },
                    { new Guid("aa8d2d40-16a1-4f4e-903e-0e52b375cd5b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8515), 53 },
                    { new Guid("aaf8e0dc-95fe-40f2-9389-917d0ee4ddd2"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9064), 75 },
                    { new Guid("abdac00f-b749-4eec-9947-3b76b93f0f1f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8424), 79 },
                    { new Guid("ad3a969f-c355-4490-8bda-ee2a7487fa3a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8379), 58 },
                    { new Guid("ae034700-9a0f-4eae-8215-7b7630491fac"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8592), 93 },
                    { new Guid("ae499b6f-bba2-4809-884f-5697f4d5b92c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9086), 34 },
                    { new Guid("ae6cce94-38e0-4dec-b16d-766c913591e0"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9218), 41 },
                    { new Guid("af1f63f8-6033-43f2-a331-62325e0862f3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8845), 25 },
                    { new Guid("af29b9bf-99f6-437c-b164-23c8fb3ade77"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9176), 99 },
                    { new Guid("af697930-24af-42d7-b265-8061787ee698"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8481), 76 },
                    { new Guid("af6a5e55-d020-40c8-9720-9930f00cd938"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8404), 52 },
                    { new Guid("af6ace11-f85c-457a-a3ba-b59f4fe2e524"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8362), 37 },
                    { new Guid("af82921d-276c-4440-8128-6ad5c4d46a19"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9183), 34 },
                    { new Guid("af9af53c-4142-4fae-a9f2-301108d4203d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9196), 80 },
                    { new Guid("afd4d3b9-7010-4a47-a755-a0663cca8241"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8524), 44 },
                    { new Guid("b017076b-fea2-49a9-ac46-72920bc4a41e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8866), 82 },
                    { new Guid("b03c7f83-a679-40b9-a2e2-df3d8a11d66a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9067), 83 },
                    { new Guid("b040bd6a-de02-4e65-b094-ab6eb478c7ca"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8922), 99 },
                    { new Guid("b0a65814-9f80-434c-9541-59ef4faa2220"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8497), 36 },
                    { new Guid("b0d981a7-658c-4887-b6a9-ebfd58a8dea1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8881), 28 },
                    { new Guid("b0f52e64-eefe-4ef1-a99f-ba3775965517"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8341), 87 },
                    { new Guid("b0fb7989-1371-429d-bb4b-6c15d5e4cc41"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9080), 66 },
                    { new Guid("b1023bbc-afcb-49ef-96f5-82db2a3471c9"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9109), 43 },
                    { new Guid("b112cfb0-8d6e-4649-94b1-086275ef2dc6"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8632), 71 },
                    { new Guid("b1220bd7-c4e3-4229-bd8a-09ff5a54868a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9248), 93 },
                    { new Guid("b25ba375-59f9-4203-ba27-2cbe5fa34e84"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9260), 75 },
                    { new Guid("b268d47c-c217-447d-b6c2-2dad935bb6de"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8405), 96 },
                    { new Guid("b292893a-fc37-48d7-9549-2bae49aa0f2b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8458), 60 },
                    { new Guid("b32d92ca-6d93-4afb-a4dc-444dcb9a8f33"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8754), 76 },
                    { new Guid("b3772223-cd1b-44fd-8bc9-19aa251f0fc0"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8833), 51 },
                    { new Guid("b553aa04-5548-4940-bc75-fa404ebdc6fe"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8612), 77 },
                    { new Guid("b5ac6733-fe44-4428-ae4f-33ecbcf2db76"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8616), 68 },
                    { new Guid("b61a9366-ccdd-4182-888a-66c6deec5a3b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8495), 20 },
                    { new Guid("b64012da-7028-4daa-901e-ddcc5d212b85"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8611), 35 },
                    { new Guid("b673b8c4-a7a8-4c51-b418-3b1f3df5bb2f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9069), 50 },
                    { new Guid("b6e93af3-8bf2-4453-a6a7-fdacbe224a58"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9167), 35 },
                    { new Guid("b6fe9ca5-4d30-45e0-9c20-65437fceb02a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8968), 68 },
                    { new Guid("b7138c3a-b6cb-43c1-8007-49ad665d16d6"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8553), 92 },
                    { new Guid("b74400fc-339a-4b4d-bfcb-bb96b7ad2760"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8914), 86 },
                    { new Guid("b77c6df5-d857-48c3-a27e-b09e5436acf9"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8905), 99 },
                    { new Guid("b7c68664-feea-41ed-bc1e-5b129e2b2e6e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8979), 41 },
                    { new Guid("b7ce6e7e-3ea0-4fd2-b099-b0586d77f787"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9246), 46 },
                    { new Guid("b85460dd-4116-4e02-99cd-55ee6ab17bf3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9032), 81 },
                    { new Guid("b87861d5-9735-4d7b-bf94-1d215b32dfd1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9247), 20 },
                    { new Guid("b8ac2927-261b-4c0b-8d91-2f906fe6e694"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8750), 99 },
                    { new Guid("b8dedfef-5b91-442b-be77-142bb210ed62"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9222), 86 },
                    { new Guid("b90b67a8-8875-4965-8898-4fc69c0fdf48"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9297), 39 },
                    { new Guid("b922b604-9956-4cdd-984c-aa65d11ff2ea"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9234), 58 },
                    { new Guid("b9478b04-3209-4593-b228-0816ae358d1c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8933), 24 },
                    { new Guid("baa28777-336d-45d7-828d-2bb715c78600"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8381), 81 },
                    { new Guid("bab38cc9-688b-4645-874e-6f8b3e0713f3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8586), 53 },
                    { new Guid("bad3bf91-68c3-44f2-8847-d1302bc2233d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8696), 88 },
                    { new Guid("bb491715-fe53-46e4-b73f-b2b9f78e8513"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8421), 24 },
                    { new Guid("bb64dfcb-d7f1-4eb4-8ab7-a727ca1d5f42"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8874), 36 },
                    { new Guid("bcaf1c1c-d2d0-4334-b79e-387a01ae10cc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8824), 52 },
                    { new Guid("bccc6653-bbd4-42f6-9fed-059fd9a1adc8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9008), 42 },
                    { new Guid("bd4fd617-fd10-46ad-9997-ada59663fcc2"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9170), 26 },
                    { new Guid("be321b68-649c-46f1-a3ed-b72453324f19"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9021), 56 },
                    { new Guid("be795eb0-7fc3-4c51-83f6-8fd6bce3b75c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8900), 59 },
                    { new Guid("beb43c03-1f7e-40e8-9705-16c5759ec73d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8446), 72 },
                    { new Guid("c092c24c-f5b2-49f5-8f30-2645b0854dea"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8785), 92 },
                    { new Guid("c153b9dd-bc0d-4f0f-80d3-9b7c9583cf1f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8365), 67 },
                    { new Guid("c1db353e-9990-4c91-84db-78db4756f04c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9159), 41 },
                    { new Guid("c237eda1-5b0b-4305-9771-f0c4bd1d7bd3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8671), 82 },
                    { new Guid("c27cd15b-3a86-44d0-938f-9cad123ba1e4"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8714), 98 },
                    { new Guid("c2a20391-45d3-41b0-a814-aa4405d3c8ca"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9107), 40 },
                    { new Guid("c2c12eb4-72d6-4c45-a6af-bda58bc41219"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9151), 81 },
                    { new Guid("c2cdd85a-48e9-4c36-a9fa-be75ca5dce22"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8503), 30 },
                    { new Guid("c2d39466-4b62-4a9f-a41e-4979bb5f4bbc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8738), 55 },
                    { new Guid("c3154148-06bb-4681-b7a1-e449e054d2ff"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8982), 21 },
                    { new Guid("c424fcdb-ceed-437d-b0ad-14ce60884c7e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9235), 96 },
                    { new Guid("c4560109-a2fb-45e6-84b3-db5390f35068"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8812), 84 },
                    { new Guid("c50343d5-69a2-482c-a95f-2a4128797d92"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9042), 86 },
                    { new Guid("c52e10be-9db6-4887-8dea-d93422f23141"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8349), 70 },
                    { new Guid("c56894a9-d240-4e17-ab59-7c4a5ede941b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8387), 36 },
                    { new Guid("c5dc7bf3-f42a-4829-9706-cbcf16b56124"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8782), 34 },
                    { new Guid("c5f009ad-aba7-46f9-a520-715daa03d3cf"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8706), 68 },
                    { new Guid("c61ee531-ed89-4c91-820b-3781ed64a8cf"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8630), 62 },
                    { new Guid("c662baef-5c03-4b49-8213-4bbd478e4632"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9115), 94 },
                    { new Guid("c67d25d9-05c1-48b6-9988-9982b45fcc15"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9025), 90 },
                    { new Guid("c6b43a97-74af-451f-9062-43d204919518"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9252), 72 },
                    { new Guid("c7003f12-7aa4-4113-a90f-db8cd7f09787"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8510), 20 },
                    { new Guid("c74f8d73-4d40-47b3-b5d3-8ee441392698"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8507), 79 },
                    { new Guid("c770634c-3582-4c08-8807-d0721a70727b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8935), 49 },
                    { new Guid("c778b816-0ee1-4274-b451-f1ea3ec74e0d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8964), 67 },
                    { new Guid("c7bd7346-2ac6-4676-a367-33d754c9be20"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9124), 23 },
                    { new Guid("c841549f-5b98-486b-b895-ef008946572d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8970), 20 },
                    { new Guid("c8ea4ca0-bc53-496c-ae99-69693204cbce"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9195), 76 },
                    { new Guid("c9101b6f-7f15-4128-9140-7da8a52e4a15"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8407), 20 },
                    { new Guid("c91fcc68-47f5-4235-b73c-6366ef9c7703"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8624), 35 },
                    { new Guid("c984862c-8e1c-41e3-9777-9e4ed2ae1936"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8926), 80 },
                    { new Guid("c9a2590e-d353-40db-b6f0-7f38406674ff"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8354), 85 },
                    { new Guid("c9ec2940-69ad-45d8-8106-6a3f9398f785"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9161), 59 },
                    { new Guid("cb0c03c2-a537-4a5a-8389-81990bac8aea"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8849), 56 },
                    { new Guid("cb2562d5-62a0-4e96-afe6-d255b6865404"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8810), 75 },
                    { new Guid("cb4ef7bf-0d8d-4ccc-8382-247bfb9599b3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8727), 70 },
                    { new Guid("cb676ab1-c818-42e2-bb9d-50e8d7018a2f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9142), 44 },
                    { new Guid("cbc9d123-da64-49fa-826b-82f91d439e28"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8498), 23 },
                    { new Guid("cc145714-652c-4c9f-8691-ac5e0a4dd8e4"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9193), 25 },
                    { new Guid("cce6ff6e-a8e2-4440-b415-187816e76418"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8679), 72 },
                    { new Guid("cd5ef3e0-6ccf-4ddd-b0ce-3a1c66ba30b2"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8347), 38 },
                    { new Guid("cd6d6cd9-8974-43aa-9edc-7546a5efbb40"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8563), 70 },
                    { new Guid("cdb4533a-a12e-40ac-9302-3b386181714e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9261), 20 },
                    { new Guid("cdcff7a8-386c-4fb1-bcb6-42ad2f6b0352"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9249), 78 },
                    { new Guid("ce0db9ad-170b-42e2-a005-d7832cd780a2"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9266), 53 },
                    { new Guid("ce1dbcc5-b633-4463-a0a7-3b78febf840a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8818), 33 },
                    { new Guid("ce35bf27-b54c-4eb3-a1fe-73ca47f67373"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9110), 38 },
                    { new Guid("cead35fb-05f4-4f65-b20b-1b7f6f811fa3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8476), 78 },
                    { new Guid("cf02376e-f6ae-4256-acdd-abe4cfc3e85a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9286), 98 },
                    { new Guid("cf1b8865-3f11-48fd-ae10-880fd6b0afb3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8667), 56 },
                    { new Guid("cf6a4888-b20a-4ce3-9170-6c031ba19876"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9213), 41 },
                    { new Guid("cfa91fb9-efbb-4f97-bb93-85adea3bf408"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8945), 45 },
                    { new Guid("cfe778ab-792c-4bd2-b5c5-fc92a36a4dfa"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8422), 57 },
                    { new Guid("cffc85c2-8805-435f-aa26-565150c06ae6"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8609), 41 },
                    { new Guid("d0768315-b3a2-4f99-b53a-6724d67d1056"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9223), 77 },
                    { new Guid("d0bf0fd9-afbc-4d16-816c-25eda38d4840"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8533), 65 },
                    { new Guid("d0fc6701-13b4-4a97-8968-cb9f59ba86c0"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8752), 37 },
                    { new Guid("d10269d1-d187-4de8-aa3e-1a40a840018b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8635), 54 },
                    { new Guid("d18ff709-4da6-4584-b4eb-53731b0ec252"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9263), 69 },
                    { new Guid("d198e8fb-038b-48d9-8960-388e884c63fc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8839), 74 },
                    { new Guid("d1d096e3-1228-4665-8a7d-4cf9def7de21"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9143), 23 },
                    { new Guid("d1d48b20-6eb4-45a1-80f2-20dc9cb544ec"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9163), 81 },
                    { new Guid("d1df78e0-df74-4578-bf06-d7d8236aec78"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8719), 42 },
                    { new Guid("d2739595-daca-4476-8a31-80ab131e2cdc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9014), 71 },
                    { new Guid("d2899dcd-ce1b-49a2-bab2-54d4237790e6"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8939), 76 },
                    { new Guid("d33974c7-298e-4b64-b991-468df2db5eeb"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8758), 64 },
                    { new Guid("d55da138-ee04-4e5d-949a-33b087fd41e1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8615), 46 },
                    { new Guid("d569557f-8348-4832-9ea2-4648699b175c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8535), 33 },
                    { new Guid("d5895727-6b5d-49a9-96bd-0b03bb25783f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9001), 61 },
                    { new Guid("d5dc90ec-8a30-4cef-9b29-4b88505a48d3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8936), 45 },
                    { new Guid("d60bb0cf-6143-4f26-a8f6-77945ce796f3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8865), 46 },
                    { new Guid("d6575162-31cd-4d83-bf2d-7564a5b757c4"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8980), 95 },
                    { new Guid("d6a2edfd-ba81-45bd-ac1b-330de472df92"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8663), 47 },
                    { new Guid("d703b60e-bdad-42fc-a98a-6479c9d361c4"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8482), 37 },
                    { new Guid("d737f891-1474-4536-ae72-b86cf2ead06d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9192), 65 },
                    { new Guid("d7ac040f-56f1-4cdd-93ec-6d49f1b73fa2"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9058), 72 },
                    { new Guid("d847ec00-9250-4590-9ad4-fc696f7112f1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8508), 73 },
                    { new Guid("d84b3983-1ba4-4dbc-a7f5-300cecef0305"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8906), 52 },
                    { new Guid("d87f662c-5009-40c8-9ecb-a735b80e2693"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8861), 20 },
                    { new Guid("d96ac16b-9f1d-472b-8321-de15cc856fb2"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8633), 73 },
                    { new Guid("d99f903e-1c42-428c-a466-0dc93b75b678"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9036), 65 },
                    { new Guid("d9a0ba7f-9886-4c93-963d-545c0223c840"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9299), 53 },
                    { new Guid("d9f4fc72-6bde-47a2-a6c8-1acfafef02d8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8873), 75 },
                    { new Guid("da7d0ad7-1eaf-482e-be68-8f46d401f462"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9292), 48 },
                    { new Guid("da806d7d-d002-4abd-bbd9-9ce9217e0e18"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8475), 95 },
                    { new Guid("dabd50bb-c5ba-4a15-8644-0fad9db2868f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9155), 21 },
                    { new Guid("dadf814b-fea0-4105-b4b5-1a67778c03bb"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9049), 77 },
                    { new Guid("daf703a3-971b-44af-94e1-b6b2f30a1112"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8702), 29 },
                    { new Guid("db6b0f86-721d-41a8-9611-fda36e354bfb"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8385), 48 },
                    { new Guid("db78430f-5915-4535-81e0-db8aedf16dcf"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8992), 50 },
                    { new Guid("db8f2344-18c0-4679-b37d-e76f9b582476"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8669), 73 },
                    { new Guid("dbe74aa4-f40c-4672-adff-10e509f5d291"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8743), 64 },
                    { new Guid("dc148a5e-09f6-4da3-b42f-9bcfe4180ea8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8469), 41 },
                    { new Guid("dc38ff96-cb02-4922-9150-d334ba914f1a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9128), 84 },
                    { new Guid("dc4ad6e4-21c1-4345-b9e8-88cd2c0b2e10"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9228), 64 },
                    { new Guid("dc68bca6-c158-4797-bac4-395afc1f7734"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9045), 90 },
                    { new Guid("de05f483-47d4-4968-8932-75f5a6e8081d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8895), 32 },
                    { new Guid("de5c8fed-65e8-4e0c-a648-97bff8ab5bb2"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9105), 61 },
                    { new Guid("deb9882b-ba9c-4b2e-9e45-74d60c2429ee"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8682), 93 },
                    { new Guid("decf7b38-63e6-4797-b671-e945680e1b56"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8686), 87 },
                    { new Guid("df0685a8-d181-4304-97a1-549b4ef2f4c4"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8748), 59 },
                    { new Guid("df06c05e-086f-4da1-ba04-c6cbfe91c410"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8880), 40 },
                    { new Guid("df793dc0-e055-4474-8c7a-7a001e7d41ec"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9095), 38 },
                    { new Guid("df796946-2178-4b5b-bdef-73c2acbe8750"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8637), 33 },
                    { new Guid("dfabafc9-a762-4715-832f-fb06aecd3e6e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8587), 85 },
                    { new Guid("e0527b13-9dea-4712-889d-3df8eae89ec3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9030), 26 },
                    { new Guid("e097a0ec-7141-479a-940e-b3f0bcd33698"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8872), 43 },
                    { new Guid("e0da8e0b-8ca9-40cd-9eb8-4111071d55a6"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8709), 40 },
                    { new Guid("e0f056e8-84ce-43ac-9085-660ab61d2919"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8585), 86 },
                    { new Guid("e111804b-ccf2-4273-8e0b-9d7bd3c3a0f8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8708), 64 },
                    { new Guid("e1d2ff9c-e377-4607-a1b5-67ee57c6b6a7"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8610), 40 },
                    { new Guid("e25f9f21-9299-4a70-bf2e-e8e8540cc574"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9206), 47 },
                    { new Guid("e2657182-250a-4f4c-8820-3b4550ab66b1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8721), 82 },
                    { new Guid("e29da077-8da0-4f02-8f9b-d7f81243a636"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8703), 22 },
                    { new Guid("e2c3a774-cc2f-482a-b416-de7ec5a2a2ed"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8894), 23 },
                    { new Guid("e2c48197-102e-4092-b62a-424d30be9641"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8629), 82 },
                    { new Guid("e30a61e1-df46-4508-9062-84b0eb97d108"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8639), 85 },
                    { new Guid("e3841cbf-98f4-49cc-b769-14d1924473cc"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8360), 56 },
                    { new Guid("e3bbc8a9-0fd2-4d79-b4a7-2190d0d1a56c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8580), 95 },
                    { new Guid("e3cf38a6-1e75-4eb0-a179-519d21537502"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8949), 66 },
                    { new Guid("e3cf5204-e360-4edc-a160-b84955597c8a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8438), 55 },
                    { new Guid("e449dfe0-44de-4cde-b551-b18753e45398"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8832), 48 },
                    { new Guid("e457b3f7-15a8-44c0-ae33-335761374633"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8745), 70 },
                    { new Guid("e536dd9b-0bff-4554-abf6-994c86129720"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9079), 45 },
                    { new Guid("e557de30-ba81-4381-96ee-3e66897fab90"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8830), 62 },
                    { new Guid("e5bb66a2-e9a2-4f36-9186-784e5e5a51bd"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9233), 97 },
                    { new Guid("e68ceae4-72c6-40c5-acc9-cd6ac7a72930"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8346), 96 },
                    { new Guid("e6a37d8d-c736-48b5-8702-4b5037b4a480"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8545), 84 },
                    { new Guid("e6a7c7bc-ee7c-443b-a5b4-7b33ec9e496b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8591), 42 },
                    { new Guid("e6e9ad87-83cd-4534-a5b3-71ab5cb1210d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9120), 42 },
                    { new Guid("e76590b9-c8fd-4479-852d-380961805eac"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8989), 63 },
                    { new Guid("e7f1befd-b6a5-4819-94f2-15aed7d9244c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9141), 82 },
                    { new Guid("e81050dd-09b0-4e3c-bfcf-0e6b9b144396"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9240), 33 },
                    { new Guid("e8c70edb-6226-403d-9a37-845a04aa89f2"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9162), 39 },
                    { new Guid("e8f11558-6afb-4226-ad1e-03e3cf24d5d5"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8335), 70 },
                    { new Guid("e97f1d63-28c7-4c95-ae39-b7ded33d199d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8658), 38 },
                    { new Guid("ea41b92f-ba1c-4811-8e96-1e6d564c7be5"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8564), 89 },
                    { new Guid("ea49d7c3-6458-4279-a0bd-974a2ddf3d47"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8426), 57 },
                    { new Guid("ea7f8a8c-3480-4d27-828d-5667b90dd369"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8907), 67 },
                    { new Guid("ea80c437-9fce-4e85-a2db-b085508315c5"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8485), 39 },
                    { new Guid("ea976fb2-a623-44b4-9780-7e1c8c058f41"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9009), 80 },
                    { new Guid("eabd13a8-c68d-4652-885f-2a9d0d137ae8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8512), 88 },
                    { new Guid("eaf9cebf-d033-4136-8c62-702b143f3bb1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8439), 79 },
                    { new Guid("eb6f5ab0-8b91-4cb3-8360-6d38b03bafed"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8776), 25 },
                    { new Guid("eb8a51d5-730e-4995-a5f3-0368c73e1059"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9103), 40 },
                    { new Guid("ec04c1c1-7889-41a3-af68-a83cfd602a16"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9002), 79 },
                    { new Guid("ec0a7049-370a-481c-980d-6d28fcff900e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8340), 94 },
                    { new Guid("ec1c4579-2f62-4aa8-96b9-4ee2648f0978"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8819), 37 },
                    { new Guid("ec8bb265-926d-477a-a8cb-5a45d5a20321"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8462), 21 },
                    { new Guid("ed7fa6b5-1602-4374-889d-a73195f1a1cb"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9011), 85 },
                    { new Guid("ee143bde-d281-4600-8596-c677f43e543c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9057), 47 },
                    { new Guid("ee9603f3-45ae-4cd0-bf58-93e8b50151ff"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8808), 31 },
                    { new Guid("eeb96a70-7c4d-4bd7-84b4-8bfad270b6ee"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9037), 43 },
                    { new Guid("eed55e3e-a025-48fc-ac1b-d37b54fe6a0b"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9225), 91 },
                    { new Guid("ef333ad7-b777-4213-837d-29ad2a156557"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9168), 97 },
                    { new Guid("ef376e7c-1786-4f6a-9cd0-a446b0c79833"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8542), 34 },
                    { new Guid("efbfd072-a3ae-4599-9ab9-cb9a12ca05a5"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9230), 30 },
                    { new Guid("efbfe141-63a3-42ec-b045-46737a9e5530"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8626), 30 },
                    { new Guid("f0fa9de1-f298-4c5e-9194-d4b515ecb474"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8884), 97 },
                    { new Guid("f111cc78-ea04-423d-86c4-f3ceb1fc4333"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8496), 51 },
                    { new Guid("f14e51ba-4187-4ab1-af28-7544c6221722"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9182), 75 },
                    { new Guid("f20a8f32-b55a-42c1-b910-df6d70b3d907"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8420), 48 },
                    { new Guid("f215ac4b-115d-46fb-a29c-b747fef93093"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8722), 58 },
                    { new Guid("f2aa416a-04bb-4032-ae56-4663be8132b9"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8500), 37 },
                    { new Guid("f2c64348-1eed-4ee8-ae51-8221ed689c65"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8625), 86 },
                    { new Guid("f3041f97-7a7c-4a5a-addb-5424c61f4524"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9200), 82 },
                    { new Guid("f32fae3f-250c-448a-8381-2a1a9821753d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8487), 73 },
                    { new Guid("f34b0bb2-08f0-46fd-8cd7-d75b9e52707e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8909), 39 },
                    { new Guid("f3706ae2-7c06-41cf-bec3-932a95d42a56"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8962), 56 },
                    { new Guid("f3d3ff0d-575b-4b60-9d2d-ac0054e00cc2"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8396), 66 },
                    { new Guid("f3e1bee9-dba0-4ca7-a042-f3eafd440a61"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8923), 56 },
                    { new Guid("f3f07d8c-d84c-43f3-9c82-32bf716b3056"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9117), 62 },
                    { new Guid("f3f3b204-69ee-4c95-af9d-a9b906ebf45a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8343), 35 },
                    { new Guid("f46ffc50-71e2-4cde-80f3-37dd53d0c460"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8764), 76 },
                    { new Guid("f48aad48-78b5-40f9-beba-f52cf58d4d1a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8676), 27 },
                    { new Guid("f4ca23e3-5669-44e0-a359-285c484e132c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9098), 57 },
                    { new Guid("f568a29b-f847-4aee-bdb8-4435a72092fb"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8432), 92 },
                    { new Guid("f5b37d69-2d80-4658-bb73-35b784a85562"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8634), 28 },
                    { new Guid("f6325010-0ca0-4710-b85b-53e8d07880b5"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8718), 34 },
                    { new Guid("f662bce6-53b9-4438-b06c-1eee202741e5"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8571), 74 },
                    { new Guid("f697e2d9-4ee2-42bb-9168-2221de2f1889"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8870), 23 },
                    { new Guid("f6ba0e1a-48b3-44e1-a0ce-681d3846b931"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8842), 58 },
                    { new Guid("f734ec56-69df-46fd-a573-b35d1711b27c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8565), 54 },
                    { new Guid("f74b0253-c850-4473-9303-ca06a46f8850"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9278), 24 },
                    { new Guid("f78e8e07-4c5b-4249-9d67-fa0de298d244"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9217), 71 },
                    { new Guid("f7c804e0-400a-45b3-b74e-46407d784a58"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9040), 98 },
                    { new Guid("f86d1537-5dd6-48b6-b02e-a0561ba4c2f8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8857), 50 },
                    { new Guid("f883eb5a-e31e-4c76-8af1-9bdb44719d76"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9018), 48 },
                    { new Guid("f9019781-28a3-46c1-abde-0bddbca0f621"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8704), 49 },
                    { new Guid("f9c49974-1bb5-417c-93c1-4bae96c3752a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8566), 42 },
                    { new Guid("f9c84011-0390-419b-895a-54055439870c"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8925), 78 },
                    { new Guid("fa06fe7c-5db0-4e58-8224-cdfbda9b6970"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9004), 29 },
                    { new Guid("fa2819aa-0057-4898-b5e0-872d9533c4fb"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8919), 41 },
                    { new Guid("fa568644-7c4f-4190-b10f-df5aa0aad687"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8561), 86 },
                    { new Guid("fa78145c-ec40-4d3f-903c-8384d8504ee8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8556), 70 },
                    { new Guid("faa0e9ae-bfa9-475a-b46e-48f5950814f0"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8368), 33 },
                    { new Guid("fad1dce5-2e3f-42e1-a7ce-b7247515b13f"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8605), 91 },
                    { new Guid("fae8d870-9337-41f9-843c-2e8b9a4a9977"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9101), 80 },
                    { new Guid("fb7c77fc-e655-435a-9b81-23dc724325d6"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9113), 81 },
                    { new Guid("fc0d7606-30d9-46f5-a68b-f75598d97d79"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9197), 92 },
                    { new Guid("fc4d1bb6-9c36-4730-8282-56e4b83a5bf3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8428), 34 },
                    { new Guid("fc89ec55-4876-426e-bb36-da3546fd4c4a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8677), 81 },
                    { new Guid("fccf0bc9-4a5c-4756-b4bc-00ba43adec69"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8477), 72 },
                    { new Guid("fcdda56b-4deb-49f2-a63e-6fb2dcf373f5"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9012), 52 },
                    { new Guid("fcf0829c-0942-44da-9aab-478b062de1e8"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9092), 58 },
                    { new Guid("fde48cb5-bec3-4c6f-8da3-ff1d339c3c26"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8372), 74 },
                    { new Guid("fe3677f7-3b30-4093-8d48-8528b323a7a1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8551), 37 },
                    { new Guid("fe3e0ea2-adc2-485c-9c4f-3787a2104f82"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8868), 90 },
                    { new Guid("fe6abe3c-40e1-4a9b-8b91-8bd06424f43e"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8375), 78 },
                    { new Guid("feafa967-8951-4d74-bc69-09a50bda0086"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9029), 92 },
                    { new Guid("febef462-b213-46ee-8cb1-82331504981d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8641), 31 },
                    { new Guid("fec4b6f1-1229-49b9-a167-8e833da000e1"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8784), 40 },
                    { new Guid("ff2734e3-09c6-430d-a3b7-62f613c39938"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8775), 45 },
                    { new Guid("ff29028e-8dce-4a6a-8cd7-d515e71d3ed3"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8536), 25 },
                    { new Guid("ff7004d1-16da-47db-9d7a-b3d87e5352cb"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8899), 23 },
                    { new Guid("ff813288-475e-4130-a00c-cdc5b8ded99a"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9177), 71 },
                    { new Guid("ff832679-d1ad-497c-95f4-7382deaca109"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8882), 85 },
                    { new Guid("ffa5bf5c-de1b-4b70-8144-c6dfa08aff8d"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8453), 60 },
                    { new Guid("ffc0c821-f942-4d57-ba4f-7a0f4c5762fe"), new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(8461), 30 }
                });

            migrationBuilder.InsertData(
                table: "PromotionCodes",
                columns: new[] { "Id", "Description", "DiscountRate", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, "Enjoy the holiday spirit with MANERO! Use the code MANEROXMAS25 at checkout to get a holly-jolly 25% discount on your festive purchases.Happy shopping and Merry Christmas!", 0.25m, new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "MANEROXMAS25", new DateTime(2024, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Welcome to MANERO! As a new customer, use the code MANERONEW at checkout to enjoy a special 15% discount on your first purchase. We're thrilled to have you with us. Happy shopping!", 0.15m, new DateTime(2024, 2, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9676), "MANERONEW", new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9675) }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "PromotionId", "Description", "DiscountRate", "EndDate", "Name", "StartDate" },
                values: new object[] { 1, "Manero's best sale yet!", 0.10m, new DateTime(2024, 2, 10, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9514), "Autumn Sale", new DateTime(2024, 1, 11, 0, 21, 35, 745, DateTimeKind.Local).AddTicks(9513) });

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
                columns: new[] { "ProductId", "ColorId", "IsBestSeller", "IsFeaturedProduct", "ProductDescription", "ProductName", "ProductPrice", "PromotionId", "Quantity", "Rating", "SizeId", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("00335b7b-b571-40c6-8357-b9d308ef4b4e"), 3, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 2, 2, 6 },
                    { new Guid("00a1553a-dffe-4751-9f17-bfea73d256dc"), 5, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 2, 4, 6 },
                    { new Guid("01a035a3-d493-4480-bdb7-d69358423139"), 6, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 2, 2, 1 },
                    { new Guid("02485097-bbb3-4391-a901-04a990f640d1"), 5, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 4, 5, 6 },
                    { new Guid("03a5a86c-e799-464a-908e-213275f8c1a6"), 1, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 1, 5, 5 },
                    { new Guid("04bcc056-3631-455d-9b2f-d92684a0bfff"), 5, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 0, 6, 1 },
                    { new Guid("0510bf8c-5936-4d03-b50a-4bd7875948d7"), 3, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 1, 4, 1 },
                    { new Guid("0648a6ac-263e-4d8c-940e-e72ef23a9c26"), 5, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 3, 4, 7 },
                    { new Guid("0679f864-4788-4670-aa82-a613ddd59d99"), 5, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 3, 5, 7 },
                    { new Guid("0693cdeb-5989-4654-935e-de18f775b828"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 3, 4, 13 },
                    { new Guid("07849e8b-431b-4d24-9d87-3a30d42eb10a"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 1, 5, 1 },
                    { new Guid("07af6686-3102-4362-b932-6fe174059136"), 2, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 4, 2, 13 },
                    { new Guid("07f150e1-7de4-4c33-806f-c3eb3ab2a601"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 2, 5, 1 },
                    { new Guid("086a7eb4-a9ce-4928-8ea6-2fdcbf56ac2e"), 6, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 1, 6, 14 },
                    { new Guid("08e2d35d-c9bf-4979-8b82-4726e0827b78"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 2, 2, 13 },
                    { new Guid("0904a5fc-71ee-4e64-b73a-c400025896cb"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 3, 2, 7 },
                    { new Guid("092878b0-79cd-493a-b930-3a3a8325a2ce"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 3, 1, 13 },
                    { new Guid("0930e51c-bece-4769-92ee-4a707313fa6a"), 3, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 0, 3, 6 },
                    { new Guid("0a9bbd60-0814-479f-a234-979e7ebda937"), 5, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 2, 3, 7 },
                    { new Guid("0ad38ad0-455a-4639-a173-7d398f358a5f"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 1, 6, 1 },
                    { new Guid("0b3c5151-336d-4ffb-8548-b4e7ae17330a"), 1, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 1, 6, 13 },
                    { new Guid("0b897408-3343-45d1-b6f7-0ca29c10cd6e"), 5, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 3, 3, 13 },
                    { new Guid("0bed5eeb-a48e-4a3f-888b-ced840be0460"), 6, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 1, 4, 6 },
                    { new Guid("0c21b309-693b-4b2f-b453-986f151f9a4f"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 1, 2, 13 },
                    { new Guid("0d23e87c-09f3-41b8-9e96-ca5dc3593c52"), 6, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 4, 4, 5 },
                    { new Guid("0d41888c-2fdf-4d86-b52d-544250ce1d67"), 1, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 4, 3, 5 },
                    { new Guid("0d92fd84-95fb-410c-b6ab-81ad1ffa1543"), 2, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 0, 4, 14 },
                    { new Guid("0e1fbc0e-1c88-43c9-b5c3-8e997a72cffd"), 3, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 1, 2, 5 },
                    { new Guid("0f351724-d988-415c-9b22-f8f0d2df91b6"), 3, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 3, 6, 13 },
                    { new Guid("0f630371-288d-43c4-8a83-fef25d0f208a"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 2, 3, 13 },
                    { new Guid("0f81fe95-74d9-4666-bac3-aee1dd4d9392"), 4, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 4, 5, 14 },
                    { new Guid("0f94fe05-fb78-4597-9a17-ca378c4caa08"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 3, 6, 13 },
                    { new Guid("108eee96-9912-40f6-b9e2-170b400934ec"), 2, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 1, 5, 14 },
                    { new Guid("10d98537-f447-4662-8340-381e20a6c788"), 1, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 2, 5, 13 },
                    { new Guid("11ae315d-74c3-4dbd-b3ca-8b5d207943cb"), 6, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 3, 3, 7 },
                    { new Guid("11ba15ad-c2fe-4337-803b-8ccec09c1d9f"), 4, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 3, 2, 5 },
                    { new Guid("1217a894-0d61-4718-8d59-8234ee0da06e"), 2, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 1, 2, 14 },
                    { new Guid("126ef642-8ed5-4ef9-8713-5e4c51b1c7b8"), 6, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 2, 2, 13 },
                    { new Guid("1298095f-312c-4ed5-b1fe-1dc29e8ae2bc"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 2, 6, 13 },
                    { new Guid("132f05f1-6862-4c52-935c-02a2a8c7b4d1"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 4, 5, 13 },
                    { new Guid("13aea49a-a6de-471a-82c3-849026de8125"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 4, 2, 7 },
                    { new Guid("13eb96df-779e-4b51-acbd-14fc2da9d6f1"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 1, 2, 13 },
                    { new Guid("140e92fb-5959-429f-9153-c3b0f667152b"), 2, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 1, 2, 6 },
                    { new Guid("144d7a1e-05b9-494b-a96f-d3b234710e4a"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 2, 2, 13 },
                    { new Guid("153fece0-db09-40d4-bdf0-d9a3f2b1fa13"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 3, 6, 7 },
                    { new Guid("16e2d2b9-ee59-4b36-b367-89f203e72b7a"), 6, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 2, 5, 1 },
                    { new Guid("18873faa-7886-4203-b7d6-407a6119db71"), 2, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 4, 5, 1 },
                    { new Guid("18f970eb-3606-480f-ac2f-e57684bdb6fc"), 2, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 2, 1, 6 },
                    { new Guid("191741f9-6139-44b8-b055-1052692544fb"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 4, 3, 13 },
                    { new Guid("19286193-207c-42a8-b2d8-bfec59d5ad6e"), 4, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 4, 2, 1 },
                    { new Guid("1944edf0-7047-4a72-8c8c-dbacd0c50d76"), 5, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 1, 1, 13 },
                    { new Guid("1b151a58-a2cc-47a5-aeaf-67bdd8ed61ed"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 2, 5, 13 },
                    { new Guid("1cb12184-eef0-4f68-9050-22d4ea78d131"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 4, 5, 13 },
                    { new Guid("1d78a173-8e62-499a-b9c5-3c090b0b3ad0"), 4, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 0, 1, 5 },
                    { new Guid("1dc4bd9b-d9df-47b0-a801-822541490b46"), 5, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 3, 3, 5 },
                    { new Guid("1eade78e-3452-458e-807a-336ca1afd613"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 0, 1, 13 },
                    { new Guid("1eed524f-434e-40a1-86bc-67918a011c78"), 5, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 4, 1, 5 },
                    { new Guid("201cbe3c-c2bf-47f6-a857-045df225b232"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 0, 1, 13 },
                    { new Guid("2056fa9c-85ec-43e5-b38a-202780e537d3"), 5, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 2, 6, 6 },
                    { new Guid("206a6624-b97f-4ef8-8430-98f8cdd978c2"), 3, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 4, 6, 7 },
                    { new Guid("20977c7f-be87-4fc9-a53e-86b33355fba8"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 1, 1, 13 },
                    { new Guid("20b23b8f-4ae5-459b-826c-66b199f576ad"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 3, 1, 7 },
                    { new Guid("2165da0c-e811-4656-bb78-0b6899d7091d"), 2, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 3, 4, 5 },
                    { new Guid("218304ff-ddee-4d75-8347-7ad0195e195b"), 3, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 1, 3, 14 },
                    { new Guid("21f2b78f-415e-4826-9252-3d3065174dc5"), 1, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 4, 4, 6 },
                    { new Guid("21f30fb8-0a2f-4a62-b114-bbdcf85cbe20"), 1, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 4, 3, 13 },
                    { new Guid("21fcdca9-3da0-41a6-93da-c2a03c079e07"), 3, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 1, 1, 5 },
                    { new Guid("22040289-4005-456a-b042-838290866351"), 2, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 3, 3, 14 },
                    { new Guid("232c4ff4-dcfc-439c-91de-b52ceb49d8e3"), 2, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 3, 3, 13 },
                    { new Guid("233edce2-62b5-4335-888c-b54bd4f241fa"), 2, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 0, 6, 1 },
                    { new Guid("23811f46-1579-42f8-b00f-9ce19f204080"), 2, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 4, 5, 13 },
                    { new Guid("23b1b186-effb-461b-b901-3af7f85bab9a"), 6, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 0, 5, 5 },
                    { new Guid("24ae7658-577f-493d-9e1b-b0f6113c3f8a"), 1, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 0, 1, 1 },
                    { new Guid("254d8b1c-d441-4d60-9ec6-eadedf4a3001"), 3, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 3, 2, 1 },
                    { new Guid("26745b67-50ad-40a3-8064-2f38774d943e"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 4, 6, 13 },
                    { new Guid("26e93d96-5427-4f98-8658-2f6f4d0b0225"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 2, 5, 13 },
                    { new Guid("26f687cc-01b1-4eae-b7f8-1b0993844aa4"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 1, 1, 13 },
                    { new Guid("276450e0-60e2-48c3-bfb9-f795e1a659d9"), 2, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 0, 1, 5 },
                    { new Guid("280d55c8-5f87-4f32-a6d4-146468c58c8c"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 3, 3, 7 },
                    { new Guid("2810311c-7c16-4c92-a775-3a41cfc32a84"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 1, 2, 13 },
                    { new Guid("285043b3-3c61-4983-ae80-bc833c81df04"), 4, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 2, 1, 13 },
                    { new Guid("29171ed4-c43c-4e1c-bb77-42070bf33b26"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 4, 1, 7 },
                    { new Guid("29cd426e-1a33-483d-896a-ce82f5ba1a43"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 2, 1, 7 },
                    { new Guid("2a749a74-e448-4031-9272-23f1659eb168"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 4, 1, 1 },
                    { new Guid("2c00a5e0-9ec1-4fcf-983d-c1102618cf4a"), 2, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 3, 2, 5 },
                    { new Guid("2c0589e9-283b-4899-8d2f-6807a39072e8"), 6, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 4, 2, 6 },
                    { new Guid("2cfb6b79-71d7-4cb5-83f0-9c0078fd6e3e"), 1, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 3, 1, 5 },
                    { new Guid("2dc7e3fd-5672-47d6-87a2-98c519e4551f"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 0, 6, 1 },
                    { new Guid("2e1f4e4a-e57a-4b97-8289-61a9e7840370"), 4, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 4, 4, 5 },
                    { new Guid("2e255d49-4c6d-431d-b56f-3fd5d37bc305"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 2, 1, 13 },
                    { new Guid("2e434449-d335-4d5b-9c67-99942d49ea31"), 5, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 0, 1, 7 },
                    { new Guid("2e8438ac-e2ad-412c-b1fc-f7b4da262dbc"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 4, 1, 13 },
                    { new Guid("2f58b9ac-6059-4e7d-9750-ddf5c5840169"), 2, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 3, 3, 5 },
                    { new Guid("30d24adf-3d47-479a-92a6-05326d31c8df"), 6, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 3, 5, 13 },
                    { new Guid("319a39d7-dca7-40eb-86f9-b74f71a1df1b"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 1, 5, 7 },
                    { new Guid("31a1cea6-7842-4b64-adeb-357440911eab"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 0, 3, 13 },
                    { new Guid("32657e44-da22-40c9-97e0-9e405fa09724"), 5, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 1, 1, 5 },
                    { new Guid("32f2b76d-5132-4909-8412-c1c99a252a83"), 2, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 2, 3, 5 },
                    { new Guid("32f2dee3-8554-4afd-8657-5bad8d54af51"), 6, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 3, 6, 5 },
                    { new Guid("33569aab-1a02-4c91-8981-315ee4ccc53d"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 3, 4, 13 },
                    { new Guid("33eb8107-f924-469f-85ff-cb2869f6b2d3"), 3, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 2, 4, 14 },
                    { new Guid("34b7ac91-e92b-4959-b2f7-464ba01ca513"), 3, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 2, 1, 6 },
                    { new Guid("351355cf-9bec-4bfc-9823-87de2857d1a5"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 4, 3, 1 },
                    { new Guid("359c8c7d-30a3-4bd7-ae09-ed36153f276d"), 5, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 0, 2, 5 },
                    { new Guid("371421bc-847c-4e40-92ae-0da252be330f"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 3, 5, 7 },
                    { new Guid("3724af63-6c29-49d8-a61a-133dd6220b9c"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 0, 2, 13 },
                    { new Guid("3832d06d-5e02-4541-b438-61c98ee3fe92"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 3, 5, 1 },
                    { new Guid("3857b649-289f-4b92-8cd2-638e1f340648"), 1, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 2, 4, 5 },
                    { new Guid("385fd591-a529-483e-a7cf-4bbfa5043ea4"), 2, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 4, 1, 1 },
                    { new Guid("386a1bcc-cb7c-4490-88ec-904991487cd0"), 4, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 0, 5, 5 },
                    { new Guid("387ab56a-8cdc-4ffe-8ca8-9eaa88c5e0fa"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 0, 5, 13 },
                    { new Guid("38a851bd-3a8c-4b90-bcc5-f9d51d6876e3"), 6, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 4, 6, 1 },
                    { new Guid("38c0857f-83c0-4d30-aba1-d62f43bbcd92"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 4, 6, 7 },
                    { new Guid("39f4942d-e564-494c-a59a-2570b003c870"), 2, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 2, 5, 5 },
                    { new Guid("3d2d9e16-d29e-43e5-a5d5-e952cce5cbbe"), 1, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 1, 1, 7 },
                    { new Guid("3dc6165d-f17e-443e-b9ff-7197b074c4d0"), 6, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 1, 4, 5 },
                    { new Guid("3ebde6ab-0dc0-4320-b3d1-a9a8d1491443"), 3, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 4, 1, 13 },
                    { new Guid("3f5ea9ff-bacc-48c5-a88c-f3f717f2e8eb"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 3, 4, 1 },
                    { new Guid("4103ee30-40ef-41cf-abcb-cf22ded8f3e5"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 4, 3, 13 },
                    { new Guid("42152dca-5fa3-43f5-b910-750fddb9f01e"), 3, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 1, 6, 6 },
                    { new Guid("4229477c-ab5c-46fb-ba53-6131654ba873"), 6, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 0, 3, 5 },
                    { new Guid("425dbd8b-4312-43b5-8c3c-6d92c103dbc3"), 2, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 0, 1, 13 },
                    { new Guid("42f31633-a986-4f7f-b05d-50de7746f28c"), 3, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 2, 4, 5 },
                    { new Guid("445af8ab-15f2-4f18-bac1-5f62c1fd42b1"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 2, 5, 1 },
                    { new Guid("44dfdc04-3bae-4c4b-8f85-2d9757366d46"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 3, 3, 1 },
                    { new Guid("45af366e-ef27-4a07-9a37-5e77e3c9c486"), 6, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 1, 1, 14 },
                    { new Guid("48b46d2e-9366-4d67-8eb5-c4e981808ea5"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 3, 2, 1 },
                    { new Guid("4a4be4f5-86f7-47d5-b34d-ef190f87dae4"), 2, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 0, 4, 6 },
                    { new Guid("4bc6391d-a74b-4a92-9b22-2cac50ca330f"), 6, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 4, 4, 1 },
                    { new Guid("4dd4ef93-f381-4fbf-95b8-7abbe78241a9"), 1, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 4, 4, 1 },
                    { new Guid("4e861536-8415-4229-814a-5eab719a668f"), 1, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 1, 1, 5 },
                    { new Guid("4f2856b2-6788-4e06-a17f-184b956d7324"), 6, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 3, 6, 5 },
                    { new Guid("4f85d697-d979-466a-9699-112d1a533301"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 4, 3, 1 },
                    { new Guid("50279adc-4e55-4dc7-8b76-2b4ca882d2ab"), 1, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 2, 6, 6 },
                    { new Guid("50ecc5af-49f1-4e2d-99ab-d58cc85bf3dc"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 0, 4, 7 },
                    { new Guid("51944397-68f6-49da-a658-3bc2035bf02b"), 6, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 2, 4, 7 },
                    { new Guid("527cc483-32c8-43fe-b77a-9d345debffc1"), 5, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 2, 1, 14 },
                    { new Guid("52f6879e-2281-47a2-9a5d-22afbaea9477"), 1, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 1, 5, 7 },
                    { new Guid("53fc745b-a7da-42ac-af8e-32621d44bb23"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 0, 2, 13 },
                    { new Guid("543c114a-be8e-4689-a3a9-533e2a4eb370"), 2, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 0, 6, 13 },
                    { new Guid("558642cc-8ef8-4a75-b841-cc7a863f9bde"), 4, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 3, 4, 13 },
                    { new Guid("55a81ed4-1d20-49bd-83ed-af83d6bb0a0c"), 6, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 3, 1, 5 },
                    { new Guid("55e9a4cb-5243-4c7c-b09a-a0f4547c806e"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 0, 6, 7 },
                    { new Guid("56df1835-53b7-4c68-aa5d-c610ef809525"), 1, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 4, 4, 14 },
                    { new Guid("56e2a939-8b0f-4162-aca6-649f6ee1427f"), 4, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 1, 5, 5 },
                    { new Guid("56edfc09-6b3d-40b0-9a4c-a7fb68e2a343"), 1, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 4, 3, 14 },
                    { new Guid("575e8d38-aacf-4489-a43e-5b123d36d887"), 4, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 1, 3, 14 },
                    { new Guid("57625036-aaf7-43a1-874c-5872942efd5c"), 4, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 2, 1, 6 },
                    { new Guid("5a44d419-381d-4e97-b757-f7367e44b524"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 4, 4, 13 },
                    { new Guid("5b040185-f2e5-4011-b294-d7ade3ff1663"), 6, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 1, 3, 14 },
                    { new Guid("5b32457f-5c61-462b-828e-25ebb183492a"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 1, 1, 1 },
                    { new Guid("5c031f90-6712-4ce2-9765-055a955fea21"), 1, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 3, 3, 7 },
                    { new Guid("5c0aa62c-583c-4f30-93d2-1de79b9fd076"), 4, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 1, 4, 1 },
                    { new Guid("5c26416c-5f42-4372-9233-99fc25a1aa81"), 3, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 2, 6, 14 },
                    { new Guid("5d3bd2b8-96c5-4ad9-a9e9-9b63c87481bc"), 5, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 4, 4, 5 },
                    { new Guid("5ec71c97-d60b-4d6f-95db-58d15a5a0b2f"), 4, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 4, 6, 5 },
                    { new Guid("5ffea7e1-15c0-404d-bbf6-d424546b08d6"), 4, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 1, 6, 13 },
                    { new Guid("603773b2-c291-4888-b360-cc21989db1f1"), 3, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 4, 4, 7 },
                    { new Guid("61020aaa-f65c-4726-ba6b-c41f701dd0d3"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 4, 3, 7 },
                    { new Guid("61f0c901-5f2d-4326-963e-1d760cb34d26"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 2, 5, 7 },
                    { new Guid("6286f7ac-19a9-4f51-807d-ac1c0f6ef7db"), 2, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 2, 4, 13 },
                    { new Guid("629ef9eb-02e5-4ad5-a3e7-852d0acd1a64"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 3, 2, 13 },
                    { new Guid("62c36bfa-f570-4ca6-9286-15ac0133dacc"), 2, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 1, 3, 1 },
                    { new Guid("644843a8-8c56-4089-b821-5ddbfb17870f"), 6, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 3, 2, 14 },
                    { new Guid("6552f50b-d436-484d-ab7f-7fb998b0b29a"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 3, 1, 1 },
                    { new Guid("6565d32a-3a46-43f5-af21-1a381609b936"), 4, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 0, 1, 5 },
                    { new Guid("669dd026-3c29-4e6d-9612-8a508b3ab3e4"), 5, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 2, 6, 5 },
                    { new Guid("674d6317-6b2d-488c-aadd-ee7682e7c0b3"), 3, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 3, 6, 5 },
                    { new Guid("6793adaf-d6f3-478d-990c-3043bd5a86b6"), 2, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 0, 2, 7 },
                    { new Guid("68ee7580-e3c8-4704-b3a9-b3f3586f6878"), 5, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 2, 6, 14 },
                    { new Guid("697c33a5-1f1c-4607-962d-43439d669ffd"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 2, 6, 13 },
                    { new Guid("698bc882-bb77-4e98-80e0-4c5a1d81d9a7"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 2, 6, 7 },
                    { new Guid("6a05a158-bded-4a97-83ab-434737879f5e"), 4, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 2, 2, 14 },
                    { new Guid("6ad999d8-e649-4ba2-af5b-4a4039240b91"), 4, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 2, 6, 7 },
                    { new Guid("6c780df4-b986-46eb-8e05-182e226e9c54"), 4, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 1, 5, 6 },
                    { new Guid("6c8e10c7-6a54-4c99-a84d-a908b5ff29d9"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 0, 1, 13 },
                    { new Guid("6d7148e9-a62a-4c14-858a-09103fffcb53"), 5, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 0, 3, 14 },
                    { new Guid("6df843d7-2b99-484e-8c37-746118241a98"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 1, 4, 1 },
                    { new Guid("6e0292ed-b4b2-4200-a3ee-bcccdf8ba5f0"), 5, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 3, 3, 6 },
                    { new Guid("6e7a1a91-e4e7-410b-afe3-d57ef524d805"), 3, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 4, 5, 14 },
                    { new Guid("6ef7c344-9aee-470a-a00c-83fd9a45692e"), 1, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 4, 5, 14 },
                    { new Guid("6f928eb4-89e9-477c-8b97-8cb8a55a2ede"), 6, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 2, 3, 5 },
                    { new Guid("7142cf3c-41ef-43b4-ba88-6179ad3d8cdb"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 2, 4, 13 },
                    { new Guid("724ed4f3-6d20-41b8-a6e9-dfcc7d4db8b1"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 0, 2, 1 },
                    { new Guid("74005336-70f3-435b-a50c-83a50849dc4f"), 2, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 3, 5, 6 },
                    { new Guid("7434e45d-680a-4b40-8fd0-80faa85957c3"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 2, 2, 13 },
                    { new Guid("75f60c0a-7224-4585-901a-d6a5435f559e"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 2, 3, 1 },
                    { new Guid("76112a83-787e-4d3c-b38e-d49b9a97285a"), 4, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 1, 2, 6 },
                    { new Guid("77149d71-2ca4-4383-aa44-1eb180ef296b"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 3, 1, 1 },
                    { new Guid("78d121aa-e421-4675-87c5-a0f0b6e1bf05"), 5, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 0, 6, 7 },
                    { new Guid("7a2c3ffe-1c39-474f-ba3a-57cf3698e417"), 2, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 2, 5, 7 },
                    { new Guid("7a56fc1f-f46b-4267-a05c-070aededfb7d"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 3, 2, 7 },
                    { new Guid("7aeea360-8ab1-406c-81e2-3399bd206989"), 6, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 1, 2, 5 },
                    { new Guid("7b2bbc9e-a67f-4403-bce1-e395decc4bd2"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 0, 1, 13 },
                    { new Guid("7c03eb39-c455-43b9-ad49-65f9ab616bac"), 3, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 1, 2, 13 },
                    { new Guid("7c3fb23c-dffb-437a-9566-d0e1ba0dd5d6"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 3, 2, 13 },
                    { new Guid("7c436550-93e9-404e-812b-7edd0be08320"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 1, 4, 1 },
                    { new Guid("7c8abeda-d6a5-43e5-bfa6-781662074d7f"), 1, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 2, 3, 1 },
                    { new Guid("7e7b7439-c6de-46bb-8e22-c60918bdbde4"), 6, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 3, 4, 14 },
                    { new Guid("8374560a-65e3-416a-81b7-9c40b0fa527d"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 3, 1, 13 },
                    { new Guid("839524ce-6583-4533-854c-0edeb03301d2"), 6, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 4, 1, 13 },
                    { new Guid("84efaa1c-1176-4d54-95c3-48f324ca9ae8"), 1, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 2, 6, 14 },
                    { new Guid("868229bf-c774-41ab-bb4f-1ac78f0bfd3f"), 3, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 3, 2, 5 },
                    { new Guid("86db8cf9-e068-4c1c-82bd-03e429b46847"), 1, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 1, 2, 1 },
                    { new Guid("87645324-d0c0-4821-91e3-08aa62c6c60d"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 0, 1, 7 },
                    { new Guid("876863e5-dc7a-4995-a4b3-00fd62fc239d"), 3, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 3, 5, 1 },
                    { new Guid("87c863d8-c208-42bd-84c3-63947f323302"), 3, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 0, 3, 7 },
                    { new Guid("889ac3f0-bd2a-4d92-9098-2636d7cd30be"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 1, 4, 13 },
                    { new Guid("88f56339-d79f-4af8-9f02-4ccf085f987d"), 2, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 3, 6, 5 },
                    { new Guid("89905f69-1a31-426e-90b2-2cb0c1cf9789"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 1, 4, 13 },
                    { new Guid("8ad98035-c8b7-47a2-a163-868beff2f7c9"), 3, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 0, 6, 5 },
                    { new Guid("8af44159-feda-4acb-827f-5ca7ed545035"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 0, 3, 7 },
                    { new Guid("8bc3c06c-d1df-4e5a-83d5-6bfe8fa02687"), 1, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 2, 6, 5 },
                    { new Guid("8c3a25c3-4d17-41d5-8eba-6cf65a0710df"), 5, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 3, 3, 1 },
                    { new Guid("8caa6a3f-7687-4f00-859b-024dfccfa1ae"), 4, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 3, 3, 6 },
                    { new Guid("8eea2c5d-5aa5-4d1a-868b-f83b1410e684"), 5, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 1, 1, 6 },
                    { new Guid("8f616f3f-383b-45a2-9667-514f4f6045f3"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 3, 5, 13 },
                    { new Guid("8f786884-89e6-406e-ae18-0a01b038afc8"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 0, 3, 7 },
                    { new Guid("8fab2c43-6136-4b31-96cb-7158e6f2ce77"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 0, 2, 7 },
                    { new Guid("8ff5fc11-4229-496f-8ef3-afa6f732358f"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 1, 1, 1 },
                    { new Guid("9012dcb6-6121-46a4-be97-4c35073a8de3"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 1, 3, 7 },
                    { new Guid("9056361d-cc44-4d6b-8c9c-a8a1135866dc"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 4, 4, 7 },
                    { new Guid("91b00a2b-52af-484e-8370-b2155a284929"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 0, 1, 7 },
                    { new Guid("92081e0a-80ee-4385-be3d-f81d7748d31d"), 5, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 4, 2, 1 },
                    { new Guid("92c3b323-fbba-4a72-a7f5-ccc34d6816dd"), 5, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 2, 2, 14 },
                    { new Guid("9585325e-04f5-4638-8d1b-051a9ad9c66e"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 2, 3, 13 },
                    { new Guid("96029cf0-e8b2-4eae-ae7e-a0fad7337473"), 1, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 4, 6, 1 },
                    { new Guid("963ab65c-8516-4159-a67b-0028f366eb23"), 2, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 4, 6, 6 },
                    { new Guid("9740a98f-3a27-4a52-b8cb-b68e510d7b66"), 5, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 0, 5, 5 },
                    { new Guid("97f66afa-a92e-4966-b80e-6cb9364edeb4"), 6, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 2, 1, 6 },
                    { new Guid("98e5dbbb-75b5-45e5-9e7c-91dd8ab17b0a"), 5, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 0, 5, 14 },
                    { new Guid("9943fc79-c69c-4a30-95c2-0f180b33e4e3"), 6, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 2, 5, 5 },
                    { new Guid("99c9f271-9ec6-40e4-a763-fc0fd8f409bc"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 4, 5, 7 },
                    { new Guid("9bed93b6-1266-4ff2-942b-becc5a5b64b7"), 5, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 2, 2, 7 },
                    { new Guid("9c5692bc-6ae0-44e3-931c-e8183dc7f5b9"), 4, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 3, 2, 13 },
                    { new Guid("9cc67266-1ec8-45c3-bbc1-da4a5d36bac8"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 4, 6, 7 },
                    { new Guid("9ce8b2a7-d12b-440c-bf80-017e9707aba1"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 1, 5, 7 },
                    { new Guid("9d375fb9-bf48-440e-925a-a583a87ae56a"), 1, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 4, 4, 7 },
                    { new Guid("9d9aadd3-4139-4cba-bcd8-5795c8c5a2d8"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 3, 2, 1 },
                    { new Guid("9f305f26-a420-49d7-a91c-9cb17fdab3d3"), 1, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 2, 2, 6 },
                    { new Guid("9f690473-50dc-4ef0-9bcc-bfe78275785f"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 2, 3, 13 },
                    { new Guid("9f88932c-2e08-44cb-84f5-d8d1487d67fc"), 2, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 4, 2, 1 },
                    { new Guid("9fdecb44-94d6-4421-be4b-1822cbb915d3"), 4, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 0, 4, 7 },
                    { new Guid("a0a37579-6898-4d99-a827-6b5fc13f8c43"), 1, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 4, 4, 5 },
                    { new Guid("a2e629c4-ed4d-4c9c-b98f-15f495a7b3d3"), 1, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 3, 2, 13 },
                    { new Guid("a43ad412-a284-4b32-b388-32c19c22e575"), 3, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 3, 5, 7 },
                    { new Guid("a4813b16-0999-4680-94c6-54ae5ac1fb4a"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 4, 2, 1 },
                    { new Guid("a48200b6-9608-4c09-bb35-84c93a052100"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 1, 6, 7 },
                    { new Guid("a685f2d6-ea7c-413e-8098-ea4e033ab731"), 6, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 4, 3, 6 },
                    { new Guid("a80f48b0-306f-4b96-94be-577fad968de6"), 4, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 1, 2, 5 },
                    { new Guid("a8e510ea-cc45-4e08-be3c-69c4544d7cd2"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 0, 2, 13 },
                    { new Guid("a9bfd6c3-4e12-4fef-b231-36ff1f7a7d74"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 0, 3, 13 },
                    { new Guid("aaf8e0dc-95fe-40f2-9389-917d0ee4ddd2"), 4, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 4, 4, 6 },
                    { new Guid("ae499b6f-bba2-4809-884f-5697f4d5b92c"), 1, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 3, 5, 1 },
                    { new Guid("ae6cce94-38e0-4dec-b16d-766c913591e0"), 1, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 2, 3, 5 },
                    { new Guid("af1f63f8-6033-43f2-a331-62325e0862f3"), 4, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 0, 6, 14 },
                    { new Guid("af29b9bf-99f6-437c-b164-23c8fb3ade77"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 2, 5, 13 },
                    { new Guid("af82921d-276c-4440-8128-6ad5c4d46a19"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 0, 5, 13 },
                    { new Guid("af9af53c-4142-4fae-a9f2-301108d4203d"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 1, 3, 13 },
                    { new Guid("b017076b-fea2-49a9-ac46-72920bc4a41e"), 2, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 1, 1, 7 },
                    { new Guid("b03c7f83-a679-40b9-a2e2-df3d8a11d66a"), 4, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 3, 6, 6 },
                    { new Guid("b040bd6a-de02-4e65-b094-ab6eb478c7ca"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 0, 6, 1 },
                    { new Guid("b0d981a7-658c-4887-b6a9-ebfd58a8dea1"), 4, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 0, 2, 7 },
                    { new Guid("b0fb7989-1371-429d-bb4b-6c15d5e4cc41"), 6, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 4, 6, 6 },
                    { new Guid("b1023bbc-afcb-49ef-96f5-82db2a3471c9"), 4, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 4, 6, 1 },
                    { new Guid("b1220bd7-c4e3-4229-bd8a-09ff5a54868a"), 5, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 2, 4, 5 },
                    { new Guid("b25ba375-59f9-4203-ba27-2cbe5fa34e84"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 0, 2, 7 },
                    { new Guid("b3772223-cd1b-44fd-8bc9-19aa251f0fc0"), 3, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 4, 2, 14 },
                    { new Guid("b673b8c4-a7a8-4c51-b418-3b1f3df5bb2f"), 5, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 4, 2, 6 },
                    { new Guid("b6e93af3-8bf2-4453-a6a7-fdacbe224a58"), 6, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 0, 3, 13 },
                    { new Guid("b6fe9ca5-4d30-45e0-9c20-65437fceb02a"), 3, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 3, 3, 5 },
                    { new Guid("b74400fc-339a-4b4d-bfcb-bb96b7ad2760"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 4, 6, 1 },
                    { new Guid("b77c6df5-d857-48c3-a27e-b09e5436acf9"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 0, 4, 1 },
                    { new Guid("b7c68664-feea-41ed-bc1e-5b129e2b2e6e"), 4, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 3, 3, 5 },
                    { new Guid("b7ce6e7e-3ea0-4fd2-b099-b0586d77f787"), 5, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 0, 2, 5 },
                    { new Guid("b85460dd-4116-4e02-99cd-55ee6ab17bf3"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 2, 6, 13 },
                    { new Guid("b87861d5-9735-4d7b-bf94-1d215b32dfd1"), 5, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 0, 3, 5 },
                    { new Guid("b8dedfef-5b91-442b-be77-142bb210ed62"), 1, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 3, 6, 5 },
                    { new Guid("b90b67a8-8875-4965-8898-4fc69c0fdf48"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 1, 2, 7 },
                    { new Guid("b922b604-9956-4cdd-984c-aa65d11ff2ea"), 3, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 2, 4, 5 },
                    { new Guid("b9478b04-3209-4593-b228-0816ae358d1c"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 4, 3, 1 },
                    { new Guid("bb64dfcb-d7f1-4eb4-8ab7-a727ca1d5f42"), 3, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 1, 2, 7 },
                    { new Guid("bcaf1c1c-d2d0-4334-b79e-387a01ae10cc"), 2, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 0, 1, 14 },
                    { new Guid("bccc6653-bbd4-42f6-9fed-059fd9a1adc8"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 2, 4, 13 },
                    { new Guid("bd4fd617-fd10-46ad-9997-ada59663fcc2"), 6, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 0, 6, 13 },
                    { new Guid("be321b68-649c-46f1-a3ed-b72453324f19"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 4, 3, 13 },
                    { new Guid("be795eb0-7fc3-4c51-83f6-8fd6bce3b75c"), 6, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 0, 6, 7 },
                    { new Guid("c1db353e-9990-4c91-84db-78db4756f04c"), 5, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 0, 2, 13 },
                    { new Guid("c2a20391-45d3-41b0-a814-aa4405d3c8ca"), 4, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 3, 5, 1 },
                    { new Guid("c2c12eb4-72d6-4c45-a6af-bda58bc41219"), 4, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 3, 3, 13 },
                    { new Guid("c3154148-06bb-4681-b7a1-e449e054d2ff"), 4, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 3, 6, 5 },
                    { new Guid("c424fcdb-ceed-437d-b0ad-14ce60884c7e"), 3, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 1, 5, 5 },
                    { new Guid("c50343d5-69a2-482c-a95f-2a4128797d92"), 1, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 3, 3, 6 },
                    { new Guid("c662baef-5c03-4b49-8213-4bbd478e4632"), 5, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 0, 5, 1 },
                    { new Guid("c67d25d9-05c1-48b6-9988-9982b45fcc15"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 4, 6, 13 },
                    { new Guid("c6b43a97-74af-451f-9062-43d204919518"), 6, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 1, 1, 5 },
                    { new Guid("c770634c-3582-4c08-8807-d0721a70727b"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 2, 5, 1 },
                    { new Guid("c778b816-0ee1-4274-b451-f1ea3ec74e0d"), 2, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 2, 6, 5 },
                    { new Guid("c7bd7346-2ac6-4676-a367-33d754c9be20"), 1, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 2, 1, 13 },
                    { new Guid("c841549f-5b98-486b-b895-ef008946572d"), 3, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 1, 5, 5 },
                    { new Guid("c8ea4ca0-bc53-496c-ae99-69693204cbce"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 0, 2, 13 },
                    { new Guid("c984862c-8e1c-41e3-9777-9e4ed2ae1936"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 1, 4, 1 },
                    { new Guid("c9ec2940-69ad-45d8-8106-6a3f9398f785"), 5, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 0, 4, 13 },
                    { new Guid("cb0c03c2-a537-4a5a-8389-81990bac8aea"), 5, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 1, 4, 14 },
                    { new Guid("cb676ab1-c818-42e2-bb9d-50e8d7018a2f"), 3, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 3, 4, 13 },
                    { new Guid("cc145714-652c-4c9f-8691-ac5e0a4dd8e4"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 4, 1, 13 },
                    { new Guid("cdb4533a-a12e-40ac-9302-3b386181714e"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 2, 3, 7 },
                    { new Guid("cdcff7a8-386c-4fb1-bcb6-42ad2f6b0352"), 5, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 3, 5, 5 },
                    { new Guid("ce0db9ad-170b-42e2-a005-d7832cd780a2"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 0, 1, 7 },
                    { new Guid("ce1dbcc5-b633-4463-a0a7-3b78febf840a"), 1, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 2, 1, 14 },
                    { new Guid("ce35bf27-b54c-4eb3-a1fe-73ca47f67373"), 5, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 1, 1, 1 },
                    { new Guid("cf02376e-f6ae-4256-acdd-abe4cfc3e85a"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 0, 5, 7 },
                    { new Guid("cf6a4888-b20a-4ce3-9170-6c031ba19876"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 0, 5, 13 },
                    { new Guid("cfa91fb9-efbb-4f97-bb93-85adea3bf408"), 1, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 2, 2, 5 },
                    { new Guid("d0768315-b3a2-4f99-b53a-6724d67d1056"), 2, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 3, 1, 5 },
                    { new Guid("d18ff709-4da6-4584-b4eb-53731b0ec252"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 2, 4, 7 },
                    { new Guid("d198e8fb-038b-48d9-8960-388e884c63fc"), 4, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 1, 1, 14 },
                    { new Guid("d1d096e3-1228-4665-8a7d-4cf9def7de21"), 3, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 3, 5, 13 },
                    { new Guid("d1d48b20-6eb4-45a1-80f2-20dc9cb544ec"), 5, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 3, 6, 13 },
                    { new Guid("d2739595-daca-4476-8a31-80ab131e2cdc"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 3, 3, 13 },
                    { new Guid("d2899dcd-ce1b-49a2-bab2-54d4237790e6"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 1, 2, 1 },
                    { new Guid("d5895727-6b5d-49a9-96bd-0b03bb25783f"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 3, 4, 13 },
                    { new Guid("d5dc90ec-8a30-4cef-9b29-4b88505a48d3"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 0, 6, 1 },
                    { new Guid("d60bb0cf-6143-4f26-a8f6-77945ce796f3"), 1, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 0, 6, 7 },
                    { new Guid("d6575162-31cd-4d83-bf2d-7564a5b757c4"), 4, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 4, 4, 5 },
                    { new Guid("d737f891-1474-4536-ae72-b86cf2ead06d"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 2, 6, 13 },
                    { new Guid("d7ac040f-56f1-4cdd-93ec-6d49f1b73fa2"), 3, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 3, 5, 6 },
                    { new Guid("d84b3983-1ba4-4dbc-a7f5-300cecef0305"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 2, 5, 1 },
                    { new Guid("d87f662c-5009-40c8-9ecb-a735b80e2693"), 1, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 1, 2, 7 },
                    { new Guid("d99f903e-1c42-428c-a466-0dc93b75b678"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 0, 3, 13 },
                    { new Guid("d9a0ba7f-9886-4c93-963d-545c0223c840"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 4, 4, 7 },
                    { new Guid("d9f4fc72-6bde-47a2-a6c8-1acfafef02d8"), 3, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 2, 1, 7 },
                    { new Guid("da7d0ad7-1eaf-482e-be68-8f46d401f462"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 2, 4, 7 },
                    { new Guid("dabd50bb-c5ba-4a15-8644-0fad9db2868f"), 4, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 2, 5, 13 },
                    { new Guid("dadf814b-fea0-4105-b4b5-1a67778c03bb"), 2, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 2, 3, 6 },
                    { new Guid("db78430f-5915-4535-81e0-db8aedf16dcf"), 6, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 2, 2, 5 },
                    { new Guid("dc38ff96-cb02-4922-9150-d334ba914f1a"), 1, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 1, 4, 13 },
                    { new Guid("dc4ad6e4-21c1-4345-b9e8-88cd2c0b2e10"), 2, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 2, 5, 5 },
                    { new Guid("dc68bca6-c158-4797-bac4-395afc1f7734"), 1, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 0, 5, 6 },
                    { new Guid("de05f483-47d4-4968-8932-75f5a6e8081d"), 6, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 2, 2, 7 },
                    { new Guid("de5c8fed-65e8-4e0c-a648-97bff8ab5bb2"), 4, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 0, 3, 1 },
                    { new Guid("df06c05e-086f-4da1-ba04-c6cbfe91c410"), 4, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 2, 1, 7 },
                    { new Guid("df793dc0-e055-4474-8c7a-7a001e7d41ec"), 3, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 3, 1, 1 },
                    { new Guid("e0527b13-9dea-4712-889d-3df8eae89ec3"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 0, 4, 13 },
                    { new Guid("e097a0ec-7141-479a-940e-b3f0bcd33698"), 2, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 2, 6, 7 },
                    { new Guid("e25f9f21-9299-4a70-bf2e-e8e8540cc574"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 2, 5, 13 },
                    { new Guid("e2c3a774-cc2f-482a-b416-de7ec5a2a2ed"), 6, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 4, 1, 7 },
                    { new Guid("e3cf38a6-1e75-4eb0-a179-519d21537502"), 1, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 0, 5, 5 },
                    { new Guid("e449dfe0-44de-4cde-b551-b18753e45398"), 3, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 2, 1, 14 },
                    { new Guid("e536dd9b-0bff-4554-abf6-994c86129720"), 6, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 1, 5, 6 },
                    { new Guid("e557de30-ba81-4381-96ee-3e66897fab90"), 2, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 2, 6, 14 },
                    { new Guid("e5bb66a2-e9a2-4f36-9186-784e5e5a51bd"), 3, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 0, 3, 5 },
                    { new Guid("e6e9ad87-83cd-4534-a5b3-71ab5cb1210d"), 6, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 4, 3, 1 },
                    { new Guid("e76590b9-c8fd-4479-852d-380961805eac"), 5, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 1, 6, 5 },
                    { new Guid("e7f1befd-b6a5-4819-94f2-15aed7d9244c"), 3, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 1, 3, 13 },
                    { new Guid("e81050dd-09b0-4e3c-bfcf-0e6b9b144396"), 4, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 0, 3, 5 },
                    { new Guid("e8c70edb-6226-403d-9a37-845a04aa89f2"), 5, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 2, 5, 13 },
                    { new Guid("ea7f8a8c-3480-4d27-828d-5667b90dd369"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 0, 6, 1 },
                    { new Guid("ea976fb2-a623-44b4-9780-7e1c8c058f41"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 0, 5, 13 },
                    { new Guid("eb8a51d5-730e-4995-a5f3-0368c73e1059"), 4, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 1, 1, 1 },
                    { new Guid("ec04c1c1-7889-41a3-af68-a83cfd602a16"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 3, 5, 13 },
                    { new Guid("ec1c4579-2f62-4aa8-96b9-4ee2648f0978"), 1, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 2, 2, 14 },
                    { new Guid("ed7fa6b5-1602-4374-889d-a73195f1a1cb"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 0, 6, 13 },
                    { new Guid("ee143bde-d281-4600-8596-c677f43e543c"), 3, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 1, 4, 6 },
                    { new Guid("eeb96a70-7c4d-4bd7-84b4-8bfad270b6ee"), 6, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 0, 4, 13 },
                    { new Guid("eed55e3e-a025-48fc-ac1b-d37b54fe6a0b"), 2, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 4, 2, 5 },
                    { new Guid("ef333ad7-b777-4213-837d-29ad2a156557"), 6, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 539m, 1, null, 4, 4, 13 },
                    { new Guid("efbfd072-a3ae-4599-9ab9-cb9a12ca05a5"), 3, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 1, 1, 5 },
                    { new Guid("f0fa9de1-f298-4c5e-9194-d4b515ecb474"), 4, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 2, 5, 7 },
                    { new Guid("f14e51ba-4187-4ab1-af28-7544c6221722"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 3, 4, 13 },
                    { new Guid("f3041f97-7a7c-4a5a-addb-5424c61f4524"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 2, 6, 13 },
                    { new Guid("f34b0bb2-08f0-46fd-8cd7-d75b9e52707e"), 2, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 2, 2, 1 },
                    { new Guid("f3706ae2-7c06-41cf-bec3-932a95d42a56"), 2, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 559m, 1, null, 0, 4, 5 },
                    { new Guid("f3e1bee9-dba0-4ca7-a042-f3eafd440a61"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 4, 1, 1 },
                    { new Guid("f3f07d8c-d84c-43f3-9c82-32bf716b3056"), 6, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 3, 1, 1 },
                    { new Guid("f4ca23e3-5669-44e0-a359-285c484e132c"), 3, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 3, 3, 1 },
                    { new Guid("f697e2d9-4ee2-42bb-9168-2221de2f1889"), 2, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 3, 4, 7 },
                    { new Guid("f6ba0e1a-48b3-44e1-a0ce-681d3846b931"), 4, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 4, 4, 14 },
                    { new Guid("f74b0253-c850-4473-9303-ca06a46f8850"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 796m, 1, null, 2, 4, 7 },
                    { new Guid("f78e8e07-4c5b-4249-9d67-fa0de298d244"), 1, false, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 765m, 1, null, 3, 2, 5 },
                    { new Guid("f7c804e0-400a-45b3-b74e-46407d784a58"), 1, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 300m, 1, null, 4, 1, 6 },
                    { new Guid("f86d1537-5dd6-48b6-b02e-a0561ba4c2f8"), 6, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 266m, 1, null, 0, 5, 14 },
                    { new Guid("f883eb5a-e31e-4c76-8af1-9bdb44719d76"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 2, 6, 13 },
                    { new Guid("f9c84011-0390-419b-895a-54055439870c"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 0, 3, 1 },
                    { new Guid("fa06fe7c-5db0-4e58-8224-cdfbda9b6970"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 0, 6, 13 },
                    { new Guid("fa2819aa-0057-4898-b5e0-872d9533c4fb"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite T-Shirt", 322m, 1, null, 2, 4, 1 },
                    { new Guid("fae8d870-9337-41f9-843c-2e8b9a4a9977"), 3, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 4, 6, 1 },
                    { new Guid("fb7c77fc-e655-435a-9b81-23dc724325d6"), 5, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 1, 4, 1 },
                    { new Guid("fc0d7606-30d9-46f5-a68b-f75598d97d79"), 4, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 3, 4, 13 },
                    { new Guid("fcdda56b-4deb-49f2-a63e-6fb2dcf373f5"), 3, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 2, 1, 13 },
                    { new Guid("fcf0829c-0942-44da-9aab-478b062de1e8"), 2, true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant T-Shirt", 868m, 1, null, 4, 4, 1 },
                    { new Guid("fe3e0ea2-adc2-485c-9c4f-3787a2104f82"), 2, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 3, 3, 7 },
                    { new Guid("feafa967-8951-4d74-bc69-09a50bda0086"), 5, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Bag", 221m, 1, null, 2, 3, 13 },
                    { new Guid("ff7004d1-16da-47db-9d7a-b3d87e5352cb"), 6, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 0, 5, 7 },
                    { new Guid("ff813288-475e-4130-a00c-cdc5b8ded99a"), 1, true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Bag", 275m, 1, null, 3, 6, 13 },
                    { new Guid("ff832679-d1ad-497c-95f4-7382deaca109"), 4, false, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 517m, 1, null, 0, 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_CustomerId",
                table: "CustomerAddresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PaymentId",
                table: "Customers",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderAddresses_OrderId",
                table: "OrderAddresses",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentMethodPaymentId",
                table: "Orders",
                column: "PaymentMethodPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StatusId",
                table: "Orders",
                column: "StatusId");

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

            migrationBuilder.CreateIndex(
                name: "IX_WishListItems_WishListId",
                table: "WishListItems",
                column: "WishListId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_CustomerId",
                table: "WishLists",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerAddresses");

            migrationBuilder.DropTable(
                name: "OrderAddresses");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "PromotionCodes");

            migrationBuilder.DropTable(
                name: "WishListItems");

            migrationBuilder.DropTable(
                name: "Orders");

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
                name: "WishLists");

            migrationBuilder.DropTable(
                name: "OrderStatuses");

            migrationBuilder.DropTable(
                name: "PrimaryCategories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "PaymentMethods");
        }
    }
}
