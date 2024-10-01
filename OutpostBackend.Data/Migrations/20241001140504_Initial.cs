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
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
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
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
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
                table: "Posts",
                columns: new[] { "Id", "Body", "CategoryId", "Published", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.", 3, new DateTime(2024, 10, 1, 16, 5, 4, 43, DateTimeKind.Local).AddTicks(5199), "City Post Title" },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.", 1, new DateTime(2024, 10, 1, 16, 5, 4, 43, DateTimeKind.Local).AddTicks(5259), "Movie Post Title" },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.", 5, new DateTime(2024, 10, 1, 16, 5, 4, 43, DateTimeKind.Local).AddTicks(5262), "Game Post Title" },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.", 5, new DateTime(2024, 10, 1, 16, 5, 4, 43, DateTimeKind.Local).AddTicks(5264), "Game Post Title" },
                    { 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.", 4, new DateTime(2024, 10, 1, 16, 5, 4, 43, DateTimeKind.Local).AddTicks(5266), "Plant Post Title" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
