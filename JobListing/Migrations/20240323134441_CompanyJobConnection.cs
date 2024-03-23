using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobListing.Migrations
{
    public partial class CompanyJobConnection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyId", "CreatedOn" },
                values: new object[] { 1, new DateTime(2024, 3, 18, 15, 44, 40, 680, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyId", "CreatedOn" },
                values: new object[] { 1, new DateTime(2024, 3, 21, 15, 44, 40, 680, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompanyId", "CreatedOn" },
                values: new object[] { 1, new DateTime(2024, 3, 23, 9, 44, 40, 680, DateTimeKind.Local).AddTicks(3168) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyId", "CreatedOn" },
                values: new object[] { 0, new DateTime(2024, 3, 17, 22, 22, 58, 309, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyId", "CreatedOn" },
                values: new object[] { 0, new DateTime(2024, 3, 20, 22, 22, 58, 309, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompanyId", "CreatedOn" },
                values: new object[] { 0, new DateTime(2024, 3, 22, 16, 22, 58, 309, DateTimeKind.Local).AddTicks(8678) });
        }
    }
}
