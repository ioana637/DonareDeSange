using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;

namespace Service
{
    public class UserMedicService
    {
        public UserMedicService() { }

        public UserMedic GetUserMedicByUsername(String username)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                UserMedic user = unitOfWork.UserMedicRepo.GetBy(m => m.Username.Equals(username));
                return user;
            }
        }

<<<<<<< HEAD
        public Medic GetMedicById(int idMedic)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Medic med = unitOfWork.MedicRepo.GetBy(m => m.Id.Equals(idMedic));
                return med;
            }
        }

        public int Login(String username, String password)   // returneaza -1 daca datele sunt gresite, id-ul medicului altfel
        {

            UserMedic um = GetUserMedicByUsername(username);
            if (um == null) return -1;
            if (um.Parola.Equals(password)) return um.Id;
            else return -1;


=======
        public int Login(String username,String password)
        {// returneaza -1 daca datele sunt gresite, id-ul medicului altfel
            UserMedic um = GetUserMedicByUsername(username);
            if (um == null) return -1;
            if (um.Parola.Equals(Util.EncryptPassword(password)))
                return um.Id;
            else return -1;
        }

       

        public List<Cerere> GetAllCereri()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<Cerere> cereri = new List<Cerere>();

                unitOfWork.CerereRepo.GetAll().ToList().ForEach(c => { cereri.Add(c); });
                return cereri;

            }

        }

        public List<Cerere> GetCereriByMedic(string username)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<Cerere> cereri = new List<Cerere>();
                UserMedic userMedic = unitOfWork.UserMedicRepo.GetBy(um => um.Username.Equals(username));
                Medic medic = unitOfWork.MedicRepo.GetBy(m => m.UserMedic.Equals(userMedic));
                //Console.WriteLine("bd:" + unitOfWork.CerereRepo.GetAll().Where(c => c.Medic.Equals(medic)).Count());
                unitOfWork.CerereRepo.GetAll().Where(c=>c.Medic.UserMedic.Username.Equals(username)).ToList().ForEach(c => { cereri.Add(c); });
                return cereri;

            }

        }

        public void AddCerere(Cerere cerere, String username)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                UserMedic userMedic = unitOfWork.UserMedicRepo.GetBy(um => um.Username.Equals(username));
                Medic medic = unitOfWork.MedicRepo.GetBy(m => m.UserMedic.Equals(userMedic));
                cerere.Medic = medic;
                unitOfWork.CerereRepo.Save(cerere);
                unitOfWork.Save();
                Cerere cerereSalvata = unitOfWork.CerereRepo.GetBy(c => c.RH.Equals(cerere.RH) && c.Grupa.Equals(cerere.Grupa) && c.Medic.Equals(cerere.Medic) && c.Data.Equals(cerere.Data));
                medic.Cereri.Add(cerereSalvata);
                unitOfWork.Save();

            }
        }

        public void UpdateCerere(Cerere cerere)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Cerere cerereSalvata = unitOfWork.CerereRepo.GetBy(c => c.Id.Equals(cerere.Id));
                cerereSalvata.CantitateSange = cerere.CantitateSange;
                cerereSalvata.CantitateGlobuleRosii = cerere.CantitateGlobuleRosii;
                cerereSalvata.CantitatePlasma = cerere.CantitatePlasma;
                cerereSalvata.CantitateTrombocite = cerere.CantitateTrombocite;
                unitOfWork.CerereRepo.Update(cerereSalvata);
                unitOfWork.Save();

            }
        }

        public void AdaugaPacient(int idMedic, string nume, string prenume, string email, bool esteDonator)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {

                Pacient pacient = new Pacient(nume, prenume, email, esteDonator);
                Medic medic = unitOfWork.MedicRepo.GetBy(m => m.Id.Equals(idMedic));
                pacient.Medic = medic;

                unitOfWork.PacientRepo.Save(pacient);
                unitOfWork.Save();

                Pacient pacientSalvat = unitOfWork.PacientRepo.GetBy(d => d.Email.Equals(email));
                medic.Pacienti.Add(pacientSalvat);
                unitOfWork.Save();

            }
        }

        public List<Pacient> GetPacientByMedic(int idMedicCurent)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<Pacient> pacienti = new List<Pacient>();
                Medic medic = unitOfWork.MedicRepo.GetBy(m => m.Id.Equals(idMedicCurent));
                unitOfWork.PacientRepo.GetAll().Where(p => p.Medic.UserMedic.Id.Equals(idMedicCurent)).ToList().ForEach(p => { pacienti.Add(p); });
                return pacienti;

            }
>>>>>>> master
        }

        public void AdaugaPacient(int idMedic, string nume, string prenume, string email, bool eDonator)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {

                Pacient pacient = new Pacient(nume, prenume, email, eDonator);
                Medic medic = unitOfWork.MedicRepo.GetBy(m => m.Id.Equals(idMedic));
                pacient.Medic = medic;

                unitOfWork.PacientRepo.Save(pacient);
                unitOfWork.Save();

                Pacient pacientSalvat = unitOfWork.PacientRepo.GetBy(d => d.Email.Equals(email));
                medic.Pacienti.Add(pacientSalvat);
                unitOfWork.Save();



            }
        }

        public List<Pacient> GetAllPacients()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<Pacient> pacienti = new List<Pacient>();

                unitOfWork.PacientRepo.GetAll().ToList().ForEach(p => { pacienti.Add(p); });
                return pacienti;
            }
        }


        public List<Pacient> GetPacientByMedic(int idMedic)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<Pacient> pacienti = new List<Pacient>();
                Medic medic = unitOfWork.MedicRepo.GetBy(m => m.Id.Equals(idMedic));
                unitOfWork.PacientRepo.GetAll().Where(p => p.Medic.UserMedic.Id.Equals(idMedic)).ToList().ForEach(p => { pacienti.Add(p); });
                return pacienti;

            }
        }



    }
}

