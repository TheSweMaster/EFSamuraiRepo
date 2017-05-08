using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamuari.Data.Migrations
{
    public partial class QuotesMigrationTypesNoSamId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quote_Samurais_SamuraiId",
                table: "Quote");

            migrationBuilder.AlterColumn<int>(
                name: "SamuraiId",
                table: "Quote",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "QuateLength",
                table: "Quote",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Quote_Samurais_SamuraiId",
                table: "Quote",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quote_Samurais_SamuraiId",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "QuateLength",
                table: "Quote");

            migrationBuilder.AlterColumn<int>(
                name: "SamuraiId",
                table: "Quote",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Quote_Samurais_SamuraiId",
                table: "Quote",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
