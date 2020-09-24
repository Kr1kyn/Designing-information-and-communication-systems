using Microsoft.EntityFrameworkCore.Migrations;

namespace Unified_State_System_of_Entrants.Migrations
{
    public partial class AddRankedList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RankedListApplicants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HEIId = table.Column<int>(nullable: true),
                    TankedListJson = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RankedListApplicants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RankedListApplicants_HEIs_HEIId",
                        column: x => x.HEIId,
                        principalTable: "HEIs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RankedListApplicants_HEIId",
                table: "RankedListApplicants",
                column: "HEIId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RankedListApplicants");
        }
    }
}
