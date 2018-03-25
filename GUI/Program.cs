﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormLogareMedic());
            //Application.Run(new FormDonator());
            //Application.Run(new FormMedic());
            //Application.Run(new FormCentru());
            //Application.Run(new FormAnalizeSange());
            //Application.Run(new FormLogareCentru());
            Application.Run(new FormRegisterDonator());
        }
    }
}
