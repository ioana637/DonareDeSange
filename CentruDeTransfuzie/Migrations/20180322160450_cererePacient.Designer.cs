﻿// <auto-generated />
using CentruDeTransfuzie;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace CentruDeTransfuzie.Migrations
{
    [DbContext(typeof(CTContext))]
    [Migration("20180322160450_cererePacient")]
    partial class cererePacient
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CentruDeTransfuzie1.model.Analiza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DonatorId");

                    b.Property<int>("Grupa");

                    b.Property<bool>("HIV");

                    b.Property<bool>("HTLV");

                    b.Property<bool>("HepatitaB");

                    b.Property<bool>("HepatitaC");

                    b.Property<int>("NivelALT");

                    b.Property<int?>("PungaSangeId");

                    b.Property<int>("Rh");

                    b.Property<bool>("Sifilis");

                    b.HasKey("Id");

                    b.HasIndex("DonatorId");

                    b.HasIndex("PungaSangeId")
                        .IsUnique()
                        .HasFilter("[PungaSangeId] IS NOT NULL");

                    b.ToTable("Analiza");
                });

            modelBuilder.Entity("CentruTransfuzie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Judet");

                    b.Property<string>("Nume");

                    b.Property<string>("Oras");

                    b.Property<string>("Zona");

                    b.HasKey("Id");

                    b.ToTable("CentruTransfuzie");
                });

            modelBuilder.Entity("Cerere", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("CantitateGlobuleRosii");

                    b.Property<float>("CantitatePlasma");

                    b.Property<float>("CantitateSange");

                    b.Property<float>("CantitateTrombocite");

                    b.Property<DateTime>("Data");

                    b.Property<bool>("Efectuata");

                    b.Property<int?>("MedicId");

                    b.HasKey("Id");

                    b.HasIndex("MedicId");

                    b.ToTable("Cerere");
                });

            modelBuilder.Entity("CererePacient", b =>
                {
                    b.Property<int>("IdCerere");

                    b.Property<int>("IdPacient");

                    b.Property<int?>("CerereId");

                    b.Property<int?>("PacientId");

                    b.HasKey("IdCerere", "IdPacient");

                    b.HasIndex("CerereId");

                    b.HasIndex("PacientId");

                    b.ToTable("CererePacient");
                });

            modelBuilder.Entity("Donator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataNastere");

                    b.Property<string>("Domiciliu");

                    b.Property<string>("Email");

                    b.Property<float>("Greutate");

                    b.Property<bool>("InterventiiUltimele6Luni");

                    b.Property<string>("Judet");

                    b.Property<string>("JudetResedinta");

                    b.Property<string>("Localitate");

                    b.Property<string>("LocalitateResedinta");

                    b.Property<string>("Nume");

                    b.Property<string>("Prenume");

                    b.Property<int>("Puls");

                    b.Property<string>("Resedinta");

                    b.Property<string>("Sex");

                    b.Property<bool>("SubTratament");

                    b.Property<string>("Telefon");

                    b.Property<int>("Tensiune");

                    b.Property<int?>("UserDonatorId");

                    b.HasKey("Id");

                    b.HasIndex("UserDonatorId")
                        .IsUnique()
                        .HasFilter("[UserDonatorId] IS NOT NULL");

                    b.ToTable("Donator");
                });

            modelBuilder.Entity("Medic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cnp");

                    b.Property<string>("Email");

                    b.Property<string>("Nume");

                    b.Property<string>("Prenume");

                    b.Property<string>("Telefon");

                    b.Property<int?>("UserMedicId");

                    b.HasKey("Id");

                    b.HasIndex("UserMedicId")
                        .IsUnique()
                        .HasFilter("[UserMedicId] IS NOT NULL");

                    b.ToTable("Medic");
                });

            modelBuilder.Entity("Pacient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("EDonator");

                    b.Property<string>("Email");

                    b.Property<int?>("MedicId");

                    b.Property<string>("Nume");

                    b.Property<string>("Prenume");

                    b.HasKey("Id");

                    b.HasIndex("MedicId");

                    b.ToTable("Pacient");
                });

            modelBuilder.Entity("PungaSange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("CantitateGlobuleRosii");

                    b.Property<float>("CantitatePlasma");

                    b.Property<float>("CantitateSange");

                    b.Property<float>("CantitateTrombocite");

                    b.Property<int?>("CentruTransfuzieId");

                    b.Property<DateTime>("DataPreluarii");

                    b.Property<int?>("DonatorId");

                    b.Property<int?>("TraseuPungaId");

                    b.HasKey("Id");

                    b.HasIndex("CentruTransfuzieId");

                    b.HasIndex("DonatorId");

                    b.HasIndex("TraseuPungaId")
                        .IsUnique()
                        .HasFilter("[TraseuPungaId] IS NOT NULL");

                    b.ToTable("PungaSange");
                });

            modelBuilder.Entity("Spital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<int?>("CentruTransfuzieId");

                    b.Property<string>("Judet");

                    b.Property<string>("Oras");

                    b.HasKey("Id");

                    b.HasIndex("CentruTransfuzieId");

                    b.ToTable("Spital");
                });

            modelBuilder.Entity("SpitalMedic", b =>
                {
                    b.Property<int>("IdMedic");

                    b.Property<int>("IdSpital");

                    b.Property<int?>("MedicId");

                    b.Property<int?>("SpitalId");

                    b.HasKey("IdMedic", "IdSpital");

                    b.HasIndex("MedicId");

                    b.HasIndex("SpitalId");

                    b.ToTable("SpitalMedic");
                });

            modelBuilder.Entity("TraseuPunga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Prelevata");

                    b.Property<bool>("SosireAnalize");

                    b.Property<bool>("SpitalPacient");

                    b.Property<bool>("StocCentru");

                    b.Property<bool>("TrimiseLaAnalize");

                    b.HasKey("Id");

                    b.ToTable("TraseuPunga");
                });

            modelBuilder.Entity("UserDonator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Parola");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("UserDonator");
                });

            modelBuilder.Entity("UserMedic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Parola");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("UserMedic");
                });

            modelBuilder.Entity("CentruDeTransfuzie1.model.Analiza", b =>
                {
                    b.HasOne("Donator", "Donator")
                        .WithMany("Analize")
                        .HasForeignKey("DonatorId");

                    b.HasOne("PungaSange", "PungaSange")
                        .WithOne("Analiza")
                        .HasForeignKey("CentruDeTransfuzie1.model.Analiza", "PungaSangeId");
                });

            modelBuilder.Entity("Cerere", b =>
                {
                    b.HasOne("Medic", "Medic")
                        .WithMany("Cereri")
                        .HasForeignKey("MedicId");
                });

            modelBuilder.Entity("CererePacient", b =>
                {
                    b.HasOne("Cerere", "Cerere")
                        .WithMany("CererePacienti")
                        .HasForeignKey("CerereId");

                    b.HasOne("Pacient", "Pacient")
                        .WithMany("CereriPacienti")
                        .HasForeignKey("PacientId");
                });

            modelBuilder.Entity("Donator", b =>
                {
                    b.HasOne("UserDonator", "UserDonator")
                        .WithOne("Donator")
                        .HasForeignKey("Donator", "UserDonatorId");
                });

            modelBuilder.Entity("Medic", b =>
                {
                    b.HasOne("UserMedic", "UserMedic")
                        .WithOne("Medic")
                        .HasForeignKey("Medic", "UserMedicId");
                });

            modelBuilder.Entity("Pacient", b =>
                {
                    b.HasOne("Medic", "Medic")
                        .WithMany("Pacienti")
                        .HasForeignKey("MedicId");
                });

            modelBuilder.Entity("PungaSange", b =>
                {
                    b.HasOne("CentruTransfuzie", "CentruTransfuzie")
                        .WithMany("PungiSange")
                        .HasForeignKey("CentruTransfuzieId");

                    b.HasOne("Donator", "Donator")
                        .WithMany("PungiSange")
                        .HasForeignKey("DonatorId");

                    b.HasOne("TraseuPunga", "TraseuPunga")
                        .WithOne("PungaSange")
                        .HasForeignKey("PungaSange", "TraseuPungaId");
                });

            modelBuilder.Entity("Spital", b =>
                {
                    b.HasOne("CentruTransfuzie", "CentruTransfuzie")
                        .WithMany("Spitale")
                        .HasForeignKey("CentruTransfuzieId");
                });

            modelBuilder.Entity("SpitalMedic", b =>
                {
                    b.HasOne("Medic", "Medic")
                        .WithMany("SpitaleMedic")
                        .HasForeignKey("MedicId");

                    b.HasOne("Spital", "Spital")
                        .WithMany("SpitalMedici")
                        .HasForeignKey("SpitalId");
                });
#pragma warning restore 612, 618
        }
    }
}
