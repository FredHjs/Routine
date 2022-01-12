using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Routine.Migrations
{
    public partial class UpdateCompanyProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Companies",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Industry",
                table: "Companies",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Product",
                table: "Companies",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("29e02aef-3144-4f2a-ad19-4499a2732955"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "China", "Internet", "Software" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("3b4c5c92-cc8c-905b-3563-fdbe7bd466b2"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "USA", "Internet", "Software" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("9babffca-c2aa-4ff6-a4ee-0a22682d239e"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "USA", "Internet", "Software" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("d502f792-b007-4262-823e-26abd4666dce"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "USA", "Software", "Software" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("eb94cf6f-e050-4fa0-3cc4-4ad6f2156e04"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "USA", "Aerospace", "Aircrafts" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Industry",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Product",
                table: "Companies");
        }
    }
}
