using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CentruDeTransfuzie.Migrations
{
    public partial class constrangeri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analiza_Donator_DonatorId",
                table: "Analiza");

            migrationBuilder.DropForeignKey(
                name: "FK_Cerere_Medic_MedicId",
                table: "Cerere");

            migrationBuilder.DropForeignKey(
                name: "FK_PungaSange_Donator_DonatorId",
                table: "PungaSange");

            migrationBuilder.DropForeignKey(
                name: "FK_Spital_CentruTransfuzie_CentruTransfuzieId",
                table: "Spital");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stoc",
                table: "Stoc");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Stoc");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "UserMedic",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Parola",
                table: "UserMedic",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "UserDonator",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Parola",
                table: "UserDonator",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Grupa",
                table: "Stoc",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RH",
                table: "Stoc",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CentruTransfuzieId",
                table: "Spital",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DonatorId",
                table: "PungaSange",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "Pacient",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Pacient",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "Medic",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "Medic",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Medic",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cnp",
                table: "Medic",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "Donator",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SubTratament",
                table: "Donator",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "Donator",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InterventiiUltimele6Luni",
                table: "Donator",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Donator",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Activ",
                table: "Donator",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MedicId",
                table: "Cerere",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Data",
                table: "Cerere",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "Grupa",
                table: "Cerere",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RH",
                table: "Cerere",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Zona",
                table: "CentruTransfuzie",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "CentruTransfuzie",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DonatorId",
                table: "Analiza",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stoc",
                table: "Stoc",
                columns: new[] { "Grupa", "RH" });

            migrationBuilder.CreateIndex(
                name: "IX_UserMedic_Username",
                table: "UserMedic",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserDonator_Username",
                table: "UserDonator",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pacient_Email",
                table: "Pacient",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medic_Cnp",
                table: "Medic",
                column: "Cnp",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medic_Email",
                table: "Medic",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medic_Telefon",
                table: "Medic",
                column: "Telefon",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Donator_Email",
                table: "Donator",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Donator_Telefon",
                table: "Donator",
                column: "Telefon",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CentruTransfuzie_Nume",
                table: "CentruTransfuzie",
                column: "Nume",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Analiza_Donator_DonatorId",
                table: "Analiza",
                column: "DonatorId",
                principalTable: "Donator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cerere_Medic_MedicId",
                table: "Cerere",
                column: "MedicId",
                principalTable: "Medic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PungaSange_Donator_DonatorId",
                table: "PungaSange",
                column: "DonatorId",
                principalTable: "Donator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spital_CentruTransfuzie_CentruTransfuzieId",
                table: "Spital",
                column: "CentruTransfuzieId",
                principalTable: "CentruTransfuzie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analiza_Donator_DonatorId",
                table: "Analiza");

            migrationBuilder.DropForeignKey(
                name: "FK_Cerere_Medic_MedicId",
                table: "Cerere");

            migrationBuilder.DropForeignKey(
                name: "FK_PungaSange_Donator_DonatorId",
                table: "PungaSange");

            migrationBuilder.DropForeignKey(
                name: "FK_Spital_CentruTransfuzie_CentruTransfuzieId",
                table: "Spital");

            migrationBuilder.DropIndex(
                name: "IX_UserMedic_Username",
                table: "UserMedic");

            migrationBuilder.DropIndex(
                name: "IX_UserDonator_Username",
                table: "UserDonator");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stoc",
                table: "Stoc");

            migrationBuilder.DropIndex(
                name: "IX_Pacient_Email",
                table: "Pacient");

            migrationBuilder.DropIndex(
                name: "IX_Medic_Cnp",
                table: "Medic");

            migrationBuilder.DropIndex(
                name: "IX_Medic_Email",
                table: "Medic");

            migrationBuilder.DropIndex(
                name: "IX_Medic_Telefon",
                table: "Medic");

            migrationBuilder.DropIndex(
                name: "IX_Donator_Email",
                table: "Donator");

            migrationBuilder.DropIndex(
                name: "IX_Donator_Telefon",
                table: "Donator");

            migrationBuilder.DropIndex(
                name: "IX_CentruTransfuzie_Nume",
                table: "CentruTransfuzie");

            migrationBuilder.DropColumn(
                name: "Grupa",
                table: "Stoc");

            migrationBuilder.DropColumn(
                name: "RH",
                table: "Stoc");

            migrationBuilder.DropColumn(
                name: "Activ",
                table: "Donator");

            migrationBuilder.DropColumn(
                name: "Grupa",
                table: "Cerere");

            migrationBuilder.DropColumn(
                name: "RH",
                table: "Cerere");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "UserMedic",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Parola",
                table: "UserMedic",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "UserDonator",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Parola",
                table: "UserDonator",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Stoc",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "CentruTransfuzieId",
                table: "Spital",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DonatorId",
                table: "PungaSange",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "Pacient",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Pacient",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "Medic",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "Medic",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Medic",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Cnp",
                table: "Medic",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "Donator",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<bool>(
                name: "SubTratament",
                table: "Donator",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "Donator",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<bool>(
                name: "InterventiiUltimele6Luni",
                table: "Donator",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Donator",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "MedicId",
                table: "Cerere",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "Cerere",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Zona",
                table: "CentruTransfuzie",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "CentruTransfuzie",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "DonatorId",
                table: "Analiza",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stoc",
                table: "Stoc",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Analiza_Donator_DonatorId",
                table: "Analiza",
                column: "DonatorId",
                principalTable: "Donator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cerere_Medic_MedicId",
                table: "Cerere",
                column: "MedicId",
                principalTable: "Medic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PungaSange_Donator_DonatorId",
                table: "PungaSange",
                column: "DonatorId",
                principalTable: "Donator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spital_CentruTransfuzie_CentruTransfuzieId",
                table: "Spital",
                column: "CentruTransfuzieId",
                principalTable: "CentruTransfuzie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
