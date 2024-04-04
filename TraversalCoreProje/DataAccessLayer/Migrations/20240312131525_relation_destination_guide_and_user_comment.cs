using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class relation_destination_guide_and_user_comment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationID",
                table: "Guides",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Commentts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Guides_DestinationID",
                table: "Guides",
                column: "DestinationID");

            migrationBuilder.CreateIndex(
                name: "IX_Commentts_AppUserID",
                table: "Commentts",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Commentts_AspNetUsers_AppUserID",
                table: "Commentts",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guides_Destinations_DestinationID",
                table: "Guides",
                column: "DestinationID",
                principalTable: "Destinations",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commentts_AspNetUsers_AppUserID",
                table: "Commentts");

            migrationBuilder.DropForeignKey(
                name: "FK_Guides_Destinations_DestinationID",
                table: "Guides");

            migrationBuilder.DropIndex(
                name: "IX_Guides_DestinationID",
                table: "Guides");

            migrationBuilder.DropIndex(
                name: "IX_Commentts_AppUserID",
                table: "Commentts");

            migrationBuilder.DropColumn(
                name: "DestinationID",
                table: "Guides");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Commentts");
        }
    }
}
