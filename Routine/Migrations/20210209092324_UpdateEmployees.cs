using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Routine.Migrations
{
    public partial class UpdateEmployees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2e996af1-654e-4a07-9d38-0e1b0a1ab8cc"),
                columns: new[] { "DateOfBirth", "EmployeeNo", "FirstName", "lastName" },
                values: new object[] { new DateTime(1976, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "MSFT231", "Nick", "Carton" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e0dae939-4275-4df9-95d5-317b72ae4526"),
                columns: new[] { "DateOfBirth", "EmployeeNo", "FirstName", "lastName" },
                values: new object[] { new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "MSFT235", "Vince", "Carter" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2e996af1-654e-4a07-9d38-0e1b0a1ab8cc"),
                columns: new[] { "DateOfBirth", "EmployeeNo", "FirstName", "lastName" },
                values: new object[] { new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "MSFT235", "Vince", "Carter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e0dae939-4275-4df9-95d5-317b72ae4526"),
                columns: new[] { "DateOfBirth", "EmployeeNo", "FirstName", "lastName" },
                values: new object[] { new DateTime(1976, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "MSFT231", "Nick", "Carton" });
        }
    }
}
