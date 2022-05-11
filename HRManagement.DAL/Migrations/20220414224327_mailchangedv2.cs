using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRManagement.DAL.Migrations
{
    public partial class mailchangedv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BirthDay", "Email", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 1, 43, 26, 473, DateTimeKind.Local).AddTicks(6663), "kaanlokum@gmail.com", new DateTime(2022, 4, 15, 1, 43, 26, 474, DateTimeKind.Local).AddTicks(9367) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BirthDay", "Email", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 1, 40, 4, 46, DateTimeKind.Local).AddTicks(8776), "atayserdar@gmail.com", new DateTime(2022, 4, 15, 1, 40, 4, 47, DateTimeKind.Local).AddTicks(7361) });
        }
    }
}
