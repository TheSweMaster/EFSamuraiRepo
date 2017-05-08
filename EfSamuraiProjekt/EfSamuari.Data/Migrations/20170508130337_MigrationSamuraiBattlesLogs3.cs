using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamuari.Data.Migrations
{
    public partial class MigrationSamuraiBattlesLogs3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BattleEventDate",
                table: "BattleEvents",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Conclusion",
                table: "BattleEvents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BattleEvents",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BattleEventDate",
                table: "BattleEvents");

            migrationBuilder.DropColumn(
                name: "Conclusion",
                table: "BattleEvents");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "BattleEvents");
        }
    }
}
