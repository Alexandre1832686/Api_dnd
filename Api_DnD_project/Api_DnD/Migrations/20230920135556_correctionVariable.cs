using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_DnD.Migrations
{
    /// <inheritdoc />
    public partial class correctionVariable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quête",
                table: "PNJ",
                newName: "Quete");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quete",
                table: "PNJ",
                newName: "Quête");
        }
    }
}
