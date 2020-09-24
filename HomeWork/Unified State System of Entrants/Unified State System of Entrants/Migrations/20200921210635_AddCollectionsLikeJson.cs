using Microsoft.EntityFrameworkCore.Migrations;

namespace Unified_State_System_of_Entrants.Migrations
{
    public partial class AddCollectionsLikeJson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InformationLinksJson",
                table: "HEIs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationsJson",
                table: "HEIs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TagsForFilterJson",
                table: "HEIs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InformationLinksJson",
                table: "HEIs");

            migrationBuilder.DropColumn(
                name: "LocationsJson",
                table: "HEIs");

            migrationBuilder.DropColumn(
                name: "TagsForFilterJson",
                table: "HEIs");
        }
    }
}
