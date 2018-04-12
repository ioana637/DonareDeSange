using CentruDeTransfuzie1.model;
using CentruDeTransfuzie1.utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentruDeTransfuzie1.Data
{
    public static class DbInitializer
    {


        public static void Initialize(CTContext context)
        {

            context.Database.Migrate();
            initializeMedic(context);
            InitializeCereri(context);
            InitializeDonatori(context);
            InitializeStoc(context);

        }

        private static void InitializeStoc(CTContext context)
        {
            if (context.Stoc.Any()) return;
            context.Stoc.Add(new Stoc(GrupaSange.OI, TipRh.Pozitiv));
            context.Stoc.Add(new Stoc(GrupaSange.OI, TipRh.Negativ));
            context.Stoc.Add(new Stoc(GrupaSange.AII, TipRh.Pozitiv));
            context.Stoc.Add(new Stoc(GrupaSange.AII, TipRh.Negativ));
            context.Stoc.Add(new Stoc(GrupaSange.BIII, TipRh.Pozitiv));
            context.Stoc.Add(new Stoc(GrupaSange.BIII, TipRh.Negativ));
            context.Stoc.Add(new Stoc(GrupaSange.ABIV, TipRh.Pozitiv));
            context.Stoc.Add(new Stoc(GrupaSange.ABIV, TipRh.Negativ));
            context.SaveChanges();

        }

        public static void initializeMedic(CTContext context)
        {
            if (context.Medic.Any()) return;
            Medic m1 = new Medic("2770111123456", "Coste", "Claudia", "ioana@yahoo.com", "0742345678");
            Medic m2 = new Medic("2661223654321", "Dordai", "Raul", "raul@yahoo.com", "0785123456");
            var medici = new Medic[] { m1, m2 };
            foreach (Medic m in medici)
            {
                context.Medic.Add(m);
            }
            UserMedic um1 = new UserMedic("ioana", "12345");
            UserMedic um2 = new UserMedic("raul", "12345");
            var usersM = new UserMedic[]{ um1, um2 };
            foreach (UserMedic um in usersM)
            {

                context.UserMedic.Add(um);
            }

            context.SaveChanges();
            context.UserMedic.Find(1).Medic = context.Medic.Find(1);
            context.Medic.Find(1).UserMedic = context.UserMedic.Find(1);
            context.UserMedic.Find(2).Medic = context.Medic.Find(2);
            context.Medic.Find(2).UserMedic = context.UserMedic.Find(2);

            context.SaveChanges();

        }

        static void InitializeCereri(CTContext context)
        {
            if (context.Cerere.Any()) return;
            Cerere c1 = new Cerere("1-1-2018", 5, 1, 3, 1, true, context.Medic.Find(1));
            Cerere c2 = new Cerere("2-1-2018", 7, 2, 1, 4, false, context.Medic.Find(2));
            var cereri = new Cerere[] { c1, c2 };
            foreach (Cerere c in cereri)
            {
                context.Cerere.Add(c);
            }
            context.SaveChanges();
        }

        static void InitializeDonatori(CTContext context)
        {
            if (context.Donator.Any()) return;

            Donator donator1 = new Donator("Popescu", "Ion", "M", DateTime.Parse("12-02-98"), "Cluj-Napoca", "Cluj-Napoca", "Cluj", null, null, null, "0712121212", "popescu@yahoo.com");
            UserDonator userDonator1 = new UserDonator("popescu", "8287458823facb8ff918dbfabcd22ccb"); // parola este "parola"

            context.Donator.Add(donator1);
            context.UserDonator.Add(userDonator1);

            context.SaveChanges();

        }




    }
}