using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectStoreDotNet.Migrations
{
    /// <inheritdoc />
    public partial class excludItemDepartament : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Departments_DepartmentId",
                table: "Sellers");

            migrationBuilder.DropIndex(
                name: "IX_Sellers_DepartmentId",
                table: "Sellers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Sellers_DepartmentId",
                table: "Sellers",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Departments_DepartmentId",
                table: "Sellers",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
