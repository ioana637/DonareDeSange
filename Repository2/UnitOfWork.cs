using CentruDeTransfuzie1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IUnitOfWork : IDisposable
    {
        GenericRepository<Donator> DonatorRepo { get; }
        GenericRepository<UserDonator> UserDonatorRepo { get; }
        GenericRepository<Medic> MedicRepo { get; }
        GenericRepository<UserMedic> UserMedicRepo { get; }

        void Save();
    }

    public partial class UnitOfWork : IUnitOfWork
    {
        private GenericRepository<Donator> donatorRepo;
        private GenericRepository<UserDonator> userDonatorRepo;
        private GenericRepository<Medic> medicRepo;
        private GenericRepository<UserMedic> userMedicRepo;
        private GenericRepository<Pacient> pacientRepo;

        private CTContext context;

        public UnitOfWork()
        {
            var buider = new DbContextOptionsBuilder<CTContext>();
            buider.UseSqlServer(Configuration.ConnectionString);
            context = new CTContext(buider.Options);
        }

        public GenericRepository<Donator> DonatorRepo
        {
            get
            {
                if (donatorRepo == null)
                    donatorRepo = new GenericRepository<Donator>(context);
                return donatorRepo;
            }
        }

        public GenericRepository<UserDonator> UserDonatorRepo
        {
            get
            {
                if (userDonatorRepo == null)
                    userDonatorRepo = new GenericRepository<UserDonator>(context);
                return userDonatorRepo;
            }
        }

        public GenericRepository<Medic> MedicRepo
        {
            get
            {
                if (medicRepo == null)
                    medicRepo = new GenericRepository<Medic>(context);
                return medicRepo;
            }
        }

        public GenericRepository<UserMedic> UserMedicRepo
        {
            get
            {
                if (userMedicRepo == null)
                    userMedicRepo = new GenericRepository<UserMedic>(context);
                return userMedicRepo;
            }
        }

        public GenericRepository<Pacient> PacientRepo
        {
            get
            {
                if (pacientRepo == null)
                    pacientRepo = new GenericRepository<Pacient>(context);
                return pacientRepo;
            }
        }


        public void Dispose()
        {
            context.Dispose();
        }

        public CTContext GetContext()
        {
            return context;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
