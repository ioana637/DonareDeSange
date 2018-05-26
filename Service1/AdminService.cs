using CentruDeTransfuzie.model;
using Repository;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class AdminService
    {
        public int Login(String username, String password)
        {
            Admin admin = GetAdminByUsername(username);
            if (admin == null) return -1;
            if (admin.Parola.Equals(Util.EncryptPassword(password)))
                return admin.Id;
            else return -1;
        }

        public Admin GetAdminByUsername(string username)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {

                Admin admin = unitOfWork.AdminRepo.GetBy((a) => a.Username.Equals(username));
                return admin;
            }
        }

        public IList<CentruTransfuzie> GetAllCentre()
        {

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                IList<CentruTransfuzie> centre = new List<CentruTransfuzie>();
                unitOfWork.CentruTransfuzieRepo.GetAll().ToList().ForEach(dn => { centre.Add(dn); });
                return centre;
            }
        }

        public IList<Spital> GetAllSpitale()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                IList<Spital> spitale = new List<Spital>();
                unitOfWork.SpitalRepo.GetAll().ToList().ForEach(dn => { spitale.Add(dn); });
                return spitale;
            }
        }

        public void AddCentru(CentruTransfuzie centru)
        {
            using(UnitOfWork unitOfWork=new UnitOfWork())
            {
                unitOfWork.CentruTransfuzieRepo.Save(centru);
                unitOfWork.Save();
            }
        }

        public void Delete(CentruTransfuzie centru)
        {
            using(UnitOfWork unitOfWork=new UnitOfWork())
            {
                unitOfWork.CentruTransfuzieRepo.Delete(centru);
                unitOfWork.Save();
            }
        }

        public IList<Medic> GetAllMedici()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                IList<Medic> medici = new List<Medic>();
                unitOfWork.MedicRepo.GetAll().ToList().ForEach(md => { medici.Add(md); });
                return medici;
            }
        }

        public void AddSpital(Spital spital, CentruTransfuzie centru)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                CentruTransfuzie centruFromBD = unitOfWork.CentruTransfuzieRepo.GetBy(c => c.Id == centru.Id);
                spital.CentruTransfuzie = centruFromBD;
                unitOfWork.SpitalRepo.Save(spital);
                unitOfWork.Save();
            }
        }

        public void DeleteSpital(Spital spital)
        {
            using (UnitOfWork unitOfWork=new UnitOfWork())
            {
                unitOfWork.SpitalRepo.Delete(spital);
                unitOfWork.Save();
            }
        }

        public void AddMedic(Medic medic, UserMedic userMedic,List<Spital> spitals)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                medic.UserMedic = userMedic;
                userMedic.Medic = medic;
                unitOfWork.UserMedicRepo.Save(userMedic);
                unitOfWork.MedicRepo.Save(medic);
                unitOfWork.Save();
                //unitOfWork.Find()
            }
        }

        public void DeleteMedicAndUser(Medic medic,UserMedic user)
        {
            using(UnitOfWork unitOfWork=new UnitOfWork())
            {
                unitOfWork.UserMedicRepo.Delete(user);
                unitOfWork.MedicRepo.Delete(medic);
                unitOfWork.Save();
            }
        }

        public UserMedic GetUserMedicByMedic(Medic medic)
        {
            UserMedic user= null;
            using (UnitOfWork unitOfWork=new UnitOfWork())
            {
                user=unitOfWork.UserMedicRepo.GetBy((u) => u.Medic==medic);
                unitOfWork.Save();
            }
            return user;
        }
    }

    
}

