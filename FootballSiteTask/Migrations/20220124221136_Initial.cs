using Microsoft.EntityFrameworkCore.Migrations;

namespace FootballSiteTask.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "FootballPlayers",
                newName: "Surname");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "FootballPlayers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "FootballPlayers");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "FootballPlayers",
                newName: "FullName");
        }
    }
}
