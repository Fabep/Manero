﻿// <auto-generated />
using System;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(LocalContext))]
    [Migration("20231101083922_adai")]
    partial class adai
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Models.Entities.ProductEntity", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("DiscountedPrice")
                        .HasColumnType("float");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.Property<int?>("PromotionId")
                        .HasColumnType("int");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("PromotionId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("2039b1d8-2f54-4e51-b14e-96ac7cb69517"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "Dress Black",
                            ProductPrice = 322.0,
                            Quantity = 6,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("475dd5f0-1c56-407c-9356-3a568f9f262c"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "Pants Yellow",
                            ProductPrice = 927.0,
                            Quantity = 94,
                            Rating = 3
                        },
                        new
                        {
                            ProductId = new Guid("a8d79399-8040-4e14-92cb-25fb0c5becd7"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "Suit Blue",
                            ProductPrice = 979.0,
                            Quantity = 41,
                            Rating = 1
                        },
                        new
                        {
                            ProductId = new Guid("706a84b8-411b-4e0d-bc8e-76c028b39962"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "T-Shirt White",
                            ProductPrice = 790.0,
                            Quantity = 4,
                            Rating = 2
                        },
                        new
                        {
                            ProductId = new Guid("4fd544dc-3b66-43ea-b616-53c4f7ad09e2"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "T-Shirt Yellow",
                            ProductPrice = 890.0,
                            Quantity = 7,
                            Rating = 3
                        },
                        new
                        {
                            ProductId = new Guid("85552ba8-35a8-4282-9ef7-fa8ea6a3ad61"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "Shoes Blue",
                            ProductPrice = 93.0,
                            Quantity = 13,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("d4888146-0a55-4ecc-a6ef-62b13135f94d"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "Pants Blue",
                            ProductPrice = 556.0,
                            Quantity = 17,
                            Rating = 4
                        },
                        new
                        {
                            ProductId = new Guid("dfebd692-4b3f-4813-a8a6-da51afcd9240"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "Dress Red",
                            ProductPrice = 397.0,
                            Quantity = 98,
                            Rating = 4
                        },
                        new
                        {
                            ProductId = new Guid("8111e2d8-2d73-4b21-ac01-68f3092a2e31"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "Pants Yellow",
                            ProductPrice = 291.0,
                            Quantity = 53,
                            Rating = 1
                        },
                        new
                        {
                            ProductId = new Guid("87646ef3-98ef-4881-b10e-3db4a0a9fb88"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "Pants White",
                            ProductPrice = 881.0,
                            Quantity = 20,
                            Rating = 2
                        },
                        new
                        {
                            ProductId = new Guid("cd9cb401-0d66-42b7-83dd-5717b471b8e0"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "Dress Red",
                            ProductPrice = 938.0,
                            Quantity = 13,
                            Rating = 2
                        },
                        new
                        {
                            ProductId = new Guid("fca117ab-8493-4807-a761-5070b7b8a717"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "T-Shirt White",
                            ProductPrice = 818.0,
                            Quantity = 71,
                            Rating = 4
                        },
                        new
                        {
                            ProductId = new Guid("cc19e01d-3308-47e2-bd0e-6900d39c2766"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "Pants White",
                            ProductPrice = 569.0,
                            Quantity = 62,
                            Rating = 1
                        },
                        new
                        {
                            ProductId = new Guid("2c940870-ef4c-4393-b09a-7bc869b83fb0"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "Suit Green",
                            ProductPrice = 638.0,
                            Quantity = 97,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("7493a410-9bdd-4f07-9b28-14b2230db713"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "Suit Blue",
                            ProductPrice = 172.0,
                            Quantity = 17,
                            Rating = 2
                        },
                        new
                        {
                            ProductId = new Guid("dd633072-9cae-46d7-a7f4-6c7b7c46fd68"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "Shoes Red",
                            ProductPrice = 947.0,
                            Quantity = 76,
                            Rating = 1
                        },
                        new
                        {
                            ProductId = new Guid("436f2ee0-f38b-4071-baac-f03bd67c43ac"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "Bag Green",
                            ProductPrice = 257.0,
                            Quantity = 11,
                            Rating = 2
                        },
                        new
                        {
                            ProductId = new Guid("ab002cc9-749f-4471-b128-30da6e3b2ada"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "T-Shirt Red",
                            ProductPrice = 839.0,
                            Quantity = 51,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("1eb01051-45eb-4914-baac-9a9da8d5d871"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "Shoes Black",
                            ProductPrice = 863.0,
                            Quantity = 18,
                            Rating = 2
                        },
                        new
                        {
                            ProductId = new Guid("ab3aed4f-6205-4f98-b489-a79bf2d9b75e"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "Suit Black",
                            ProductPrice = 920.0,
                            Quantity = 18,
                            Rating = 0
                        },
                        new
                        {
                            ProductId = new Guid("3c459816-39be-40d0-88b5-02d42de88978"),
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "Pants Yellow",
                            ProductPrice = 688.0,
                            Quantity = 99,
                            Rating = 2
                        },
                        new
                        {
                            ProductId = new Guid("32073f6a-ca9f-437d-aa02-1181516534b9"),
                            ProductDescription = "Description",
                            ProductName = "Cool T-Shirt",
                            ProductPrice = 1000.0,
                            Quantity = 1,
                            Rating = 5
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Entities.PromotionEntity", b =>
                {
                    b.Property<int>("PromotionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PromotionId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DiscountRate")
                        .HasColumnType("float");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PromotionId");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("DataAccess.Models.Entities.ProductEntity", b =>
                {
                    b.HasOne("DataAccess.Models.Entities.PromotionEntity", "Promotion")
                        .WithMany()
                        .HasForeignKey("PromotionId");

                    b.Navigation("Promotion");
                });
#pragma warning restore 612, 618
        }
    }
}
