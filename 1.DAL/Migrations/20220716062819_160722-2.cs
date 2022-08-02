using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class _1607222 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImportHistory_Employees_EmployeeID",
                table: "ImportHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportHistory_Products_ProductID",
                table: "ImportHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImportHistory",
                table: "ImportHistory");

            migrationBuilder.RenameTable(
                name: "ImportHistory",
                newName: "ImportHistories");

            migrationBuilder.RenameIndex(
                name: "IX_ImportHistory_ProductID",
                table: "ImportHistories",
                newName: "IX_ImportHistories_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_ImportHistory_EmployeeID",
                table: "ImportHistories",
                newName: "IX_ImportHistories_EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImportHistories",
                table: "ImportHistories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImportHistories_Employees_EmployeeID",
                table: "ImportHistories",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImportHistories_Products_ProductID",
                table: "ImportHistories",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImportHistories_Employees_EmployeeID",
                table: "ImportHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportHistories_Products_ProductID",
                table: "ImportHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImportHistories",
                table: "ImportHistories");

            migrationBuilder.RenameTable(
                name: "ImportHistories",
                newName: "ImportHistory");

            migrationBuilder.RenameIndex(
                name: "IX_ImportHistories_ProductID",
                table: "ImportHistory",
                newName: "IX_ImportHistory_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_ImportHistories_EmployeeID",
                table: "ImportHistory",
                newName: "IX_ImportHistory_EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImportHistory",
                table: "ImportHistory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImportHistory_Employees_EmployeeID",
                table: "ImportHistory",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImportHistory_Products_ProductID",
                table: "ImportHistory",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
