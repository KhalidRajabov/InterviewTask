using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterviewTask.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 8, 25, 19, 42, 19, 395, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthdate", "CreateDate" },
                values: new object[] { new DateTime(2022, 8, 25, 19, 42, 19, 395, DateTimeKind.Local).AddTicks(128), new DateTime(2022, 8, 25, 19, 42, 19, 395, DateTimeKind.Local).AddTicks(137) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 8, 25, 18, 6, 45, 546, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthdate", "CreateDate" },
                values: new object[] { new DateTime(2022, 8, 25, 18, 6, 45, 546, DateTimeKind.Local).AddTicks(8187), new DateTime(2022, 8, 25, 18, 6, 45, 546, DateTimeKind.Local).AddTicks(8194) });
        }
    }
}
