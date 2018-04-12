using CentruDeTransfuzie1;
using CentruDeTransfuzie1.Data;
using Microsoft.EntityFrameworkCore;
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
        [STAThread]
        static void Main()
        {
            using (var db = new CTContext(new DbContextOptions<CTContext>()))
            {
                DbInitializer.Initialize(db);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormDonator());
            Application.Run(new FormCentru("Cluj"));
            //Application.Run(new FormAnalizeSange());
            //Application.Run(new FormLogareCentru());
            //Application.Run(new FormRegisterDonator());
            //Application.Run(new FormLogareDonator(new Service.DonatorService()));
            // Console.WriteLine("dklflkes");
            //Application.Run(new FormLogareMedic(new Service.UserMedicService()));
           

        }
    }
}
