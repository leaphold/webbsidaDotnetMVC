using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace uppgift1.Migrations
{
    /// <inheritdoc />
    public partial class CoursesUpdateDateToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StartDate",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "EndDate",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { "2022-06-15", "2020-09-01" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { "2022-06-15", "2020-09-01" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { "2022-06-15", "2020-09-01" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { "2022-06-15", "2020-09-01" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { "2022-06-15", "2020-09-01" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StartDate",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "EndDate",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { 2000, 2000 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { 2000, 2000 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { 2000, 2000 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { 2000, 2000 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { 2000, 2000 });
        }
    }
}
