using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamuari.Data.Migrations
{
    public partial class MigrationSamuraiBattles11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SamuraiBattles_Battles_BattlesId",
                table: "SamuraiBattles");

            migrationBuilder.RenameColumn(
                name: "BattlesId",
                table: "SamuraiBattles",
                newName: "BattleId");

            migrationBuilder.RenameIndex(
                name: "IX_SamuraiBattles_BattlesId",
                table: "SamuraiBattles",
                newName: "IX_SamuraiBattles_BattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SamuraiBattles_Battles_BattleId",
                table: "SamuraiBattles",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SamuraiBattles_Battles_BattleId",
                table: "SamuraiBattles");

            migrationBuilder.RenameColumn(
                name: "BattleId",
                table: "SamuraiBattles",
                newName: "BattlesId");

            migrationBuilder.RenameIndex(
                name: "IX_SamuraiBattles_BattleId",
                table: "SamuraiBattles",
                newName: "IX_SamuraiBattles_BattlesId");

            migrationBuilder.AddForeignKey(
                name: "FK_SamuraiBattles_Battles_BattlesId",
                table: "SamuraiBattles",
                column: "BattlesId",
                principalTable: "Battles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
