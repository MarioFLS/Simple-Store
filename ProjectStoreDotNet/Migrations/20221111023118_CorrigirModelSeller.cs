using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectStoreDotNet.Migrations
{
    /// <inheritdoc />
    public partial class CorrigirModelSeller : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "birth_date",
                table: "Sellers",
                newName: "Birth_Date");

            migrationBuilder.RenameColumn(
                name: "base_salary",
                table: "Sellers",
                newName: "Base_Salary");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Sellers",
                newName: "Department_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Birth_Date",
                table: "Sellers",
                newName: "birth_date");

            migrationBuilder.RenameColumn(
                name: "Base_Salary",
                table: "Sellers",
                newName: "base_salary");

            migrationBuilder.RenameColumn(
                name: "Department_Id",
                table: "Sellers",
                newName: "DepartmentId");
        }
    }
}
