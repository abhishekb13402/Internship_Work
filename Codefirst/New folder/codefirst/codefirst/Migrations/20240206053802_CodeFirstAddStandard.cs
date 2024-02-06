using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace codefirst.Migrations
{
    /// <inheritdoc />
    public partial class CodeFirstAddStandard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Standaard",
                table: "StudentTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Standaard",
                table: "StudentTable");
        }
    }
}
