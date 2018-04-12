using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public bool Login(String username, String password)
        {
            
            UserMedic um = GetUserMedicByUsername(username);
            if (um == null) return false;
            if (um.Parola.Equals(password)) return true;
            else return false;
            
            
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
    }
}

