using Microsoft.EntityFrameworkCore.Migrations;

namespace CashewWeb.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 150, nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Role = table.Column<string>(maxLength: 250, nullable: true),
                    Skills = table.Column<string>(maxLength: 1024, nullable: true),
                    Theme = table.Column<string>(maxLength: 1024, nullable: true),
                    PicturePath = table.Column<string>(maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Username);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}
