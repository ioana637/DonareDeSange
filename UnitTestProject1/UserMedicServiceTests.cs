using CentruDeTransfuzie.model;
using CentruDeTransfuzie.utils;
using GUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Tests
{
    [TestClass()]
    public class UserMedicServiceTests
    {
        UserMedicService medicService = new UserMedicService();
        
        
        [TestMethod()]
        public void TestUpdateCerere()
        {
            int count = medicService.GetAllCereri().Count;
            Cerere cerere = new Cerere("xx-xx-xxxx", 1, 1, 1, 1, false, null, GrupaSange.AII, TipRh.Negativ);

            medicService.AddCerere(cerere, "ioana", new List<Pacient>());
            Cerere cerereSalvata = medicService.GetCereriByMedic("ioana").Where(c => c.Data.Equals("xx-xx-xxxx") && c.Grupa.Equals(GrupaSange.AII) && c.RH.Equals(TipRh.Negativ)).FirstOrDefault();
            Assert.AreEqual(count + 1, medicService.GetAllCereri().Count);
            try
            {
                medicService.AddCerere(cerereSalvata, "ioana", new List<Pacient>());
            }
            catch (Exception ex)
            {
                Assert.AreEqual(count + 1, medicService.GetAllCereri().Count);
            }

            cerereSalvata.Efectuata = true;
            cerereSalvata.CantitateSange = 100;
            medicService.UpdateCerere(cerereSalvata);
            cerereSalvata = medicService.GetCereriByMedic("ioana").Where(c => c.Data.Equals("xx-xx-xxxx") && c.Grupa.Equals(GrupaSange.AII) && c.RH.Equals(TipRh.Negativ)).FirstOrDefault();

            Assert.AreEqual(true, cerereSalvata.Efectuata);
            Assert.AreEqual(100, cerereSalvata.CantitateSange);

            medicService.DeleteCerere(cerereSalvata);
            Assert.AreEqual(count, medicService.GetAllCereri().Count());
        }
        
        [TestMethod]
        public void TestAddCerere()
        {
            int count = medicService.GetAllCereri().Count;
            Cerere cerere = new Cerere("xx-xx-xxxx", 1, 1, 1, 1, false, null, GrupaSange.AII, TipRh.Pozitiv);
            medicService.AddCerere(cerere, "ioana", new List<Pacient>());
            Cerere cerereSalvata = medicService.GetCereriByMedic("ioana").Where(c => c.Data.Equals("xx-xx-xxxx") && c.Grupa.Equals(GrupaSange.AII) && c.RH.Equals(TipRh.Pozitiv)).FirstOrDefault();
            Assert.AreEqual(count + 1, medicService.GetAllCereri().Count);
            try
            {
                medicService.AddCerere(cerereSalvata, "ioana", new List<Pacient>());
            }
            catch (Exception ex)
            {
                Assert.AreEqual(count + 1, medicService.GetAllCereri().Count);
            }
            medicService.DeleteCerere(cerereSalvata);
            Assert.AreEqual(count, medicService.GetAllCereri().Count());
        }


        [TestMethod()]
        public void TestVizualizarePacienti()
        {
            int count = medicService.GetPacientByMedic(1).Count;
            if (count == 0)
            {
                medicService.AdaugaPacient(1, "test", "test", "test", true);
                Assert.AreEqual(count + 1, medicService.GetPacientByMedic(1).Count);
                medicService.DeletePacient("test");
            }
            else Assert.IsTrue(medicService.GetPacientByMedic(1).Count > 0);


        }

        [TestMethod()]
        public void TestVizualizareCereri()
        {
            int count = medicService.GetCereriByMedic("ioana").Count;
            if (count == 0)
            {
                Cerere cerere = new Cerere("xx-xx-xxxx", 1, 1, 1, 1, false, null, GrupaSange.AII, TipRh.Negativ);
                medicService.AddCerere(cerere, "ioana", new List<Pacient>());
                Assert.AreEqual(count + 1, medicService.GetPacientByMedic(1));
                Cerere cerereSalvata = medicService.GetCereriByMedic("ioana").Where(c => c.Data.Equals("xx-xx-xxxx") && c.Grupa.Equals(GrupaSange.AII) && c.RH.Equals(TipRh.Negativ)).FirstOrDefault();
                medicService.DeleteCerere(cerereSalvata);
            }
            else Assert.IsTrue(medicService.GetPacientByMedic(1).Count > 0);


        }

        [TestMethod]
        public void TestLoginMedic()
        {
            Assert.AreEqual(medicService.Login("maria", "parqqola"), -1);
            Assert.AreEqual(medicService.Login("blabla", "123456"), -1);
            Assert.AreEqual(medicService.Login("raul", "medic"), 2);
            Assert.AreEqual(medicService.Login("ioana", "medic"), 1);
        }
    }
}