using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterviewTask.Migrations
{
    public partial class of2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2022, 8, 26, 1, 55, 44, 16, DateTimeKind.Local).AddTicks(1349), "Developers" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreateDate", "Name" },
                values: new object[] { 2, new DateTime(2022, 8, 26, 1, 55, 44, 16, DateTimeKind.Local).AddTicks(1385), "HR Manager" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthdate", "CreateDate" },
                values: new object[] { new DateTime(2022, 8, 26, 1, 55, 44, 16, DateTimeKind.Local).AddTicks(1309), new DateTime(2022, 8, 26, 1, 55, 44, 16, DateTimeKind.Local).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthdate", "CreateDate" },
                values: new object[] { new DateTime(2022, 8, 26, 1, 55, 44, 16, DateTimeKind.Local).AddTicks(1339), new DateTime(2022, 8, 26, 1, 55, 44, 16, DateTimeKind.Local).AddTicks(1339) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTime(2022, 8, 25, 23, 34, 59, 290, DateTimeKind.Local).AddTicks(7128), "Dev" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthdate", "CreateDate" },
                values: new object[] { new DateTime(2022, 8, 25, 23, 34, 59, 290, DateTimeKind.Local).AddTicks(7091), new DateTime(2022, 8, 25, 23, 34, 59, 290, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthdate", "CreateDate" },
                values: new object[] { new DateTime(2022, 8, 25, 23, 34, 59, 290, DateTimeKind.Local).AddTicks(7116), new DateTime(2022, 8, 25, 23, 34, 59, 290, DateTimeKind.Local).AddTicks(7117) });
        }
    }
}
