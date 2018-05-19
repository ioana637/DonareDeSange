using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CentruDeTransfuzie.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserDonator",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Parola = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDonator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserMedic",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Parola = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMedic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Donator",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataNastere = table.Column<DateTime>(nullable: false),
                    Domiciliu = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Greutate = table.Column<float>(nullable: false),
                    InterventiiUltimele6Luni = table.Column<bool>(nullable: false),
                    Judet = table.Column<string>(nullable: true),
                    JudetResedinta = table.Column<string>(nullable: true),
                    Localitate = table.Column<string>(nullable: true),
                    LocalitateResedinta = table.Column<string>(nullable: true),
                    Nume = table.Column<string>(nullable: true),
                    Prenume = table.Column<string>(nullable: true),
                    Puls = table.Column<int>(nullable: false),
                    Resedinta = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    SubTratament = table.Column<bool>(nullable: false),
                    Telefon = table.Column<string>(nullable: true),
                    Tensiune = table.Column<int>(nullable: false),
                    UserDonatorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donator_UserDonator_UserDonatorId",
                        column: x => x.UserDonatorId,
                        principalTable: "UserDonator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Medic",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cnp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Nume = table.Column<string>(nullable: true),
                    Prenume = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    UserMedicId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medic_UserMedic_UserMedicId",
                        column: x => x.UserMedicId,
                        principalTable: "UserMedic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donator_UserDonatorId",
                table: "Donator",
                column: "UserDonatorId",
                unique: true,
                filter: "[UserDonatorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Medic_UserMedicId",
                table: "Medic",
                column: "UserMedicId",
                unique: true,
                filter: "[UserMedicId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donator");

            migrationBuilder.DropTable(
                name: "Medic");

            migrationBuilder.DropTable(
                name: "UserDonator");

            migrationBuilder.DropTable(
                name: "UserMedic");
        }
    }
}
