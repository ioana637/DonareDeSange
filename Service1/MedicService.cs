using Repository;
using System;
using System.Collections.Generic;
using System.Text;

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
            
            
        }

        public void AdaugaPacient(int idMedic,string nume,string prenume,string email,bool eDonator)
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

                unitOfWork.PacientRepo.GetAll();
                return pacienti;
            }
        }


        public List<Pacient> GetPacientByMedic(string username)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<Pacient> pacienti = new List<Pacient>();
                UserMedic userMedic = unitOfWork.UserMedicRepo.GetBy(um => um.Username.Equals(username));
                Medic medic = unitOfWork.MedicRepo.GetBy(m => m.UserMedic.Equals(userMedic));

                unitOfWork.PacientRepo.GetAll();
                return pacienti;

            }

            
        }
}

