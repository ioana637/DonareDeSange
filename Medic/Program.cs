using CentruDeTransfuzie1;
using CentruDeTransfuzie1.Data;
using CentruDeTransfuzie1.model;
using GUI;
using Microsoft.EntityFrameworkCore;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medic
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
            UserMedicService service = new UserMedicService();
            Application.Run(new FormLogareMedic(service));
            
<<<<<<< HEAD

=======
>>>>>>> master
        }
    }
}
