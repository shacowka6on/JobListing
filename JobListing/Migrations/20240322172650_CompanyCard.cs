using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobListing.Migrations
{
    public partial class CompanyCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "CompanyCardDescription",
                table: "Companies",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyDescription",
                table: "Companies",
                type: "nvarchar(3000)",
                maxLength: 3000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyCardDescription", "CompanyDescription" },
                values: new object[] { "We are the FirstCompanyTech. We specialize in techy stuff", "" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyCardDescription", "CompanyDescription" },
                values: new object[] { "We are the SecondCompanySolutions. We specialize in techy stuff solutions", "" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompanyCardDescription", "CompanyDescription" },
                values: new object[] { "We are the ThirdCompanyInnovations. We specialize in inovating techy stuff", "" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 17, 19, 26, 49, 948, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 19, 26, 49, 948, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 22, 13, 26, 49, 948, DateTimeKind.Local).AddTicks(7324));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyCardDescription",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CompanyDescription",
                table: "Companies");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaidVacationDays = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Seniority = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 15, 22, 3, 18, 634, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 18, 22, 3, 18, 634, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 16, 3, 18, 634, DateTimeKind.Local).AddTicks(8044));
        }
    }
}
