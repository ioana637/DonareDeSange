using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CentruDeTransfuzie1
{
    public class CTContext : DbContext
    {
        public CTContext(DbContextOptions<CTContext> options) : base(options) { }

        public DbSet<Medic> Medic { get; set; }
        public DbSet<UserMedic> UserMedic { get; set; }
        public DbSet<Donator> Donator { get; set; }
        public DbSet<UserDonator> UserDonator { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medic>().ToTable("Medic");
            modelBuilder.Entity<UserMedic>().ToTable("UserMedic");
            modelBuilder.Entity<Donator>().ToTable("Donator");
            modelBuilder.Entity<UserDonator>().ToTable("UserDonator");

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
