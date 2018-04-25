using CentruDeTransfuzie.model;
using CentruDeTransfuzie.utils;
using CentruDeTransfuzie1.model;
using CentruDeTransfuzie1.utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


namespace CentruDeTransfuzie1.Data
{
    public static class DbInitializer
    {


        public static void Initialize(CTContext context)
        {

            context.Database.Migrate();
            InitializeMedic(context);
            InitializeCereri(context);
            InitializeDonatori(context);
            InitializeStoc(context);
            InitializeCentre(context);
            InitializeAdmin(context);

        }

        private static void InitializeAdmin(CTContext context)
        {
            if (context.Admin.Any()) return;
            context.Admin.Add(new Admin("admin", "21232f297a57a5a743894a0e4a801fc3"));//parola=admin
            context.Admin.Add(new Admin("admin1", "e00cf25ad42683b3df678c61f42c6bda"));//parola=admin1
            context.SaveChanges();
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

        public static void InitializeMedic(CTContext context)
        {
            if (context.Medic.Any()) return;
            Medic m1 = new Medic("2770111123456", "Coste", "Claudia", "ioana@yahoo.com", "0742345678");
            Medic m2 = new Medic("2661223654321", "Dordai", "Raul", "raul@yahoo.com", "0785123456");
            var medici = new Medic[] { m1, m2 };
            foreach (Medic m in medici)
            {
                context.Medic.Add(m);
            }
            UserMedic um1 = new UserMedic("ioana", "0d20326e6155cae6bb2b510bfc2cc01e");//parola=medic
            UserMedic um2 = new UserMedic("raul", "0d20326e6155cae6bb2b510bfc2cc01e"); //parola = medic
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

            if (context.Cerere.Any())
            {
                return;
            }
            Cerere c1 = new Cerere("1-1-2018", 5, 1, 3, 1, true, context.Medic.Find(1),GrupaSange.AII,TipRh.Pozitiv);
            Cerere c2 = new Cerere("2-1-2018", 7, 2, 1, 4, false, context.Medic.Find(2), GrupaSange.AII, TipRh.Pozitiv);
            c1.Prioritate = GradUrgenta.Mediu;
            c2.Prioritate = GradUrgenta.Ridicat;
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


            Donator d1 = new Donator("Dobrovat", "Mihai", "M", DateTime.Parse("22-02-96"), "Str. Buftea", "Cluj-Napoca", "Cluj", "Str. Buftea", "Cluj-Napoca", "Cluj", "0723456799", "mihai@yahoo.com");
            Donator d2 = new Donator("Marin", "Andrei", "M", DateTime.Parse("23-11-97"), "Str. Garii", "Iasi", "Iasi", "Str. Garii", "Iasi", "Iasi", "0723456789", "andrei@yahoo.com");
            Donator d3 = new Donator("Acatrinei", "Maria", "F", DateTime.Parse("24-12-98"), "Str. Lacu Rosu", "Cluj-Napoca", "Cluj", "Str. Lacu Rosu", "Cluj-Napoca", "Cluj", "0723456787", "maria@yahoo.com");
            Donator d4 = new Donator("Popescu", "Ion", "M", DateTime.Parse("12-02-98"), "Cluj-Napoca", "Cluj-Napoca", "Cluj", null, null, null, "0712121212", "popescu@yahoo.com");

            UserDonator ud1 = new UserDonator("Dmihai", "f63ed3300797216784db8387a2deaff0");//parola=parola1
            UserDonator ud2 = new UserDonator("Mandrei", "a1442bfc190d52303727e63719962ed6");//parola=parola2
            UserDonator ud3 = new UserDonator("Amaria", "93a7ffba27902537651fb3dbca8ae802");//parola=parola3
            UserDonator ud4 = new UserDonator("popescu", "8287458823facb8ff918dbfabcd22ccb"); // parola este "parola"

            var donatori = new Donator[] { d1, d2, d3,d4 };

            foreach (Donator d in donatori)
            {
                context.Donator.Add(d);
            }

            var usersD = new UserDonator[] { ud1, ud2, ud3,ud4 };
            foreach (UserDonator ud in usersD)
            {

                context.UserDonator.Add(ud);
            }

            context.SaveChanges();
            context.UserDonator.Find(1).Donator = context.Donator.Find(1);
            context.Donator.Find(1).UserDonator = context.UserDonator.Find(1);
            context.UserDonator.Find(2).Donator = context.Donator.Find(2);
            context.Donator.Find(2).UserDonator = context.UserDonator.Find(2);

            context.SaveChanges();

            
            
        }

        static void InitializeCentre(CTContext context)
        {

            if (context.CentruTransfuzie.Any())
            {
                return;
            }
            CentruTransfuzie c1 = new CentruTransfuzie("Centru Donare Sange Cluj", "Piata Mihai Viteazu", "Cluj-Napoca", "Cluj");
            CentruTransfuzie c2 = new CentruTransfuzie("Centru Donare Sange Bucuresti","Militari","Bucuresti","Ilfov");

            c1.Parola = "e2a7b5972479f8c59ade36a15e5b6146";//parola=ParolaCluj
            c2.Parola = "311e8c89c2e7f24e3ac63265496297a7";//parola=ParolaBucuresti
            var centre = new CentruTransfuzie[] { c1, c2 };
            foreach (CentruTransfuzie c in centre)
            {
                context.CentruTransfuzie.Add(c);
            }
            context.SaveChanges();
        }
    }
}