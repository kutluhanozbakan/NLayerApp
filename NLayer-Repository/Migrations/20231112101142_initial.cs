using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NLayer_Repository.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeature_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pencils", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Books", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NoteBooks", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Name", "Price", "Stock", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 11, 12, 13, 11, 42, 66, DateTimeKind.Local).AddTicks(2539), "Uçlu Kalem", 10m, 200, null },
                    { 2, 1, new DateTime(2023, 11, 12, 13, 11, 42, 66, DateTimeKind.Local).AddTicks(2556), "Kurşun Kalem", 3m, 450, null },
                    { 3, 1, new DateTime(2023, 11, 12, 13, 11, 42, 66, DateTimeKind.Local).AddTicks(2558), "Tükenmez Kalem", 22m, 120, null },
                    { 4, 2, new DateTime(2023, 11, 12, 13, 11, 42, 66, DateTimeKind.Local).AddTicks(2559), "Matematik", 10m, 200, null },
                    { 5, 2, new DateTime(2023, 11, 12, 13, 11, 42, 66, DateTimeKind.Local).AddTicks(2560), "Fizik", 3m, 450, null },
                    { 6, 2, new DateTime(2023, 11, 12, 13, 11, 42, 66, DateTimeKind.Local).AddTicks(2561), "Kimya", 22m, 120, null },
                    { 7, 3, new DateTime(2023, 11, 12, 13, 11, 42, 66, DateTimeKind.Local).AddTicks(2562), "Spiralli Defter", 10m, 200, null },
                    { 8, 3, new DateTime(2023, 11, 12, 13, 11, 42, 66, DateTimeKind.Local).AddTicks(2563), "Spiralsiz Defter", 3m, 450, null },
                    { 9, 3, new DateTime(2023, 11, 12, 13, 11, 42, 66, DateTimeKind.Local).AddTicks(2564), "Resim Defteri", 22m, 120, null }
                });

            migrationBuilder.InsertData(
                table: "ProductFeature",
                columns: new[] { "Id", "Color", "Height", "ProductId", "Width" },
                values: new object[,]
                {
                    { 1, "Kırmızı", 100, 1, 200 },
                    { 2, "Mavi", 100, 2, 300 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeature_ProductId",
                table: "ProductFeature",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductFeature");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
