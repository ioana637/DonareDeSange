using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CentruDeTransfuzie1.Migrations
{
    public partial class pacientSpitalKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CentruTransfuzie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Judet = table.Column<string>(nullable: true),
                    Nume = table.Column<string>(nullable: true),
                    Oras = table.Column<string>(nullable: true),
                    Zona = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentruTransfuzie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cerere",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CantitateGlobuleRosii = table.Column<float>(nullable: false),
                    CantitatePlasma = table.Column<float>(nullable: false),
                    CantitateSange = table.Column<float>(nullable: false),
                    CantitateTrombocite = table.Column<float>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Efectuata = table.Column<bool>(nullable: false),
                    MedicId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cerere", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cerere_Medic_MedicId",
                        column: x => x.MedicId,
                        principalTable: "Medic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pacient",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EDonator = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    MedicId = table.Column<int>(nullable: true),
                    Nume = table.Column<string>(nullable: true),
                    Prenume = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacient_Medic_MedicId",
                        column: x => x.MedicId,
                        principalTable: "Medic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TraseuPunga",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Prelevata = table.Column<bool>(nullable: false),
                    SosireAnalize = table.Column<bool>(nullable: false),
                    SpitalPacient = table.Column<bool>(nullable: false),
                    StocCentru = table.Column<bool>(nullable: false),
                    TrimiseLaAnalize = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraseuPunga", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spital",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adresa = table.Column<string>(nullable: true),
                    CentruTransfuzieId = table.Column<int>(nullable: true),
                    Judet = table.Column<string>(nullable: true),
                    Oras = table.Column<string>(nullable: true),
                    SpitalId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spital", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spital_CentruTransfuzie_CentruTransfuzieId",
                        column: x => x.CentruTransfuzieId,
                        principalTable: "CentruTransfuzie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Spital_Spital_SpitalId",
                        column: x => x.SpitalId,
                        principalTable: "Spital",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CererePacient",
                columns: table => new
                {
                    IdCerere = table.Column<int>(nullable: false),
                    IdPacient = table.Column<int>(nullable: false),
                    CerereId = table.Column<int>(nullable: true),
                    PacientId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CererePacient", x => new { x.IdCerere, x.IdPacient });
                    table.ForeignKey(
                        name: "FK_CererePacient_Cerere_CerereId",
                        column: x => x.CerereId,
                        principalTable: "Cerere",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CererePacient_Pacient_PacientId",
                        column: x => x.PacientId,
                        principalTable: "Pacient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PungaSange",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CantitateGlobuleRosii = table.Column<float>(nullable: false),
                    CantitatePlasma = table.Column<float>(nullable: false),
                    CantitateSange = table.Column<float>(nullable: false),
                    CantitateTrombocite = table.Column<float>(nullable: false),
                    CentruTransfuzieId = table.Column<int>(nullable: true),
                    DataPreluarii = table.Column<DateTime>(nullable: false),
                    DonatorId = table.Column<int>(nullable: true),
                    TraseuPungaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PungaSange", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PungaSange_CentruTransfuzie_CentruTransfuzieId",
                        column: x => x.CentruTransfuzieId,
                        principalTable: "CentruTransfuzie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PungaSange_Donator_DonatorId",
                        column: x => x.DonatorId,
                        principalTable: "Donator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PungaSange_TraseuPunga_TraseuPungaId",
                        column: x => x.TraseuPungaId,
                        principalTable: "TraseuPunga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpitalMedic",
                columns: table => new
                {
                    IdMedic = table.Column<int>(nullable: false),
                    IdSpital = table.Column<int>(nullable: false),
                    MedicId = table.Column<int>(nullable: true),
                    SpitalId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpitalMedic", x => new { x.IdMedic, x.IdSpital });
                    table.ForeignKey(
                        name: "FK_SpitalMedic_Medic_MedicId",
                        column: x => x.MedicId,
                        principalTable: "Medic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpitalMedic_Spital_SpitalId",
                        column: x => x.SpitalId,
                        principalTable: "Spital",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Analiza",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DonatorId = table.Column<int>(nullable: true),
                    Grupa = table.Column<int>(nullable: false),
                    HIV = table.Column<bool>(nullable: false),
                    HTLV = table.Column<bool>(nullable: false),
                    HepatitaB = table.Column<bool>(nullable: false),
                    HepatitaC = table.Column<bool>(nullable: false),
                    NivelALT = table.Column<int>(nullable: false),
                    PungaSangeId = table.Column<int>(nullable: true),
                    Rh = table.Column<int>(nullable: false),
                    Sifilis = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analiza", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Analiza_Donator_DonatorId",
                        column: x => x.DonatorId,
                        principalTable: "Donator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Analiza_PungaSange_PungaSangeId",
                        column: x => x.PungaSangeId,
                        principalTable: "PungaSange",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Analiza_DonatorId",
                table: "Analiza",
                column: "DonatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Analiza_PungaSangeId",
                table: "Analiza",
                column: "PungaSangeId",
                unique: true,
                filter: "[PungaSangeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cerere_MedicId",
                table: "Cerere",
                column: "MedicId");

            migrationBuilder.CreateIndex(
                name: "IX_CererePacient_CerereId",
                table: "CererePacient",
                column: "CerereId");

            migrationBuilder.CreateIndex(
                name: "IX_CererePacient_PacientId",
                table: "CererePacient",
                column: "PacientId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacient_MedicId",
                table: "Pacient",
                column: "MedicId");

            migrationBuilder.CreateIndex(
                name: "IX_PungaSange_CentruTransfuzieId",
                table: "PungaSange",
                column: "CentruTransfuzieId");

            migrationBuilder.CreateIndex(
                name: "IX_PungaSange_DonatorId",
                table: "PungaSange",
                column: "DonatorId");

            migrationBuilder.CreateIndex(
                name: "IX_PungaSange_TraseuPungaId",
                table: "PungaSange",
                column: "TraseuPungaId",
                unique: true,
                filter: "[TraseuPungaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Spital_CentruTransfuzieId",
                table: "Spital",
                column: "CentruTransfuzieId");

            migrationBuilder.CreateIndex(
                name: "IX_Spital_SpitalId",
                table: "Spital",
                column: "SpitalId");

            migrationBuilder.CreateIndex(
                name: "IX_SpitalMedic_MedicId",
                table: "SpitalMedic",
                column: "MedicId");

            migrationBuilder.CreateIndex(
                name: "IX_SpitalMedic_SpitalId",
                table: "SpitalMedic",
                column: "SpitalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Analiza");

            migrationBuilder.DropTable(
                name: "CererePacient");

            migrationBuilder.DropTable(
                name: "SpitalMedic");

            migrationBuilder.DropTable(
                name: "PungaSange");

            migrationBuilder.DropTable(
                name: "Cerere");

            migrationBuilder.DropTable(
                name: "Pacient");

            migrationBuilder.DropTable(
                name: "Spital");

            migrationBuilder.DropTable(
                name: "TraseuPunga");

            migrationBuilder.DropTable(
                name: "CentruTransfuzie");
        }
    }
}
