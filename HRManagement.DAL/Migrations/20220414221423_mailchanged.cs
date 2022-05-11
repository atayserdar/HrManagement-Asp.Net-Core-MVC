using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRManagement.DAL.Migrations
{
    public partial class mailchanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BirthDay", "Email", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 1, 14, 23, 312, DateTimeKind.Local).AddTicks(2051), "atayserdar@gmail.com", new DateTime(2022, 4, 15, 1, 14, 23, 313, DateTimeKind.Local).AddTicks(3560) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BirthDay", "Email", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 1, 4, 21, 944, DateTimeKind.Local).AddTicks(5059), "kaanlokum@gmail.com", new DateTime(2022, 4, 15, 1, 4, 21, 945, DateTimeKind.Local).AddTicks(4867) });
        }
    }
}
