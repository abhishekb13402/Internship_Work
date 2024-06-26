﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mini_Project.Migrations
{
    /// <inheritdoc />
    public partial class UP_Usertbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActive",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "isActive",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
