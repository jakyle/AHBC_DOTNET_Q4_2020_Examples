using Microsoft.EntityFrameworkCore.Migrations;

namespace Make_your_own_api.Migrations
{
    public partial class updateId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StarWarsCharacterId",
                table: "Fans",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StarWarsCharacterId",
                table: "Fans");
        }
    }
}
