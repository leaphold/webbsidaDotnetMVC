using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace uppgift1.Migrations
{
    /// <inheritdoc />
    public partial class SeedCourseTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "EndDate", "StartDate", "Title" },
                values: new object[,]
                {
                    { 1, "C#", 2000, 2000, "C#" },
                    { 2, "Java", 2000, 2000, "Java" },
                    { 3, "Python", 2000, 2000, "Python" },
                    { 4, "C++", 2000, 2000, "C++" },
                    { 5, "C", 2000, 2000, "C" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
