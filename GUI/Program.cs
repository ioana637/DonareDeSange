﻿using CentruDeTransfuzie;
using CentruDeTransfuzie.Data;

using Microsoft.EntityFrameworkCore;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        
        [STAThread]
        static void Main()
        {
            using (var db = new CTContext(new DbContextOptions<CTContext>()))
            {
                DbInitializer.Initialize(db);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new FormLogareCentru(new CentruService()));
           Application.Run(new FormLogareDonator(new Service.DonatorService()));
            
            
            
            //Application.Run(new FormDonator(new Service.DonatorService(), "popescu"));
            //Application.Run(new FormLogareMedic(new Service.UserMedicService()));
            

            //Application.Run(new FormMedic(new Service.UserMedicService(),1, "ioana"));

            //Application.Run(new FormCentru(new Service.DonatorService()));

            // Application.Run(new FormCentru(new Service.DonatorService(), "Centru Donare Sange Cluj"));
            //Application.Run(new FormDonator(new Service.DonatorService(), "Mandrei"));
            //Application.Run(new FormLogareMedic(new Service.UserMedicService()));
            //Application.Run(new FormMedic(new Service.UserMedicService(),1, "ioana"));

            //Application.Run(new FormCentru(new Service.DonatorService()));
            
            //Application.Run(new FormCentru(new Service.DonatorService(), "Centru Donare Sange Cluj"));

            //Application.Run(new FormAdminLogare(new AdminService()));
            //Application.Run(new FormAdmin(new AdminService()));
            //Application.Run(new FormAnalizeSange());



            //Application.Run(new FormRegisterDonator());



        }
        

        
    }
}
