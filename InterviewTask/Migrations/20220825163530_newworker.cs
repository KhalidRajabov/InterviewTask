using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterviewTask.Migrations
{
    public partial class newworker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Birthdate", "CreateDate", "DepartmentId", "Name", "Surname" },
                values: new object[] { 2, new DateTime(2022, 8, 25, 20, 35, 30, 365, DateTimeKind.Local).AddTicks(5605), new DateTime(2022, 8, 25, 20, 35, 30, 365, DateTimeKind.Local).AddTicks(5605), 1, "Felix", "Paw" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 8, 25, 19, 46, 12, 235, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthdate", "CreateDate" },
                values: new object[] { new DateTime(2022, 8, 25, 19, 46, 12, 235, DateTimeKind.Local).AddTicks(4993), new DateTime(2022, 8, 25, 19, 46, 12, 235, DateTimeKind.Local).AddTicks(5003) });
        }
    }
}
