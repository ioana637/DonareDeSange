﻿using System;
using System.Collections.Generic;
using CentruDeTransfuzie.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestAdmin
    {
        AdminService adminService = new AdminService();
        [TestMethod]
        public void TestGetAdminByUsername()
        {
            Admin admin = adminService.GetAdminByUsername("admin");
            Assert.AreNotEqual(admin, null);
            Admin admin55 = adminService.GetAdminByUsername("admin55");
            Assert.AreEqual(admin55, null);
        }

        [TestMethod]
        public void TestAddCentru()
        {
            int count = adminService.GetAllCentre().Count;
            CentruTransfuzie centru = new CentruTransfuzie("CentruTest", "Test", "Test", "Test", "Test");
            adminService.AddCentru(centru);
            Assert.AreEqual(count + 1, adminService.GetAllCentre().Count);
            try
            {
                adminService.AddCentru(centru);
            }
            catch (Exception e)
            {
                Assert.AreEqual(count + 1, adminService.GetAllCentre().Count);
            }
            adminService.Delete(centru);
            Assert.AreEqual(count, adminService.GetAllCentre().Count);
        }

        [TestMethod]
        public void TestAddSpital()
        {
            CentruTransfuzie centru = new CentruTransfuzie("CentruTest", "Test", "Test", "Test", "Test");
            adminService.AddCentru(centru);
            int count = adminService.GetAllSpitale().Count;
            Spital spital = new Spital("Test", "Test", "Test");
            adminService.AddSpital(spital, centru);
            Assert.AreEqual(count + 1, adminService.GetAllSpitale().Count);
            try
            {
                adminService.AddSpital(spital, centru);
            }
            catch (Exception e)
            {
                Assert.AreEqual(count + 1, adminService.GetAllSpitale().Count);
            }
            adminService.DeleteSpital(spital);
            adminService.Delete(centru);
        }

        [TestMethod]
        public void TestAdminAddMedic()
        {
            Medic medic = new Medic("12345678901", "NumeGresit", "PrenumeGresit", "EmailGresit", "0707070707");
            UserMedic userMedic = new UserMedic("UserGresit", "ParolaGresita");
            List<Spital> list = new List<Spital>();


            int count = adminService.GetAllMedici().Count;
            adminService.AddMedic(medic, userMedic, list);

            Assert.AreEqual(count + 1, adminService.GetAllMedici().Count);
            adminService.DeleteMedicAndUser(medic, userMedic);
            Assert.AreEqual(count, adminService.GetAllMedici().Count);
        }
       
    }
}
