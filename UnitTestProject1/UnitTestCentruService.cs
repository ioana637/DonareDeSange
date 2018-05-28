using CentruDeTransfuzie.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentruDeTransfuzie.utils;

namespace UnitTestProject1
{
    class UnitTestCentruService
    {
        CentruService centruService = new CentruService();
        private GrupaSange BIII;
        private TipRh Pozitiv;

        [TestMethod]
        public void testGetTraseuPunga()
        {
            var trasee = centruService.GetAllPungiSange();
            Assert.AreNotEqual(trasee, null);
        }

        [TestMethod]
        public void testGetCereriSange()
        {
            var cereri = centruService.GetAllCereri();
            Assert.AreNotEqual(cereri, null);
        }

        [TestMethod]
        public void testAddPungaSange()
        {
            DonatorService srvDon = new DonatorService();
            srvDon.RegisterDonator("test", "test", "testNume", "testPrenume", "M", Convert.ToDateTime("04-02-1997"), "testDomiciliu", "testLocalitate", "testJudet", "", "", "", "1935647856", "test@test.com");
            Donator donator = srvDon.GetDonator("test");

            CentruService service = new CentruService();

            CentruTransfuzie centru = new CentruTransfuzie("test", "test", "test", "test");

            PungaSange punga = new PungaSange();
            punga.CantitateSange = 0.5F;
            punga.CantitatePlasma = 0.275F;
            punga.CantitateGlobuleRosii = -1;
            punga.CantitateTrombocite = 150;

            service.AddPungaSange(punga, donator, centru.Nume);

            Assert.AreNotEqual(service.GetAllPungiSange().Where(x => x.CantitateGlobuleRosii == -1), null);

        }

        [TestMethod]

        public void testAddAnalize()
        {  // NU RULATI , nu este delete
            DonatorService srvDon = new DonatorService();
            Donator donator = srvDon.GetDonator("Dmihai");
            CentruService service = new CentruService();

            PungaSange punga = service.GetPunga(1);

            service.AddAnaliza(BIII,Pozitiv,false,false,true,false,false,-774,punga,donator);

            Assert.AreEqual(srvDon.GetAllAnalizeByIdDonator("Dmihai").Where(x => x.NivelALT == -774), 1);

            //serivice.DeleteAnaliza(analiza) 
          
        }

    }
}