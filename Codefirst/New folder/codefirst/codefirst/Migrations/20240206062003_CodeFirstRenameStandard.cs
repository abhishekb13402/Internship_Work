using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace codefirst.Migrations
{
    /// <inheritdoc />
    public partial class CodeFirstRenameStandard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Standaard",
                table: "StudentTable",
                newName: "Standard");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Standard",
                table: "StudentTable",
                newName: "Standaard");
        }
    }
}
