using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Requisition.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_department",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_department", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_designation",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_designation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_employee",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    dept_Id = table.Column<int>(nullable: false),
                    desig_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_employee", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_employeeRoles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emp_Id = table.Column<int>(nullable: false),
                    Role_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_employeeRoles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_requisitionDetail",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email_Internal = table.Column<bool>(nullable: false),
                    Email_External = table.Column<bool>(nullable: false),
                    Internet_Restriction = table.Column<bool>(nullable: false),
                    Internet_NoRestriction = table.Column<bool>(nullable: false),
                    ReqFormID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_requisitionDetail", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_requisitionForm",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WindowsDomainAccount = table.Column<bool>(nullable: false),
                    EmailAddress = table.Column<bool>(nullable: false),
                    InternetAccess = table.Column<bool>(nullable: false),
                    As400 = table.Column<bool>(nullable: false),
                    HIS = table.Column<bool>(nullable: false),
                    EMR = table.Column<bool>(nullable: false),
                    Oracle_ebs = table.Column<bool>(nullable: false),
                    AnyOther = table.Column<bool>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_requisitionForm", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_roles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_user",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_user", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_department");

            migrationBuilder.DropTable(
                name: "tbl_designation");

            migrationBuilder.DropTable(
                name: "tbl_employee");

            migrationBuilder.DropTable(
                name: "tbl_employeeRoles");

            migrationBuilder.DropTable(
                name: "tbl_requisitionDetail");

            migrationBuilder.DropTable(
                name: "tbl_requisitionForm");

            migrationBuilder.DropTable(
                name: "tbl_roles");

            migrationBuilder.DropTable(
                name: "tbl_user");
        }
    }
}
