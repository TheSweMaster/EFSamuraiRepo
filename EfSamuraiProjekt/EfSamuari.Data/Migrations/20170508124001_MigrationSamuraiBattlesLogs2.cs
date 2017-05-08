using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamuari.Data.Migrations
{
    public partial class MigrationSamuraiBattlesLogs2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleEvent_BattleLog_BattleLogId",
                table: "BattleEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleLog_Battles_BattleId",
                table: "BattleLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BattleLog",
                table: "BattleLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BattleEvent",
                table: "BattleEvent");

            migrationBuilder.RenameTable(
                name: "BattleLog",
                newName: "BattleLogs");

            migrationBuilder.RenameTable(
                name: "BattleEvent",
                newName: "BattleEvents");

            migrationBuilder.RenameIndex(
                name: "IX_BattleLog_BattleId",
                table: "BattleLogs",
                newName: "IX_BattleLogs_BattleId");

            migrationBuilder.RenameIndex(
                name: "IX_BattleEvent_BattleLogId",
                table: "BattleEvents",
                newName: "IX_BattleEvents_BattleLogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BattleLogs",
                table: "BattleLogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BattleEvents",
                table: "BattleEvents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleEvents_BattleLogs_BattleLogId",
                table: "BattleEvents",
                column: "BattleLogId",
                principalTable: "BattleLogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleLogs_Battles_BattleId",
                table: "BattleLogs",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleEvents_BattleLogs_BattleLogId",
                table: "BattleEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleLogs_Battles_BattleId",
                table: "BattleLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BattleLogs",
                table: "BattleLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BattleEvents",
                table: "BattleEvents");

            migrationBuilder.RenameTable(
                name: "BattleLogs",
                newName: "BattleLog");

            migrationBuilder.RenameTable(
                name: "BattleEvents",
                newName: "BattleEvent");

            migrationBuilder.RenameIndex(
                name: "IX_BattleLogs_BattleId",
                table: "BattleLog",
                newName: "IX_BattleLog_BattleId");

            migrationBuilder.RenameIndex(
                name: "IX_BattleEvents_BattleLogId",
                table: "BattleEvent",
                newName: "IX_BattleEvent_BattleLogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BattleLog",
                table: "BattleLog",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BattleEvent",
                table: "BattleEvent",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleEvent_BattleLog_BattleLogId",
                table: "BattleEvent",
                column: "BattleLogId",
                principalTable: "BattleLog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleLog_Battles_BattleId",
                table: "BattleLog",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
