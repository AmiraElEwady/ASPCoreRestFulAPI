// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineProducts.API.DbContexts;

namespace OnlineProducts.API.Migrations
{
    [DbContext(typeof(ProductLibraryContext))]
    [Migration("20221031131353_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineProducts.API.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d29888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = new Guid("da2fd509-d754-4feb-8acd-c4f9ff13ba96"),
                            Name = "Cosmetics"
                        },
                        new
                        {
                            Id = new Guid("2902b664-1190-4c70-9915-b9c2d7680450"),
                            Name = "Sports"
                        },
                        new
                        {
                            Id = new Guid("112b566b-ba1f-404c-b2df-e2cde39ade09"),
                            Name = "Food and Beverage"
                        },
                        new
                        {
                            Id = new Guid("5b3632c0-7b12-4e80-9c8b-3398cba7ee05"),
                            Name = "Pets"
                        },
                        new
                        {
                            Id = new Guid("2aadd2df-7caf-45ab-9355-7f6732985a87"),
                            Name = "Clothes"
                        });
                });

            modelBuilder.Entity("OnlineProducts.API.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImgURL")
                        .HasColumnType("nvarchar(1500)")
                        .HasMaxLength(1500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("340c2c6b-0d1c-4b82-9d83-3cf635a3e62b"),
                            CategoryId = new Guid("d29888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            ImgURL = "https://www.mozu.com/docs/admin/help/Catalog/images/categories.png",
                            Name = "Headphones",
                            Price = "50",
                            Quantity = "1"
                        },
                        new
                        {
                            Id = new Guid("d94a64c2-2e8f-4162-9976-0ffe02d30767"),
                            CategoryId = new Guid("5b3632c0-7b12-4e80-9c8b-3398cba7ee05"),
                            ImgURL = "https://www.mozu.com/docs/admin/help/Catalog/images/categories.png",
                            Name = "Sweatpants",
                            Price = "1000",
                            Quantity = "53"
                        },
                        new
                        {
                            Id = new Guid("5b1c2b4d-45c7-402a-80c3-cc796ad49c6b"),
                            CategoryId = new Guid("da2fd509-d754-4feb-8acd-c4f9ff13ba96"),
                            ImgURL = "https://www.mozu.com/docs/admin/help/Catalog/images/categories.png",
                            Name = "Perfume",
                            Price = "1000",
                            Quantity = "100"
                        },
                        new
                        {
                            Id = new Guid("129f9ccb-149d-4d3c-ad4f-40100f38e918"),
                            CategoryId = new Guid("112b566b-ba1f-404c-b2df-e2cde39ade09"),
                            ImgURL = "https://www.mozu.com/docs/admin/help/Catalog/images/categories.png",
                            Name = "Milk",
                            Price = "5600",
                            Quantity = "6"
                        },
                        new
                        {
                            Id = new Guid("67280909-7892-4d3c-ad4f-40100f38e918"),
                            CategoryId = new Guid("5b3632c0-7b12-4e80-9c8b-3398cba7ee05"),
                            ImgURL = "https://www.mozu.com/docs/admin/help/Catalog/images/categories.png",
                            Name = "Cat Food",
                            Price = "100",
                            Quantity = "80"
                        },
                        new
                        {
                            Id = new Guid("07389765-7892-4d3c-ad4f-156728906354"),
                            CategoryId = new Guid("2aadd2df-7caf-45ab-9355-7f6732985a87"),
                            ImgURL = "https://www.mozu.com/docs/admin/help/Catalog/images/categories.png",
                            Name = "Jeans",
                            Price = "200",
                            Quantity = "8"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
