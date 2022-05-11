using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRManagement.DAL.Migrations
{
    public partial class employeechanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BirthDay", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 1, 40, 4, 46, DateTimeKind.Local).AddTicks(8776), new DateTime(2022, 4, 15, 1, 40, 4, 47, DateTimeKind.Local).AddTicks(7361) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BirthDay", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 14, 17, 10, 55, 408, DateTimeKind.Local).AddTicks(1278), new DateTime(2022, 4, 14, 17, 10, 55, 409, DateTimeKind.Local).AddTicks(4293) });
        }
    }
}
