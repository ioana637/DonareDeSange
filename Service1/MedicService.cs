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
    }
}

