using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SibersTestTask.Migrations
{
    /// <inheritdoc />
    public partial class JOJ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    IdEmployee = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.IdEmployee);
                });

            migrationBuilder.CreateTable(
                name: "Leader",
                columns: table => new
                {
                    IdLeadProject = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmployee = table.Column<int>(type: "int", nullable: false),
                    EmployeeIdEmployee = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leader", x => x.IdLeadProject);
                    table.ForeignKey(
                        name: "FK_Leader_Employee_EmployeeIdEmployee",
                        column: x => x.EmployeeIdEmployee,
                        principalTable: "Employee",
                        principalColumn: "IdEmployee");
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    IdProject = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLeadProject = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    NameProject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameContractorCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameClientCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaderIdLeadProject = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.IdProject);
                    table.ForeignKey(
                        name: "FK_Project_Leader_LeaderIdLeadProject",
                        column: x => x.LeaderIdLeadProject,
                        principalTable: "Leader",
                        principalColumn: "IdLeadProject");
                });

            migrationBuilder.CreateTable(
                name: "EmployeesInProject",
                columns: table => new
                {
                    IdEmployee = table.Column<int>(type: "int", nullable: false),
                    IdProject = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesInProject", x => new { x.IdEmployee, x.IdProject });
                    table.ForeignKey(
                        name: "FK_EmployeesInProject_Employee_IdEmployee",
                        column: x => x.IdEmployee,
                        principalTable: "Employee",
                        principalColumn: "IdEmployee",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeesInProject_Project_IdProject",
                        column: x => x.IdProject,
                        principalTable: "Project",
                        principalColumn: "IdProject",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesInProject_IdProject",
                table: "EmployeesInProject",
                column: "IdProject");

            migrationBuilder.CreateIndex(
                name: "IX_Leader_EmployeeIdEmployee",
                table: "Leader",
                column: "EmployeeIdEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_Project_LeaderIdLeadProject",
                table: "Project",
                column: "LeaderIdLeadProject");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeesInProject");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Leader");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
