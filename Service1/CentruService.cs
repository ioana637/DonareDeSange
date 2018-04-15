using CentruDeTransfuzie1.model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CentruService
    {

        public List<Cerere> GetAllCereri()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<Cerere> cereri = new List<Cerere>();

                unitOfWork.CerereRepo.GetAll().ToList().ForEach(c => { cereri.Add(c); });
                return cereri;
            }

        }

        public List<Stoc> GetAllStocuri()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<Stoc> stocuri = new List<Stoc>();
                unitOfWork.StocRepo.GetAll().ToList().ForEach(s => { stocuri.Add(s); });
                return stocuri;
            }
        }

        public List<CentruTransfuzie> GetAllCentre()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<CentruTransfuzie> centre = new List<CentruTransfuzie>();

                unitOfWork.CentruTransfuzieRepo.GetAll().ToList().ForEach(c => { centre.Add(c); });
                return centre;
            }

        }

        public CentruTransfuzie GetCentruTransfuzieByName(String name)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                CentruTransfuzie centru = unitOfWork.CentruTransfuzieRepo.GetBy(c => c.Nume.Equals(name));
                return centru;
            }
        }

        public int Login(String username, String password)
        {
            CentruTransfuzie ct = GetCentruTransfuzieByName(username);
            if (ct == null) return -1;
            if (ct.Parola.Equals(password))
                return ct.Id;
            else return -1;
        }
    }
}
