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
                unitOfWork.PungaSangeRepo.GetPungi().ToList().ForEach(p => { if (p.Donator.Id == d.Id && p.Analiza==null) pungi.Add(p); });
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

        public void AddPungaSange(PungaSange punga, Donator donator, string centru)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Donator donatorFromDb = unitOfWork.DonatorRepo.GetBy(d => d.Nume.Equals(donator.Nume) && d.Prenume.Equals(donator.Prenume) && d.Email.Equals(donator.Email));
                punga.DataPreluarii = DateTime.Now.Date;//.ToShortDateString();
                punga.CentruTransfuzie = unitOfWork.CentruTransfuzieRepo.GetBy(ct => ct.Nume.Equals(centru));
                if (donator == null) { unitOfWork.PungaSangeRepo.Save(punga); unitOfWork.Save(); }
                else
                {
                    punga.Donator = donatorFromDb;
                    unitOfWork.PungaSangeRepo.Save(punga);
                    unitOfWork.Save();
                    PungaSange pungafromdb = unitOfWork.PungaSangeRepo.GetBy(p => p.Donator.Email.Equals(donator.Email) && p.DataPreluarii.Equals(punga.DataPreluarii));

                    TraseuPunga traseu = new TraseuPunga();
                    traseu.Prelevata = true;
                    traseu.PungaSange = pungafromdb;
                    traseu.SosireAnalize = false;
                    traseu.SpitalPacient = false;
                    traseu.StocCentru = false;
                    traseu.TrimiseLaAnalize = false;

                    unitOfWork.TraseuPungaRepo.Save(traseu);
                    unitOfWork.Save();
                    pungafromdb.TraseuPunga = unitOfWork.TraseuPungaRepo.GetBy(t => t.PungaSange.Id.Equals(pungafromdb.Id));
                    donatorFromDb.PungiSange.Add(pungafromdb);
                    unitOfWork.Save();
                }

            }

        }
    }
}
