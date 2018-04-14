using CentruDeTransfuzie1;
using CentruDeTransfuzie1.Data;
using GUI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentruT
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
            Application.Run(new FormCentru(new Service.DonatorService()));
            //Application.Run(new FormLogareCentru(new Service.CentruService()));


        }
    }
}
