using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_DnD.Migrations
{
    /// <inheritdoc />
    public partial class CampagneMonstre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arme_Campagne_CampagneId",
                table: "Arme");

            migrationBuilder.DropForeignKey(
                name: "FK_Armure_Campagne_CampagneId",
                table: "Armure");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Campagne_CampagneId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Monstre_Campagne_CampagneId",
                table: "Monstre");

            migrationBuilder.DropForeignKey(
                name: "FK_Perso_Campagne_campagneId",
                table: "Perso");

            migrationBuilder.DropForeignKey(
                name: "FK_Race_Campagne_CampagneId",
                table: "Race");

            migrationBuilder.DropIndex(
                name: "IX_Race_CampagneId",
                table: "Race");

            migrationBuilder.DropIndex(
                name: "IX_Perso_campagneId",
                table: "Perso");

            migrationBuilder.DropIndex(
                name: "IX_Monstre_CampagneId",
                table: "Monstre");

            migrationBuilder.DropIndex(
                name: "IX_Classes_CampagneId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Armure_CampagneId",
                table: "Armure");

            migrationBuilder.DropIndex(
                name: "IX_Arme_CampagneId",
                table: "Arme");

            migrationBuilder.DropColumn(
                name: "CampagneId",
                table: "Race");

            migrationBuilder.DropColumn(
                name: "campagneId",
                table: "Perso");

            migrationBuilder.DropColumn(
                name: "CampagneId",
                table: "Monstre");

            migrationBuilder.DropColumn(
                name: "CampagneId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "CampagneId",
                table: "Armure");

            migrationBuilder.DropColumn(
                name: "CampagneId",
                table: "Arme");

            migrationBuilder.AddColumn<string>(
                name: "nom",
                table: "Skill",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Persoid",
                table: "Campagne",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ArmeCampagne",
                columns: table => new
                {
                    Armesid = table.Column<int>(type: "int", nullable: false),
                    CampagneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmeCampagne", x => new { x.Armesid, x.CampagneId });
                    table.ForeignKey(
                        name: "FK_ArmeCampagne_Arme_Armesid",
                        column: x => x.Armesid,
                        principalTable: "Arme",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArmeCampagne_Campagne_CampagneId",
                        column: x => x.CampagneId,
                        principalTable: "Campagne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ArmureCampagne",
                columns: table => new
                {
                    ArmuresId = table.Column<int>(type: "int", nullable: false),
                    CampagneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmureCampagne", x => new { x.ArmuresId, x.CampagneId });
                    table.ForeignKey(
                        name: "FK_ArmureCampagne_Armure_ArmuresId",
                        column: x => x.ArmuresId,
                        principalTable: "Armure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArmureCampagne_Campagne_CampagneId",
                        column: x => x.CampagneId,
                        principalTable: "Campagne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CampagneClasses",
                columns: table => new
                {
                    CampagneId = table.Column<int>(type: "int", nullable: false),
                    Classesid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampagneClasses", x => new { x.CampagneId, x.Classesid });
                    table.ForeignKey(
                        name: "FK_CampagneClasses_Campagne_CampagneId",
                        column: x => x.CampagneId,
                        principalTable: "Campagne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampagneClasses_Classes_Classesid",
                        column: x => x.Classesid,
                        principalTable: "Classes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CampagneEnchantement",
                columns: table => new
                {
                    CampagneId = table.Column<int>(type: "int", nullable: false),
                    EnchantementsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampagneEnchantement", x => new { x.CampagneId, x.EnchantementsId });
                    table.ForeignKey(
                        name: "FK_CampagneEnchantement_Campagne_CampagneId",
                        column: x => x.CampagneId,
                        principalTable: "Campagne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampagneEnchantement_Enchantement_EnchantementsId",
                        column: x => x.EnchantementsId,
                        principalTable: "Enchantement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CampagneMonstre",
                columns: table => new
                {
                    CampagneId = table.Column<int>(type: "int", nullable: false),
                    MonstresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampagneMonstre", x => new { x.CampagneId, x.MonstresId });
                    table.ForeignKey(
                        name: "FK_CampagneMonstre_Campagne_CampagneId",
                        column: x => x.CampagneId,
                        principalTable: "Campagne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampagneMonstre_Monstre_MonstresId",
                        column: x => x.MonstresId,
                        principalTable: "Monstre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CampagnePNJ",
                columns: table => new
                {
                    CampagneId = table.Column<int>(type: "int", nullable: false),
                    PNJsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampagnePNJ", x => new { x.CampagneId, x.PNJsId });
                    table.ForeignKey(
                        name: "FK_CampagnePNJ_Campagne_CampagneId",
                        column: x => x.CampagneId,
                        principalTable: "Campagne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampagnePNJ_PNJ_PNJsId",
                        column: x => x.PNJsId,
                        principalTable: "PNJ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CampagneQuete",
                columns: table => new
                {
                    CampagneId = table.Column<int>(type: "int", nullable: false),
                    QuetesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampagneQuete", x => new { x.CampagneId, x.QuetesId });
                    table.ForeignKey(
                        name: "FK_CampagneQuete_Campagne_CampagneId",
                        column: x => x.CampagneId,
                        principalTable: "Campagne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampagneQuete_Quete_QuetesId",
                        column: x => x.QuetesId,
                        principalTable: "Quete",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CampagneRace",
                columns: table => new
                {
                    CampagneId = table.Column<int>(type: "int", nullable: false),
                    RacesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampagneRace", x => new { x.CampagneId, x.RacesId });
                    table.ForeignKey(
                        name: "FK_CampagneRace_Campagne_CampagneId",
                        column: x => x.CampagneId,
                        principalTable: "Campagne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampagneRace_Race_RacesId",
                        column: x => x.RacesId,
                        principalTable: "Race",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Campagne_Persoid",
                table: "Campagne",
                column: "Persoid");

            migrationBuilder.CreateIndex(
                name: "IX_ArmeCampagne_CampagneId",
                table: "ArmeCampagne",
                column: "CampagneId");

            migrationBuilder.CreateIndex(
                name: "IX_ArmureCampagne_CampagneId",
                table: "ArmureCampagne",
                column: "CampagneId");

            migrationBuilder.CreateIndex(
                name: "IX_CampagneClasses_Classesid",
                table: "CampagneClasses",
                column: "Classesid");

            migrationBuilder.CreateIndex(
                name: "IX_CampagneEnchantement_EnchantementsId",
                table: "CampagneEnchantement",
                column: "EnchantementsId");

            migrationBuilder.CreateIndex(
                name: "IX_CampagneMonstre_MonstresId",
                table: "CampagneMonstre",
                column: "MonstresId");

            migrationBuilder.CreateIndex(
                name: "IX_CampagnePNJ_PNJsId",
                table: "CampagnePNJ",
                column: "PNJsId");

            migrationBuilder.CreateIndex(
                name: "IX_CampagneQuete_QuetesId",
                table: "CampagneQuete",
                column: "QuetesId");

            migrationBuilder.CreateIndex(
                name: "IX_CampagneRace_RacesId",
                table: "CampagneRace",
                column: "RacesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Campagne_Perso_Persoid",
                table: "Campagne",
                column: "Persoid",
                principalTable: "Perso",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campagne_Perso_Persoid",
                table: "Campagne");

            migrationBuilder.DropTable(
                name: "ArmeCampagne");

            migrationBuilder.DropTable(
                name: "ArmureCampagne");

            migrationBuilder.DropTable(
                name: "CampagneClasses");

            migrationBuilder.DropTable(
                name: "CampagneEnchantement");

            migrationBuilder.DropTable(
                name: "CampagneMonstre");

            migrationBuilder.DropTable(
                name: "CampagnePNJ");

            migrationBuilder.DropTable(
                name: "CampagneQuete");

            migrationBuilder.DropTable(
                name: "CampagneRace");

            migrationBuilder.DropIndex(
                name: "IX_Campagne_Persoid",
                table: "Campagne");

            migrationBuilder.DropColumn(
                name: "nom",
                table: "Skill");

            migrationBuilder.DropColumn(
                name: "Persoid",
                table: "Campagne");

            migrationBuilder.AddColumn<int>(
                name: "CampagneId",
                table: "Race",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "campagneId",
                table: "Perso",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CampagneId",
                table: "Monstre",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CampagneId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CampagneId",
                table: "Armure",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CampagneId",
                table: "Arme",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Race_CampagneId",
                table: "Race",
                column: "CampagneId");

            migrationBuilder.CreateIndex(
                name: "IX_Perso_campagneId",
                table: "Perso",
                column: "campagneId");

            migrationBuilder.CreateIndex(
                name: "IX_Monstre_CampagneId",
                table: "Monstre",
                column: "CampagneId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_CampagneId",
                table: "Classes",
                column: "CampagneId");

            migrationBuilder.CreateIndex(
                name: "IX_Armure_CampagneId",
                table: "Armure",
                column: "CampagneId");

            migrationBuilder.CreateIndex(
                name: "IX_Arme_CampagneId",
                table: "Arme",
                column: "CampagneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arme_Campagne_CampagneId",
                table: "Arme",
                column: "CampagneId",
                principalTable: "Campagne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Armure_Campagne_CampagneId",
                table: "Armure",
                column: "CampagneId",
                principalTable: "Campagne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Campagne_CampagneId",
                table: "Classes",
                column: "CampagneId",
                principalTable: "Campagne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Monstre_Campagne_CampagneId",
                table: "Monstre",
                column: "CampagneId",
                principalTable: "Campagne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Perso_Campagne_campagneId",
                table: "Perso",
                column: "campagneId",
                principalTable: "Campagne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Race_Campagne_CampagneId",
                table: "Race",
                column: "CampagneId",
                principalTable: "Campagne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
