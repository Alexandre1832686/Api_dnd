using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_DnD.Migrations
{
    /// <inheritdoc />
    public partial class AjoutNomDescriptionBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PNJ",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PNJ",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "PNJ");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PNJ");
        }
    }
}
