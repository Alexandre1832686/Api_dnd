using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_DnD.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CampagneRace_Campagne_CampagneId",
                table: "CampagneRace");

            migrationBuilder.DropForeignKey(
                name: "FK_Monstre_Race_RaceId",
                table: "Monstre");

            migrationBuilder.DropIndex(
                name: "IX_Monstre_RaceId",
                table: "Monstre");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Monstre");

            migrationBuilder.RenameColumn(
                name: "CampagneId",
                table: "CampagneRace",
                newName: "CampagnesId");

            migrationBuilder.AddColumn<int>(
                name: "BonusCharisma",
                table: "Race",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "StealthDisadvantage",
                table: "Armure",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AddForeignKey(
                name: "FK_CampagneRace_Campagne_CampagnesId",
                table: "CampagneRace",
                column: "CampagnesId",
                principalTable: "Campagne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CampagneRace_Campagne_CampagnesId",
                table: "CampagneRace");

            migrationBuilder.DropColumn(
                name: "BonusCharisma",
                table: "Race");

            migrationBuilder.RenameColumn(
                name: "CampagnesId",
                table: "CampagneRace",
                newName: "CampagneId");

            migrationBuilder.AddColumn<int>(
                name: "RaceId",
                table: "Monstre",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<bool>(
                name: "StealthDisadvantage",
                table: "Armure",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Monstre_RaceId",
                table: "Monstre",
                column: "RaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_CampagneRace_Campagne_CampagneId",
                table: "CampagneRace",
                column: "CampagneId",
                principalTable: "Campagne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Monstre_Race_RaceId",
                table: "Monstre",
                column: "RaceId",
                principalTable: "Race",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
