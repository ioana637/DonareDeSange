using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CentruDeTransfuzie.Migrations
{
    public partial class cererePacienti1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CererePacient_Cerere_CerereId",
                table: "CererePacient");

            migrationBuilder.DropForeignKey(
                name: "FK_CererePacient_Pacient_PacientId",
                table: "CererePacient");

            migrationBuilder.DropIndex(
                name: "IX_CererePacient_CerereId",
                table: "CererePacient");

            migrationBuilder.DropIndex(
                name: "IX_CererePacient_PacientId",
                table: "CererePacient");

            migrationBuilder.DropColumn(
                name: "CerereId",
                table: "CererePacient");

            migrationBuilder.DropColumn(
                name: "PacientId",
                table: "CererePacient");

            migrationBuilder.CreateIndex(
                name: "IX_CererePacient_IdPacient",
                table: "CererePacient",
                column: "IdPacient");

            migrationBuilder.AddForeignKey(
                name: "FK_CererePacient_Cerere_IdCerere",
                table: "CererePacient",
                column: "IdCerere",
                principalTable: "Cerere",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CererePacient_Pacient_IdPacient",
                table: "CererePacient",
                column: "IdPacient",
                principalTable: "Pacient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CererePacient_Cerere_IdCerere",
                table: "CererePacient");

            migrationBuilder.DropForeignKey(
                name: "FK_CererePacient_Pacient_IdPacient",
                table: "CererePacient");

            migrationBuilder.DropIndex(
                name: "IX_CererePacient_IdPacient",
                table: "CererePacient");

            migrationBuilder.AddColumn<int>(
                name: "CerereId",
                table: "CererePacient",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PacientId",
                table: "CererePacient",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CererePacient_CerereId",
                table: "CererePacient",
                column: "CerereId");

            migrationBuilder.CreateIndex(
                name: "IX_CererePacient_PacientId",
                table: "CererePacient",
                column: "PacientId");

            migrationBuilder.AddForeignKey(
                name: "FK_CererePacient_Cerere_CerereId",
                table: "CererePacient",
                column: "CerereId",
                principalTable: "Cerere",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CererePacient_Pacient_PacientId",
                table: "CererePacient",
                column: "PacientId",
                principalTable: "Pacient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
