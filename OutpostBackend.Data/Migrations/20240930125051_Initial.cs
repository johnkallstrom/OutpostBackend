using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OutpostBackend.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Published = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Movies" },
                    { 2, "Programming" },
                    { 3, "Cities" },
                    { 4, "Plants" },
                    { 5, "Games" }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Body", "CategoryId", "Published", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.", 3, new DateTime(2024, 9, 30, 14, 50, 51, 615, DateTimeKind.Local).AddTicks(5559), "City Post Title" },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.", 1, new DateTime(2024, 9, 30, 14, 50, 51, 615, DateTimeKind.Local).AddTicks(5624), "Movie Post Title" },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.", 5, new DateTime(2024, 9, 30, 14, 50, 51, 615, DateTimeKind.Local).AddTicks(5627), "Game Post Title" },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.", 5, new DateTime(2024, 9, 30, 14, 50, 51, 615, DateTimeKind.Local).AddTicks(5629), "Game Post Title" },
                    { 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.", 4, new DateTime(2024, 9, 30, 14, 50, 51, 615, DateTimeKind.Local).AddTicks(5632), "Plant Post Title" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_CategoryId",
                table: "Post",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
