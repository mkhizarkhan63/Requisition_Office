using Microsoft.EntityFrameworkCore.Migrations;

namespace Requisition.Migrations
{
    public partial class rd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "tbl_requisitionDetail");

            migrationBuilder.AddColumn<int>(
                name: "empID",
                table: "tbl_requisitionDetail",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "empID",
                table: "tbl_requisitionDetail");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "tbl_requisitionDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
