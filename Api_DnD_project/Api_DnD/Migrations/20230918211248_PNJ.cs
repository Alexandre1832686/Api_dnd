using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_DnD.Migrations
{
    /// <inheritdoc />
    public partial class PNJ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perso_Arme_armeid",
                table: "Perso");

            migrationBuilder.RenameColumn(
                name: "armeid",
                table: "Perso",
                newName: "armeId");

            migrationBuilder.RenameIndex(
                name: "IX_Perso_armeid",
                table: "Perso",
                newName: "IX_Perso_armeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Perso_Arme_armeId",
                table: "Perso",
                column: "armeId",
                principalTable: "Arme",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perso_Arme_armeId",
                table: "Perso");

            migrationBuilder.RenameColumn(
                name: "armeId",
                table: "Perso",
                newName: "armeid");

            migrationBuilder.RenameIndex(
                name: "IX_Perso_armeId",
                table: "Perso",
                newName: "IX_Perso_armeid");

            migrationBuilder.AddForeignKey(
                name: "FK_Perso_Arme_armeid",
                table: "Perso",
                column: "armeid",
                principalTable: "Arme",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
