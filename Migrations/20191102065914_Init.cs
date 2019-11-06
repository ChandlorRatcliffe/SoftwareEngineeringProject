using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CashewWeb.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 150, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 150, nullable: false),
                    Password = table.Column<string>(maxLength: 150, nullable: false),
                    Role = table.Column<string>(maxLength: 250, nullable: true),
                    Skills = table.Column<string>(maxLength: 6000, nullable: true),
                    Theme = table.Column<string>(maxLength: 1000, nullable: true),
                    PicturePath = table.Column<string>(maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => new { x.Username, x.Email });
                });

            migrationBuilder.CreateTable(
                name: "OrganizationAbilities",
                columns: table => new
                {
                    Username = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 150, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    RemoveUser = table.Column<int>(nullable: false),
                    InviteUser = table.Column<int>(nullable: false),
                    PermissionsEditing = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationAbilities", x => new { x.Username, x.Email, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Licenses = table.Column<string>(maxLength: 50, nullable: true),
                    Activation = table.Column<int>(nullable: false),
                    Expiration = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    ParentId = table.Column<string>(nullable: false),
                    ChildId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.ParentId);
                });

            migrationBuilder.CreateTable(
                name: "ProjectAbilities",
                columns: table => new
                {
                    Username = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 150, nullable: false),
                    ProjectId = table.Column<string>(maxLength: 50, nullable: false),
                    AssignmentEditing = table.Column<int>(nullable: false),
                    ProjectEditing = table.Column<int>(nullable: false),
                    CreateProject = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectAbilities", x => new { x.Username, x.Email, x.ProjectId });
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<string>(maxLength: 50, nullable: false),
                    TaskId = table.Column<string>(maxLength: 50, nullable: true),
                    TaskDeadline = table.Column<DateTime>(maxLength: 50, nullable: false),
                    TaskDescription = table.Column<string>(maxLength: 65335, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "TaskAbilities",
                columns: table => new
                {
                    Username = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 150, nullable: false),
                    TaskId = table.Column<string>(maxLength: 50, nullable: false),
                    AssignmentEditing = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskAbilities", x => new { x.Username, x.Email, x.TaskId });
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskId = table.Column<string>(maxLength: 50, nullable: false),
                    TaskDeadline = table.Column<DateTime>(maxLength: 50, nullable: false),
                    TaskDescription = table.Column<string>(maxLength: 65335, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "OrganizationAbilities");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "ProjectAbilities");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "TaskAbilities");

            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
