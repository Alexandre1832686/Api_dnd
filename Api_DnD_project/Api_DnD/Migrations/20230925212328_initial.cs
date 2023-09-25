using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_DnD.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Campagne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Desc = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campagne", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Enchantement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Modif = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enchantement", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Key",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ApiKey = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Role = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Key", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PNJ",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Bouche = table.Column<int>(type: "int", nullable: false),
                    Nez = table.Column<int>(type: "int", nullable: false),
                    Barbe = table.Column<int>(type: "int", nullable: false),
                    Cheveux = table.Column<int>(type: "int", nullable: false),
                    Sourcil = table.Column<int>(type: "int", nullable: false),
                    Tete = table.Column<int>(type: "int", nullable: false),
                    Yeux1 = table.Column<int>(type: "int", nullable: false),
                    Yeux2 = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PNJ", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Desc = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dammage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DammageType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dc = table.Column<int>(type: "int", nullable: false),
                    DcType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CampagneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actions_Campagne_CampagneId",
                        column: x => x.CampagneId,
                        principalTable: "Campagne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hitDie = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    primaryAbility = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CampagneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Classes_Campagne_CampagneId",
                        column: x => x.CampagneId,
                        principalTable: "Campagne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Race",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BonusPV = table.Column<int>(type: "int", nullable: false),
                    BonusDex = table.Column<int>(type: "int", nullable: false),
                    BonusForce = table.Column<int>(type: "int", nullable: false),
                    BonusIntel = table.Column<int>(type: "int", nullable: false),
                    BonusWisdom = table.Column<int>(type: "int", nullable: false),
                    BonusConsti = table.Column<int>(type: "int", nullable: false),
                    CampagneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Race", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Race_Campagne_CampagneId",
                        column: x => x.CampagneId,
                        principalTable: "Campagne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Arme",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BonusJet = table.Column<int>(type: "int", nullable: false),
                    BonusForce = table.Column<int>(type: "int", nullable: false),
                    Nom = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EnchantementId = table.Column<int>(type: "int", nullable: false),
                    CampagneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arme", x => x.id);
                    table.ForeignKey(
                        name: "FK_Arme_Campagne_CampagneId",
                        column: x => x.CampagneId,
                        principalTable: "Campagne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Arme_Enchantement_EnchantementId",
                        column: x => x.EnchantementId,
                        principalTable: "Enchantement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Armure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ac = table.Column<int>(type: "int", nullable: false),
                    DexBonus = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MaxDexMod = table.Column<int>(type: "int", nullable: false),
                    StealthDisadvantage = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EnchantId = table.Column<int>(type: "int", nullable: false),
                    CampagneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Armure_Campagne_CampagneId",
                        column: x => x.CampagneId,
                        principalTable: "Campagne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Armure_Enchantement_EnchantId",
                        column: x => x.EnchantId,
                        principalTable: "Enchantement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Quete",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PnjId = table.Column<int>(type: "int", nullable: false),
                    DescriptionQuete = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reward = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quete", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quete_PNJ_PnjId",
                        column: x => x.PnjId,
                        principalTable: "PNJ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Monstre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Size = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RaceId = table.Column<int>(type: "int", nullable: false),
                    ArmorClass = table.Column<int>(type: "int", nullable: false),
                    HitPoint = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    FlySpeed = table.Column<int>(type: "int", nullable: false),
                    ClimbSpeed = table.Column<int>(type: "int", nullable: false),
                    Str = table.Column<int>(type: "int", nullable: false),
                    Dex = table.Column<int>(type: "int", nullable: false),
                    Con = table.Column<int>(type: "int", nullable: false),
                    Intel = table.Column<int>(type: "int", nullable: false),
                    Wis = table.Column<int>(type: "int", nullable: false),
                    Cha = table.Column<int>(type: "int", nullable: false),
                    DarkVision = table.Column<int>(type: "int", nullable: false),
                    Challenge = table.Column<float>(type: "float", nullable: false),
                    Lang = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DammageResistance = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DammageImmunities = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConditionImmunities = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CampagneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monstre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monstre_Campagne_CampagneId",
                        column: x => x.CampagneId,
                        principalTable: "Campagne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Monstre_Race_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Race",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Perso",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IrlJoueur = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nom = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    inspiration = table.Column<int>(type: "int", nullable: false),
                    armureId = table.Column<int>(type: "int", nullable: false),
                    arme1id = table.Column<int>(type: "int", nullable: false),
                    arme2id = table.Column<int>(type: "int", nullable: false),
                    arme3id = table.Column<int>(type: "int", nullable: false),
                    classesid = table.Column<int>(type: "int", nullable: false),
                    raceId = table.Column<int>(type: "int", nullable: false),
                    personalitetrait = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ideal = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bonds = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    flaws = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    niv = table.Column<int>(type: "int", nullable: false),
                    campagneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perso", x => x.id);
                    table.ForeignKey(
                        name: "FK_Perso_Arme_arme1id",
                        column: x => x.arme1id,
                        principalTable: "Arme",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perso_Arme_arme2id",
                        column: x => x.arme2id,
                        principalTable: "Arme",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perso_Arme_arme3id",
                        column: x => x.arme3id,
                        principalTable: "Arme",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perso_Armure_armureId",
                        column: x => x.armureId,
                        principalTable: "Armure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perso_Campagne_campagneId",
                        column: x => x.campagneId,
                        principalTable: "Campagne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perso_Classes_classesid",
                        column: x => x.classesid,
                        principalTable: "Classes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perso_Race_raceId",
                        column: x => x.raceId,
                        principalTable: "Race",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ActionMonstre",
                columns: table => new
                {
                    ActionsId = table.Column<int>(type: "int", nullable: false),
                    MonstresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionMonstre", x => new { x.ActionsId, x.MonstresId });
                    table.ForeignKey(
                        name: "FK_ActionMonstre_Actions_ActionsId",
                        column: x => x.ActionsId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActionMonstre_Monstre_MonstresId",
                        column: x => x.MonstresId,
                        principalTable: "Monstre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    desc = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Persoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.id);
                    table.ForeignKey(
                        name: "FK_Skill_Perso_Persoid",
                        column: x => x.Persoid,
                        principalTable: "Perso",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ActionMonstre_MonstresId",
                table: "ActionMonstre",
                column: "MonstresId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_CampagneId",
                table: "Actions",
                column: "CampagneId");

            migrationBuilder.CreateIndex(
                name: "IX_Arme_CampagneId",
                table: "Arme",
                column: "CampagneId");

            migrationBuilder.CreateIndex(
                name: "IX_Arme_EnchantementId",
                table: "Arme",
                column: "EnchantementId");

            migrationBuilder.CreateIndex(
                name: "IX_Armure_CampagneId",
                table: "Armure",
                column: "CampagneId");

            migrationBuilder.CreateIndex(
                name: "IX_Armure_EnchantId",
                table: "Armure",
                column: "EnchantId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_CampagneId",
                table: "Classes",
                column: "CampagneId");

            migrationBuilder.CreateIndex(
                name: "IX_Monstre_CampagneId",
                table: "Monstre",
                column: "CampagneId");

            migrationBuilder.CreateIndex(
                name: "IX_Monstre_RaceId",
                table: "Monstre",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Perso_arme1id",
                table: "Perso",
                column: "arme1id");

            migrationBuilder.CreateIndex(
                name: "IX_Perso_arme2id",
                table: "Perso",
                column: "arme2id");

            migrationBuilder.CreateIndex(
                name: "IX_Perso_arme3id",
                table: "Perso",
                column: "arme3id");

            migrationBuilder.CreateIndex(
                name: "IX_Perso_armureId",
                table: "Perso",
                column: "armureId");

            migrationBuilder.CreateIndex(
                name: "IX_Perso_campagneId",
                table: "Perso",
                column: "campagneId");

            migrationBuilder.CreateIndex(
                name: "IX_Perso_classesid",
                table: "Perso",
                column: "classesid");

            migrationBuilder.CreateIndex(
                name: "IX_Perso_raceId",
                table: "Perso",
                column: "raceId");

            migrationBuilder.CreateIndex(
                name: "IX_Quete_PnjId",
                table: "Quete",
                column: "PnjId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Race_CampagneId",
                table: "Race",
                column: "CampagneId");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_Persoid",
                table: "Skill",
                column: "Persoid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionMonstre");

            migrationBuilder.DropTable(
                name: "Key");

            migrationBuilder.DropTable(
                name: "Quete");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "Monstre");

            migrationBuilder.DropTable(
                name: "PNJ");

            migrationBuilder.DropTable(
                name: "Perso");

            migrationBuilder.DropTable(
                name: "Arme");

            migrationBuilder.DropTable(
                name: "Armure");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Race");

            migrationBuilder.DropTable(
                name: "Enchantement");

            migrationBuilder.DropTable(
                name: "Campagne");
        }
    }
}
