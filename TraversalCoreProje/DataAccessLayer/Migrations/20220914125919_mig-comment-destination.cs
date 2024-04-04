using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migcommentdestination : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Commentts_DestinationID",
                table: "Commentts",
                column: "DestinationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Commentts_Destinations_DestinationID",
                table: "Commentts",
                column: "DestinationID",
                principalTable: "Destinations",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commentts_Destinations_DestinationID",
                table: "Commentts");

            migrationBuilder.DropIndex(
                name: "IX_Commentts_DestinationID",
                table: "Commentts");
        }
    }
}
