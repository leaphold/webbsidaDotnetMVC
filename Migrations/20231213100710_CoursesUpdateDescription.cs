using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace uppgift1.Migrations
{
    /// <inheritdoc />
    public partial class CoursesUpdateDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Versatile programming language for building modern, scalable applications in .NET.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Object-oriented language known for portability, performance, and extensive libraries.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "High-level, versatile language emphasizing readability and ease of use.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Powerful language for system programming, game development, and high-performance applications.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Foundational programming language influencing many others; efficient and low-level.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "C#");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Java");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Python");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "C++");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "C");
        }
    }
}
