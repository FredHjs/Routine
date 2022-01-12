using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Routine.Migrations
{
    public partial class AddEmployeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "lastName" },
                values: new object[] { new Guid("e0dae939-4275-4df9-95d5-317b72ae4526"), new Guid("d502f792-b007-4262-823e-26abd4666dce"), new DateTime(1976, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "MSFT231", "Nick", 1, "Carton" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "lastName" },
                values: new object[] { new Guid("2e996af1-654e-4a07-9d38-0e1b0a1ab8cc"), new Guid("d502f792-b007-4262-823e-26abd4666dce"), new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "MSFT235", "Vince", 1, "Carter" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "lastName" },
                values: new object[] { new Guid("c83404ff-c8a4-45a9-8f89-ce727a70f080"), new Guid("9babffca-c2aa-4ff6-a4ee-0a22682d239e"), new DateTime(1991, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gole167", "Fred", 1, "Huang" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2e996af1-654e-4a07-9d38-0e1b0a1ab8cc"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c83404ff-c8a4-45a9-8f89-ce727a70f080"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e0dae939-4275-4df9-95d5-317b72ae4526"));
        }
    }
}
