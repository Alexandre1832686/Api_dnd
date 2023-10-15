using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_DnD.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSkill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "Skill",
                newName: "Descr");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descr",
                table: "Skill",
                newName: "Desc");
        }
    }
}
