using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CentruDeTransfuzie1.model;

namespace CentruDeTransfuzie1
{
    public class CTContext : DbContext
    {
        public CTContext(DbContextOptions<CTContext> options) : base(options) { }


        public DbSet<Medic> Medic { get; set; }
        public DbSet<UserMedic> UserMedic { get; set; }
        public DbSet<Donator> Donator { get; set; }
        public DbSet<UserDonator> UserDonator { get; set; }
        public DbSet<Analiza> Analiza { get; set; }
        public DbSet<CentruTransfuzie> CentruTransfuzie { get; set; }
        public DbSet<Cerere> Cerere { get; set; }
        public DbSet<CererePacient> CererePacient { get; set; }
        public DbSet<Pacient> Pacient { get; set; }
        public DbSet<PungaSange> PungaSange { get; set; }
        public DbSet<Stoc> Stoc { get; set; }
        public DbSet<TraseuPunga> TraseuPunga { get; set; }
        public DbSet<Spital> Spital { get; set; }
        public DbSet<SpitalMedic> SpitalMedic { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CererePacient>().HasKey(cp => new { cp.IdCerere, cp.IdPacient });
            modelBuilder.Entity<SpitalMedic>().HasKey(sp => new { sp.IdMedic, sp.IdSpital });

            modelBuilder.Entity<Medic>().ToTable("Medic");
            modelBuilder.Entity<UserMedic>().ToTable("UserMedic");
            modelBuilder.Entity<Donator>().ToTable("Donator");
            modelBuilder.Entity<UserDonator>().ToTable("UserDonator");
            modelBuilder.Entity<CentruTransfuzie>().ToTable("CentruTransfuzie");
            modelBuilder.Entity<Cerere>().ToTable("Cerere");
            modelBuilder.Entity<CererePacient>().ToTable("CererePacient");
            modelBuilder.Entity<Pacient>().ToTable("Pacient");
            modelBuilder.Entity<PungaSange>().ToTable("PungaSange");
            modelBuilder.Entity<Stoc>().ToTable("Stoc");
            modelBuilder.Entity<TraseuPunga>().ToTable("TraseuPunga");
            modelBuilder.Entity<Analiza>().ToTable("Analiza");
            modelBuilder.Entity<Spital>().ToTable("Spital");
            modelBuilder.Entity<SpitalMedic>().ToTable("SpitalMedic");

            modelBuilder.Entity<Stoc>().HasKey(s => new { s.Grupa, s.RH });

            //constrangeri donator
            modelBuilder.Entity<Donator>()
            .HasIndex(u => u.Email)
            .IsUnique();
            modelBuilder.Entity<Donator>()
            .HasIndex(u => u.Telefon)
            .IsUnique();

            modelBuilder.Entity<UserDonator>()
            .HasIndex(u => u.Username)
            .IsUnique();

            modelBuilder.Entity<CentruTransfuzie>()
            .HasIndex(u => u.Nume)
            .IsUnique();

            modelBuilder.Entity<Medic>()
            .HasIndex(u => u.Email)
            .IsUnique();

            modelBuilder.Entity<Medic>()
            .HasIndex(u => u.Telefon)
            .IsUnique();

            modelBuilder.Entity<Medic>()
            .HasIndex(u => u.Cnp)
            .IsUnique();

            modelBuilder.Entity<UserMedic>()
            .HasIndex(u => u.Username)
            .IsUnique();

            modelBuilder.Entity<Pacient>()
            .HasIndex(u => u.Email)
            .IsUnique();
            //modelBuilder.Entity<Medic>().HasKey(m => m.Id);
            //modelBuilder.Entity<UserMedic>().HasKey(u => u.Id);
            //modelBuilder.Entity<Medic>().HasOne<UserMedic>().WithOne().HasForeignKey<Medic>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.ConnectionString);
        }

    }


}
