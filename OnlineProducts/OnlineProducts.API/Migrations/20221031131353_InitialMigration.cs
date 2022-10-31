using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineProducts.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Price = table.Column<string>(maxLength: 10, nullable: true),
                    Quantity = table.Column<string>(maxLength: 10, nullable: true),
                    ImgURL = table.Column<string>(maxLength: 1500, nullable: true),
                    CategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d29888e9-2ba9-473a-a40f-e38cb54f9b35"), "Electronics" },
                    { new Guid("da2fd509-d754-4feb-8acd-c4f9ff13ba96"), "Cosmetics" },
                    { new Guid("2902b664-1190-4c70-9915-b9c2d7680450"), "Sports" },
                    { new Guid("112b566b-ba1f-404c-b2df-e2cde39ade09"), "Food and Beverage" },
                    { new Guid("5b3632c0-7b12-4e80-9c8b-3398cba7ee05"), "Pets" },
                    { new Guid("2aadd2df-7caf-45ab-9355-7f6732985a87"), "Clothes" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ImgURL", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("340c2c6b-0d1c-4b82-9d83-3cf635a3e62b"), new Guid("d29888e9-2ba9-473a-a40f-e38cb54f9b35"), "https://www.mozu.com/docs/admin/help/Catalog/images/categories.png", "Headphones", "50", "1" },
                    { new Guid("d94a64c2-2e8f-4162-9976-0ffe02d30767"), new Guid("5b3632c0-7b12-4e80-9c8b-3398cba7ee05"), "https://www.mozu.com/docs/admin/help/Catalog/images/categories.png", "Sweatpants", "1000", "53" },
                    { new Guid("5b1c2b4d-45c7-402a-80c3-cc796ad49c6b"), new Guid("da2fd509-d754-4feb-8acd-c4f9ff13ba96"), "https://www.mozu.com/docs/admin/help/Catalog/images/categories.png", "Perfume", "1000", "100" },
                    { new Guid("129f9ccb-149d-4d3c-ad4f-40100f38e918"), new Guid("112b566b-ba1f-404c-b2df-e2cde39ade09"), "https://www.mozu.com/docs/admin/help/Catalog/images/categories.png", "Milk", "5600", "6" },
                    { new Guid("67280909-7892-4d3c-ad4f-40100f38e918"), new Guid("5b3632c0-7b12-4e80-9c8b-3398cba7ee05"), "https://www.mozu.com/docs/admin/help/Catalog/images/categories.png", "Cat Food", "100", "80" },
                    { new Guid("07389765-7892-4d3c-ad4f-156728906354"), new Guid("2aadd2df-7caf-45ab-9355-7f6732985a87"), "https://www.mozu.com/docs/admin/help/Catalog/images/categories.png", "Jeans", "200", "8" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
