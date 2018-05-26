using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CentruDeTransfuzie1.Migrations
{
    public partial class StocPunga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stoc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GlobuleRosii = table.Column<float>(nullable: false),
                    Plasma = table.Column<float>(nullable: false),
                    TermenGlobuleRosii = table.Column<int>(nullable: false),
                    TermenPlasma = table.Column<int>(nullable: false),
                    TermenTrombocite = table.Column<int>(nullable: false),
                    TotalSange = table.Column<float>(nullable: false),
                    Trombocite = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stoc", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stoc");
        }
    }
}
