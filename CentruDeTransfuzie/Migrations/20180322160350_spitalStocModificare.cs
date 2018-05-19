using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CentruDeTransfuzie.Migrations
{
    public partial class spitalStocModificare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spital_Spital_SpitalId",
                table: "Spital");

            migrationBuilder.DropIndex(
                name: "IX_Spital_SpitalId",
                table: "Spital");

            migrationBuilder.DropColumn(
                name: "SpitalId",
                table: "Spital");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SpitalId",
                table: "Spital",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Spital_SpitalId",
                table: "Spital",
                column: "SpitalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Spital_Spital_SpitalId",
                table: "Spital",
                column: "SpitalId",
                principalTable: "Spital",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
