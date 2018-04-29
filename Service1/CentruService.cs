using CentruDeTransfuzie1.model;
using CentruDeTransfuzie1.utils;
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
            if (ct.Parola.Equals(Util.EncryptPassword(password)))
                return ct.Id;
            else return -1;
        }


        public void AddAnaliza(GrupaSange grupa, TipRh rh, bool hIV, bool hepatitaB, bool hepatitaC, bool sifilis, bool hTLV, int nivelALT, PungaSange punga, Donator donator)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Analiza analiza = new Analiza(grupa,rh,hIV,hepatitaB,hepatitaC,sifilis,hTLV,nivelALT);
                PungaSange pungaS = unitOfWork.PungaSangeRepo.GetBy(p => p.Id.Equals(punga.Id));
                analiza.Donator = unitOfWork.DonatorRepo.GetBy(p => p.Id.Equals(donator.Id));
                analiza.PungaSange = pungaS;
                unitOfWork.AnalizaRepo.Save(analiza);
                unitOfWork.Save();

                //setare analiza pt punga de sange
                pungaS.Analiza = analiza;
                UpdatePungaSange(pungaS);

            }
        }

        public List<PungaSange> GetPungiSangeByDonator(Donator d) {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
            
                List<PungaSange> pungi = new List<PungaSange>();
                //afisare pungi care nu au analize trimise pentru un donator
                unitOfWork.PungaSangeRepo.GetAll().ToList().ForEach(p=>pungi.Add(p));//.ForEach(p => {if(p.Donator.Id==d.Id) pungi.Add(p); });
                return pungi;
                
            }
        }

        public void UpdatePungaSange(PungaSange punga)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                unitOfWork.PungaSangeRepo.Update(punga);
                unitOfWork.Save();
            }
        }
    }
}
