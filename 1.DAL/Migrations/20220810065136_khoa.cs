using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class khoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 8, 10, 13, 51, 35, 990, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 8, 10, 13, 51, 35, 990, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateCreate",
                value: new DateTime(2022, 8, 10, 13, 51, 35, 990, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateCreate",
                value: new DateTime(2022, 8, 10, 13, 51, 35, 990, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 8, 10, 13, 51, 35, 990, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 8, 10, 13, 51, 35, 990, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 8, 10, 13, 51, 35, 990, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 8, 10, 13, 51, 35, 990, DateTimeKind.Local).AddTicks(9817));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 8, 9, 21, 16, 16, 532, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2022, 8, 9, 21, 16, 16, 532, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateCreate",
                value: new DateTime(2022, 8, 9, 21, 16, 16, 532, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateCreate",
                value: new DateTime(2022, 8, 9, 21, 16, 16, 532, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 8, 9, 21, 16, 16, 532, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 8, 9, 21, 16, 16, 532, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 8, 9, 21, 16, 16, 532, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 8, 9, 21, 16, 16, 532, DateTimeKind.Local).AddTicks(338));
        }
    }
}
