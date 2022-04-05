using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlatformHR.Migrations
{
    public partial class DatabaseInitializer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "ContactNumber", "DateOfBirth", "Email", "FullName" },
                values: new object[] { 1, 641234567, new DateTime(1988, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "bl@gmail.com", "Branko Lazic" });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "ContactNumber", "DateOfBirth", "Email", "FullName" },
                values: new object[] { 2, 641234567, new DateTime(1986, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "lm@gmail.com", "Luka Mitrovic" });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "ContactNumber", "DateOfBirth", "Email", "FullName" },
                values: new object[] { 3, 641234567, new DateTime(1982, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ms@gmail.com", "Marko Simonovic" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
