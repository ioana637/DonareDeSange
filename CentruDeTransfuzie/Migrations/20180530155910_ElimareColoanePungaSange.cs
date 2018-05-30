using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CentruDeTransfuzie.Migrations
{
    public partial class ElimareColoanePungaSange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Eliminat",
                table: "PungaSange",
                newName: "EliminatTrombocite");

            migrationBuilder.AddColumn<bool>(
                name: "EliminatGlobuleRosii",
                table: "PungaSange",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EliminatPlasma",
                table: "PungaSange",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EliminatGlobuleRosii",
                table: "PungaSange");

            migrationBuilder.DropColumn(
                name: "EliminatPlasma",
                table: "PungaSange");

            migrationBuilder.RenameColumn(
                name: "EliminatTrombocite",
                table: "PungaSange",
                newName: "Eliminat");
        }
    }
}
