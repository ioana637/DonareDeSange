﻿using CentruDeTransfuzie.model;
using CentruDeTransfuzie.utils;
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

        public class PungaSangeTraseu
        {
            public int Id { get; set; }
            public String numeDonator { get; set; }

            public DateTime DataPrelevarii { get; set; }

            public float CantitateSange { get; set; }
            public float CantitateTrombocite { get; set; }
            public float CantitateGlobuleRosii { get; set; }
            public float CantitatePlasma { get; set; }

            public bool Prelevata { get; set; }

            public bool TrimiseLaAnalize { get; set; }

            public bool SosireAnalize { get; set; }

            public bool StocCentru { get; set; }
            public bool SpitalPacient { get; set; }


            public PungaSangeTraseu(int id, string numeDonator, DateTime dataPrelevarii, float cantitateSange, float cantitateTrombocite, float cantitateGlobuleRosii, float cantitatePlasma, bool prelevata, bool trimiseLaAnalize, bool sosireAnalize, bool stocCentru, bool spitalPacient)
            {
                Id = id;

                this.numeDonator = numeDonator;
                DataPrelevarii = dataPrelevarii;
                CantitateSange = cantitateSange;
                CantitateTrombocite = cantitateTrombocite;
                CantitateGlobuleRosii = cantitateGlobuleRosii;
                CantitatePlasma = cantitatePlasma;
                Prelevata = prelevata;
                TrimiseLaAnalize = trimiseLaAnalize;
                SosireAnalize = sosireAnalize;
                StocCentru = stocCentru;
                SpitalPacient = spitalPacient;
            }
        }
        public List<PungaSangeTraseu> GetAllPungaSangeTraseu()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {

                List<PungaSange> pungi = unitOfWork.PungaSangeRepo.GetPungi();
                List<PungaSangeTraseu> pungiTraseu = new List<PungaSangeTraseu>();
                pungi.ForEach(p => pungiTraseu.Add(new PungaSangeTraseu(p.Id, p.Donator.Nume, p.DataPreluarii, p.CantitateSange, p.CantitateTrombocite, p.CantitateGlobuleRosii, p.CantitatePlasma, p.TraseuPunga.Prelevata, p.TraseuPunga.TrimiseLaAnalize, p.TraseuPunga.SosireAnalize, p.TraseuPunga.StocCentru, p.TraseuPunga.SpitalPacient)));
                return pungiTraseu;
            }
        }

        public PungaSange GetPunga(int id)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                PungaSange punga = unitOfWork.PungaSangeRepo.GetPunga(id);
                return punga;
            }
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

        public List<PungaSange> GetAllPungiSange()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<PungaSange> pungi = new List<PungaSange>();

                unitOfWork.PungaSangeRepo.GetAll().ToList().ForEach(c => { pungi.Add(c); });
                return pungi;
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
                Analiza analiza = new Analiza(grupa, rh, hIV, hepatitaB, hepatitaC, sifilis, hTLV, nivelALT);
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

        public List<PungaSange> GetPungiSangeByDonator(Donator d)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {

                List<PungaSange> pungi = new List<PungaSange>();
                //afisare pungi care nu au analize trimise pentru un donator
                unitOfWork.PungaSangeRepo.GetPungi().ToList().ForEach(p => { if (p.Donator.Id == d.Id && p.Analiza == null) pungi.Add(p); });
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

        public void UpdateTraseu(TraseuPunga traseu)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                unitOfWork.TraseuPungaRepo.Update(traseu);
                unitOfWork.Save();
            }
        }

        public void AddPungaSange(PungaSange punga, Donator donator, string centru)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Donator donatorFromDb = unitOfWork.DonatorRepo.GetBy(d => d.Nume.Equals(donator.Nume) && d.Prenume.Equals(donator.Prenume) && d.Email.Equals(donator.Email));
                if (donatorFromDb == null) throw new Exception("Eroare! Nu s-a gasit nici un donator cu aceste date!");
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

        public void UpdateStoc(PungaSangeTraseu pungaSange)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                string err = "";
                Analiza analiza = unitOfWork.AnalizaRepo.GetBy(a => a.PungaSange.Equals(pungaSange.Id));
                Stoc stoc = unitOfWork.StocRepo.GetBy(s => s.RH.Equals(analiza.Rh) && s.Grupa.Equals(analiza.Grupa));
                if (pungaSange.DataPrelevarii.AddMonths(12) > DateTime.Now)
                {
                    stoc.Plasma = pungaSange.CantitatePlasma;
                }
                else
                    err += "Plasma este expirata!\n ";
                if (pungaSange.DataPrelevarii.AddDays(5) > DateTime.Now)
                {
                    stoc.Trombocite = pungaSange.CantitateTrombocite;
                }
                else
                    err += "Trombocitele sunt expirate!\n";
                if (pungaSange.DataPrelevarii.AddDays(42) > DateTime.Now)
                {
                    stoc.GlobuleRosii = pungaSange.CantitateGlobuleRosii;
                }
                else
                    err += "Globulelele rosii sunt expirate!\n";

                stoc.TotalSange = pungaSange.CantitateSange;
                stoc.TermenPlasma = 12;
                stoc.TermenGlobuleRosii = 42;
                stoc.TermenTrombocite = 5;
                unitOfWork.StocRepo.Update(stoc);
                unitOfWork.Save();
                if (!err.Equals(""))
                    throw new ValidationException(err);


            }
        }

        public void EliminareSangeStoc()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<PungaSangeTraseu> all = GetAllPungaSangeTraseu();
                bool modificat = false;
                all.ForEach(p =>
                {
                    PungaSange pungaSange = unitOfWork.PungaSangeRepo.GetBy(punga => punga.Id.Equals(p.Id));


                if (p.StocCentru)
                    {
                        Analiza analiza = unitOfWork.AnalizaRepo.GetBy(a => a.PungaSange.Equals(p.Id));
                        Stoc stoc = unitOfWork.StocRepo.GetBy(s => s.RH.Equals(analiza.Rh) && s.Grupa.Equals(analiza.Grupa));
                        var dp = p.DataPrelevarii.AddMonths(12);
                        var dpok = DateTime.Compare(p.DataPrelevarii.AddMonths(12), DateTime.Now);
                        if (DateTime.Compare(p.DataPrelevarii.AddMonths(12), DateTime.Now) <0 && !pungaSange.EliminatPlasma)
                        {
                            stoc.Plasma = stoc.Plasma - p.CantitatePlasma;
                            pungaSange.EliminatPlasma = true;
                            modificat = true;

                        }
                        if (DateTime.Compare(p.DataPrelevarii.AddDays(5) ,DateTime.Now)<0 && !pungaSange.EliminatTrombocite)
                        {
                            stoc.Trombocite = stoc.Trombocite - p.CantitateTrombocite;
                            pungaSange.EliminatTrombocite = true;
                            modificat = true;

                        }
                        if (DateTime.Compare(p.DataPrelevarii.AddDays(42), DateTime.Now)<0 && !pungaSange.EliminatGlobuleRosii)
                        {
                            stoc.GlobuleRosii = stoc.GlobuleRosii - p.CantitateGlobuleRosii;
                            pungaSange.EliminatGlobuleRosii = true;
                            modificat = true;

                        }
                        if (pungaSange.EliminatPlasma && pungaSange.EliminatGlobuleRosii && pungaSange.EliminatTrombocite && !pungaSange.EliminatSange)
                        {
                            stoc.TotalSange = stoc.TotalSange - pungaSange.CantitateSange;
                            pungaSange.EliminatSange = true;

                        }
                        unitOfWork.PungaSangeRepo.Update(pungaSange);
                        unitOfWork.StocRepo.Update(stoc);
                        unitOfWork.Save();

                    }

                });
                if (modificat == true)
                    throw new ValidationException("O parte din sange a expirat. Stocul a fost updatat!");
            }
        }

        public bool ValidateSange(PungaSangeTraseu pungaSange)
        {
            bool ok = true;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Analiza analiza = unitOfWork.AnalizaRepo.GetBy(a => a.PungaSange.Equals(pungaSange.Id));
                if (analiza.HepatitaB || analiza.HepatitaC || analiza.HIV || analiza.NivelALT > 80 || analiza.NivelALT < 4 || analiza.Sifilis || analiza.HTLV)
                    ok = false;
            }
            return ok;
        }

    
    }
}
