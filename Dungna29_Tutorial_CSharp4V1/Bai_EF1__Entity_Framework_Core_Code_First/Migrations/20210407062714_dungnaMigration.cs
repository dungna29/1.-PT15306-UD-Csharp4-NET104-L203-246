using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bai_EF1__Entity_Framework_Core_Code_First.Migrations
{
    public partial class dungnaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    content = table.Column<string>(nullable: true),
                    disable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    price = table.Column<float>(nullable: false),
                    discount = table.Column<float>(nullable: false),
                    quantity = table.Column<int>(nullable: false),
                    shop = table.Column<int>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    publishedAt = table.Column<DateTime>(nullable: false),
                    startsAt = table.Column<DateTime>(nullable: false),
                    content = table.Column<string>(nullable: true),
                    disable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
