using CentruDeTransfuzie.model;
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
    public class DonatorServiceTests
    {
        DonatorService donatorService = new DonatorService();

        [TestMethod()]
        public void LogInUserDonatorTest()
        {
            Boolean login1 = donatorService.LogInUserDonator("Amaria", "parola3");
            Assert.AreEqual(login1, true);
            Boolean login2 = donatorService.LogInUserDonator("Amaria", "ParolaGresita");
            Assert.AreEqual(login2, false);
        }

        [TestMethod()]
        public void GetDonatorTest()
        {
            Donator donator1 = donatorService.GetDonator("Dmihai");
            Assert.AreNotEqual(donator1, null);
            try
            {
                Donator donator2 = donatorService.GetDonator("DmihaiGresit");
            }
            catch (Exception exc)
            {
                Assert.AreNotEqual(exc, null);
            }

        }

        [TestMethod()]
        public void RegisterDonatorTest()
        {
            //nu merge delete-ul, nu rulati testul asta! 

            Donator donator = new Donator("Popescu", "Ion", "M", DateTime.Parse("1998-02-12"), "Cluj-Napoca", "Cluj-Napoca", "Cluj", null, null, null, "0712121213", "popescupopescu@yahoo.com");
            UserDonator userDonator = new UserDonator("popescupopescu", "8287458823facb8ff918dbfabcd22ccb"); // parola este "parola"

            int count = donatorService.GetAllDonatori().Count;

            donatorService.RegisterDonator("popescupopescu", "parola", "Popescu", "Ion", "M", DateTime.Parse("1998-02-12"), "Cluj-Napoca", "Cluj-Napoca", "Cluj", null, null, null, "0712121213", "popescupopescu@yahoo.com");

            Assert.AreEqual(count, donatorService.GetAllDonatori().Count);

            donatorService.DeleteDonatorAndUser(donator, userDonator);

            Assert.AreEqual(count, donatorService.GetAllDonatori().Count);

        }

        [TestMethod()]
        public void GetDonatoriByDataNasteriiTest()
        {
            List<Donator> list1 = donatorService.GetDonatoriByDataNasterii("1996-02-22");
            int count1 = list1.Count;
            Assert.AreEqual(1, count1);

            List<Donator> list2 = donatorService.GetDonatoriByDataNasterii("1-1-1");
            int count2 = list2.Count;
            Assert.AreEqual(0, count2);
        }

        [TestMethod()]
        public void UpdateDonatorTest()
        {
            Donator donator = donatorService.GetDonator("Dmihai");

            donator.Prenume = "Mihaiiiiiiiiiii";
            donatorService.UpdateDonator(donator);

            Assert.AreEqual(donator.Prenume, "Mihaiiiiiiiiiii");

            donator.Prenume = "Mihai";
            donatorService.UpdateDonator(donator);
            
            Assert.AreEqual(donator.Prenume, "Mihai");
        }
    }
}