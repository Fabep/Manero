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
    [Migration("20231031130340_init db")]
    partial class initdb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Models.Entities.ColorEntity", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColorId"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColorId");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            ColorId = 1,
                            Color = "Red"
                        },
                        new
                        {
                            ColorId = 2,
                            Color = "Blue"
                        },
                        new
                        {
                            ColorId = 3,
                            Color = "Green"
                        },
                        new
                        {
                            ColorId = 4,
                            Color = "Yellow"
                        },
                        new
                        {
                            ColorId = 5,
                            Color = "White"
                        },
                        new
                        {
                            ColorId = 6,
                            Color = "Black"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Entities.PrimaryCategoryEntity", b =>
                {
                    b.Property<int>("PrimaryCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrimaryCategoryId"));

                    b.Property<string>("PrimaryCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrimaryCategoryId");

                    b.ToTable("PrimaryCategories");

                    b.HasData(
                        new
                        {
                            PrimaryCategoryId = 1,
                            PrimaryCategoryName = "Men"
                        },
                        new
                        {
                            PrimaryCategoryId = 2,
                            PrimaryCategoryName = "Women"
                        },
                        new
                        {
                            PrimaryCategoryId = 3,
                            PrimaryCategoryName = "Unisex"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Entities.ProductEntity", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<int?>("SizeId")
                        .HasColumnType("int");

                    b.Property<int?>("SubCategoryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("ColorId");

                    b.HasIndex("SizeId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("10bf5d1b-d09a-4ddf-abd9-21ebd2fd3594"),
                            ColorId = 1,
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "Cozy Dress",
                            ProductPrice = 873.0,
                            Quantity = 46,
                            Rating = 2,
                            SizeId = 1,
                            SubCategoryId = 7
                        },
                        new
                        {
                            ProductId = new Guid("84f19366-ca90-4186-b247-63e5455ba388"),
                            ColorId = 1,
                            ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ",
                            ProductName = "Comfortable Pants",
                            ProductPrice = 482.0,
                            Quantity = 21,
                            Rating = 1,
                            SizeId = 1,
                            SubCategoryId = 4
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Entities.ProductInventoryEntity", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("LastInventory")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("ProductInventories");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("8acfd15c-7552-4c42-bdef-a369c9c100db"),
                            LastInventory = new DateTime(2023, 10, 31, 14, 3, 40, 204, DateTimeKind.Local).AddTicks(4470),
                            Quantity = 59
                        },
                        new
                        {
                            ProductId = new Guid("286aa72f-94c8-429d-a2f4-fa10f0615a30"),
                            LastInventory = new DateTime(2023, 10, 31, 14, 3, 40, 204, DateTimeKind.Local).AddTicks(4542),
                            Quantity = 92
                        },
                        new
                        {
                            ProductId = new Guid("10bf5d1b-d09a-4ddf-abd9-21ebd2fd3594"),
                            LastInventory = new DateTime(2023, 10, 31, 14, 3, 40, 204, DateTimeKind.Local).AddTicks(4545),
                            Quantity = 62
                        },
                        new
                        {
                            ProductId = new Guid("84f19366-ca90-4186-b247-63e5455ba388"),
                            LastInventory = new DateTime(2023, 10, 31, 14, 3, 40, 204, DateTimeKind.Local).AddTicks(4548),
                            Quantity = 46
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Entities.PromotionEntity", b =>
                {
                    b.Property<Guid>("PromotionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

            modelBuilder.Entity("DataAccess.Models.Entities.SizeEntity", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SizeId"));

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SizeId");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            SizeId = 1,
                            Size = "XS"
                        },
                        new
                        {
                            SizeId = 2,
                            Size = "S"
                        },
                        new
                        {
                            SizeId = 3,
                            Size = "M"
                        },
                        new
                        {
                            SizeId = 4,
                            Size = "L"
                        },
                        new
                        {
                            SizeId = 5,
                            Size = "XL"
                        },
                        new
                        {
                            SizeId = 6,
                            Size = "XXL"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Entities.SubCategoryEntity", b =>
                {
                    b.Property<int>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubCategoryId"));

                    b.Property<int?>("PrimaryCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("SubCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubCategoryId");

                    b.HasIndex("PrimaryCategoryId");

                    b.ToTable("SubCategories");

                    b.HasData(
                        new
                        {
                            SubCategoryId = 1,
                            PrimaryCategoryId = 1,
                            SubCategoryName = "T-Shirts Men"
                        },
                        new
                        {
                            SubCategoryId = 2,
                            PrimaryCategoryId = 2,
                            SubCategoryName = "T-Shirts Women"
                        },
                        new
                        {
                            SubCategoryId = 3,
                            PrimaryCategoryId = 3,
                            SubCategoryName = "T-Shirts Unisex"
                        },
                        new
                        {
                            SubCategoryId = 4,
                            PrimaryCategoryId = 1,
                            SubCategoryName = "Pants Men"
                        },
                        new
                        {
                            SubCategoryId = 5,
                            PrimaryCategoryId = 2,
                            SubCategoryName = "Pants Women"
                        },
                        new
                        {
                            SubCategoryId = 6,
                            PrimaryCategoryId = 3,
                            SubCategoryName = "Pants Unisex"
                        },
                        new
                        {
                            SubCategoryId = 7,
                            PrimaryCategoryId = 2,
                            SubCategoryName = "Dresses"
                        },
                        new
                        {
                            SubCategoryId = 8,
                            PrimaryCategoryId = 1,
                            SubCategoryName = "Shoes Men"
                        },
                        new
                        {
                            SubCategoryId = 9,
                            PrimaryCategoryId = 2,
                            SubCategoryName = "Shoes Women"
                        },
                        new
                        {
                            SubCategoryId = 10,
                            PrimaryCategoryId = 3,
                            SubCategoryName = "Shoes Unisex"
                        },
                        new
                        {
                            SubCategoryId = 11,
                            PrimaryCategoryId = 1,
                            SubCategoryName = "Bags Men"
                        },
                        new
                        {
                            SubCategoryId = 12,
                            PrimaryCategoryId = 2,
                            SubCategoryName = "Bags Women"
                        },
                        new
                        {
                            SubCategoryId = 13,
                            PrimaryCategoryId = 3,
                            SubCategoryName = "Bags Unisex"
                        },
                        new
                        {
                            SubCategoryId = 14,
                            PrimaryCategoryId = 1,
                            SubCategoryName = "Suits"
                        },
                        new
                        {
                            SubCategoryId = 15,
                            PrimaryCategoryId = 1,
                            SubCategoryName = "Accessories Men"
                        },
                        new
                        {
                            SubCategoryId = 16,
                            PrimaryCategoryId = 2,
                            SubCategoryName = "Accessories Women"
                        },
                        new
                        {
                            SubCategoryId = 17,
                            PrimaryCategoryId = 3,
                            SubCategoryName = "Accessories Unisex"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Entities.ProductEntity", b =>
                {
                    b.HasOne("DataAccess.Models.Entities.ColorEntity", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId");

                    b.HasOne("DataAccess.Models.Entities.ProductInventoryEntity", "ProductInventory")
                        .WithOne("Product")
                        .HasForeignKey("DataAccess.Models.Entities.ProductEntity", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.Entities.SizeEntity", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId");

                    b.HasOne("DataAccess.Models.Entities.SubCategoryEntity", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("ProductInventory");

                    b.Navigation("Size");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("DataAccess.Models.Entities.SubCategoryEntity", b =>
                {
                    b.HasOne("DataAccess.Models.Entities.PrimaryCategoryEntity", "PrimaryCategory")
                        .WithMany()
                        .HasForeignKey("PrimaryCategoryId");

                    b.Navigation("PrimaryCategory");
                });

            modelBuilder.Entity("DataAccess.Models.Entities.ProductInventoryEntity", b =>
                {
                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}