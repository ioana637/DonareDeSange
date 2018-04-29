using CentruDeTransfuzie.model;
using Repository;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service1
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

        private Admin GetAdminByUsername(string username)
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

        public void AddSpital(Spital spital)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                unitOfWork.SpitalRepo.Save(spital);
                unitOfWork.Save();
            }
        }
    }

    
}

