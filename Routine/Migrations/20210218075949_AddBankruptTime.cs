using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Routine.Migrations
{
    public partial class AddBankruptTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BankRuptTime",
                table: "Companies",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankRuptTime",
                table: "Companies");
        }
    }
}
