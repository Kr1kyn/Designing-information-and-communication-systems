using Microsoft.EntityFrameworkCore.Migrations;

namespace Unified_State_System_of_Entrants.Migrations
{
    public partial class ChangeModelRankedList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RankedListApplicants_HEIs_HEIId",
                table: "RankedListApplicants");

            migrationBuilder.DropIndex(
                name: "IX_RankedListApplicants_HEIId",
                table: "RankedListApplicants");

            migrationBuilder.DropColumn(
                name: "HEIId",
                table: "RankedListApplicants");

            migrationBuilder.AddColumn<int>(
                name: "HEI_Id",
                table: "RankedListApplicants",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HEI_Id",
                table: "RankedListApplicants");

            migrationBuilder.AddColumn<int>(
                name: "HEIId",
                table: "RankedListApplicants",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RankedListApplicants_HEIId",
                table: "RankedListApplicants",
                column: "HEIId");

            migrationBuilder.AddForeignKey(
                name: "FK_RankedListApplicants_HEIs_HEIId",
                table: "RankedListApplicants",
                column: "HEIId",
                principalTable: "HEIs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
