using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fifaAgapov23.Migrations
{
    /// <inheritdoc />
    public partial class AddTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Eagles" },
                    { 2, "Sharks" },
                    { 3, "Lions" },
                    { 4, "Knights" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Country", "DateOfBirth", "FirstName", "Gender", "LastName", "TeamId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1990, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "M", "Smith", 1 },
                    { 2, 2, new DateTime(1988, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", "M", "Williams", 2 },
                    { 3, 0, new DateTime(1992, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert", "M", "Johnson", 3 },
                    { 4, 1, new DateTime(1991, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", "M", "Brown", 4 },
                    { 5, 2, new DateTime(1989, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", "M", "Jones", 1 },
                    { 6, 0, new DateTime(1993, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", "M", "Miller", 2 },
                    { 7, 1, new DateTime(1987, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richard", "M", "Davis", 3 },
                    { 8, 2, new DateTime(1994, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joseph", "M", "Martinez", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
