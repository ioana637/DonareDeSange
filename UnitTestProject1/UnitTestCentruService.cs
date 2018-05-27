using CentruDeTransfuzie.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class UnitTestCentruService
    {
        CentruService centruService = new CentruService();

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

    }
}