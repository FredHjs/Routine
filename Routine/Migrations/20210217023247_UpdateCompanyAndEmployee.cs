using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Routine.Migrations
{
    public partial class UpdateCompanyAndEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Companies_CompanyId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Employees",
                newName: "LastName");

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("3b4c5c92-cc8c-905b-3563-fdbe7bd466b2"), "Sells Everything", "Amazon" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("eb94cf6f-e050-4fa0-3cc4-4ad6f2156e04"), "High Tech company", "SpaceX" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("eedd02c5-46de-9dde-ec34-a44b2be1759a"), new Guid("3b4c5c92-cc8c-905b-3563-fdbe7bd466b2"), new DateTime(1982, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon17", "Lyn", 2, "Liu" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("18bc9ce1-8a71-64cd-fdd6-4021b4becd0d"), new Guid("eb94cf6f-e050-4fa0-3cc4-4ad6f2156e04"), new DateTime(1978, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "SpaceX867", "George", 2, "Li" });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Companies_CompanyId",
                table: "Employees",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Companies_CompanyId",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("18bc9ce1-8a71-64cd-fdd6-4021b4becd0d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("eedd02c5-46de-9dde-ec34-a44b2be1759a"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("3b4c5c92-cc8c-905b-3563-fdbe7bd466b2"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("eb94cf6f-e050-4fa0-3cc4-4ad6f2156e04"));

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Employees",
                newName: "lastName");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Companies_CompanyId",
                table: "Employees",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
