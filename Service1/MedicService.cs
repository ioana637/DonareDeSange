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
                
                unitOfWork.PacientRepo.Save(pacient);
                unitOfWork.Save();
                pacient = unitOfWork.PacientRepo.GetBy(d => d.Email.Equals(email));
                unitOfWork.Save();

            }
        }
    }
}

