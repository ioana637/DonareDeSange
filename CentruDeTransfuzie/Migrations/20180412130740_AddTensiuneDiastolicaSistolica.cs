using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CentruDeTransfuzie1.Migrations
{
    public partial class AddTensiuneDiastolicaSistolica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tensiune",
                table: "Donator",
                newName: "TensiuneSistolica");

            migrationBuilder.AddColumn<int>(
                name: "TensiuneDiastolica",
                table: "Donator",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TensiuneDiastolica",
                table: "Donator");

            migrationBuilder.RenameColumn(
                name: "TensiuneSistolica",
                table: "Donator",
                newName: "Tensiune");
        }
    }
}
