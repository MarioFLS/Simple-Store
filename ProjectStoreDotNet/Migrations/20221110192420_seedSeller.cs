using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectStoreDotNet.Migrations
{
    /// <inheritdoc />
    public partial class seedSeller : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "base_salary", "birth_date", "DepartmentId", "Email", "Name" },
                values: new object[,]
                {
                    { 1, 1000.0m, new DateTime(1998, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "bob@gmail.com", "Bob Brown" },
                    { 2, 3500.0m, new DateTime(1979, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "maria@gmail.com", "Maria Green" },
                    { 3, 2200.0m, new DateTime(1988, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "alex@gmail.com", "Alex Grey" },
                    { 4, 3000.0m, new DateTime(1993, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "martha@gmail.com", "Martha Red" },
                    { 5, 4000.0m, new DateTime(2000, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "donald@gmail.com", "Donald Blue" },
                    { 6, 3000.0m, new DateTime(1997, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "bob@gmail.com", "Alex Pink" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
