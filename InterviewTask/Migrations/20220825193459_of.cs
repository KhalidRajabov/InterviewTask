using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterviewTask.Migrations
{
    public partial class of : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 8, 25, 23, 34, 59, 290, DateTimeKind.Local).AddTicks(7128));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 8, 25, 20, 35, 30, 365, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthdate", "CreateDate" },
                values: new object[] { new DateTime(2022, 8, 25, 20, 35, 30, 365, DateTimeKind.Local).AddTicks(5577), new DateTime(2022, 8, 25, 20, 35, 30, 365, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthdate", "CreateDate" },
                values: new object[] { new DateTime(2022, 8, 25, 20, 35, 30, 365, DateTimeKind.Local).AddTicks(5605), new DateTime(2022, 8, 25, 20, 35, 30, 365, DateTimeKind.Local).AddTicks(5605) });
        }
    }
}
