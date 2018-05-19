using CentruDeTransfuzie;
using CentruDeTransfuzie.model;
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
        GenericRepository<Cerere> CerereRepo { get; }
        GenericRepository<CentruTransfuzie> CentruTransfuzieRepo { get; }
        GenericRepository<Admin> AdminRepo { get; }
        PungaSangeRepo PungaSangeRepo { get; }
        GenericRepository<Analiza> AnalizaRepo { get; }
        GenericRepository<Notificari> NotificariRepo { get; }

        GenericRepository<Spital> SpitalRepo { get; }

        void Save();
    }

    public partial class UnitOfWork : IUnitOfWork
    {
        private GenericRepository<Donator> donatorRepo;
        private GenericRepository<UserDonator> userDonatorRepo;
        private GenericRepository<Medic> medicRepo;
        private GenericRepository<UserMedic> userMedicRepo;
        private GenericRepository<Cerere> cerereRepo;
        private GenericRepository<Stoc> stocRepo;
        private GenericRepository<Pacient> pacientRepo;
        private GenericRepository<CentruTransfuzie> centruRepo;
        private GenericRepository<Admin> adminRepo;
        private GenericRepository<Spital> spitalRepo;
        private GenericRepository<Analiza> analizaRepo;
        private PungaSangeRepo pungaSangeRepo;
        private GenericRepository<CererePacient> cererePacientRepo;

        private GenericRepository<TraseuPunga> traseuPungaRepo;

        private GenericRepository<Notificari> notificariRepo;


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

        public GenericRepository<TraseuPunga> TraseuPungaRepo
        {
            get
            {
                if (traseuPungaRepo == null)
                    traseuPungaRepo = new GenericRepository<TraseuPunga>(context);
                return traseuPungaRepo;
            }
        }


        public GenericRepository<Analiza> AnalizaRepo
        {
            get
            {
                if (analizaRepo == null)
                    analizaRepo = new GenericRepository<Analiza>(context);
                return analizaRepo;
            }
        }


        public GenericRepository<CererePacient> CererePacientRepo
        {
            get
            {
                if (cererePacientRepo == null)
                    cererePacientRepo = new GenericRepository<CererePacient>(context);
                return cererePacientRepo;
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

        public GenericRepository<Cerere> CerereRepo
        {
            get
            {
                if (cerereRepo == null)
                    cerereRepo = new GenericRepository<Cerere>(context);
                return cerereRepo;
            }
        }

        public GenericRepository<Stoc> StocRepo
        {
            get
            {
                if (stocRepo == null)
                    stocRepo = new GenericRepository<Stoc>(context);
                return stocRepo;
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

        public GenericRepository<CentruTransfuzie> CentruTransfuzieRepo {
            get
            {
                if (centruRepo == null)
                    centruRepo = new GenericRepository<CentruTransfuzie>(context);
                return centruRepo;
            }
        }

        public GenericRepository<Admin> AdminRepo
        {
            get
            {
                if (adminRepo == null)
                    adminRepo = new GenericRepository<Admin>(context);
                return adminRepo;
            }
        }

        public GenericRepository<Spital> SpitalRepo
        {
            get
            {
                if (spitalRepo == null)
                    spitalRepo = new GenericRepository<Spital>(context);
                return spitalRepo;
            }
        }

        public PungaSangeRepo PungaSangeRepo {
            get
            {
                if (pungaSangeRepo == null)
                    pungaSangeRepo = new PungaSangeRepo(context);
                return pungaSangeRepo;
            }
        }

        public GenericRepository<Notificari> NotificariRepo
        {
            get
            {
                if (notificariRepo == null)
                    notificariRepo = new GenericRepository<Notificari>(context);
                return notificariRepo;
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
