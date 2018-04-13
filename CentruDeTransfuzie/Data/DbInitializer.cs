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
<<<<<<< HEAD
            InitializeMedic(context);
=======
            initializeMedic(context);
>>>>>>> TasksTeo
            InitializeCereri(context);
            InitializeDonatori(context);

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
            Cerere c1 = new Cerere("1-1-2018", 5, 1, 3, 1, true, context.Medic.Find(1),GrupaSange.AII,TipRh.Pozitiv);
            Cerere c2 = new Cerere("2-1-2018", 7, 2, 1, 4, false, context.Medic.Find(2), GrupaSange.AII, TipRh.Pozitiv);
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

<<<<<<< HEAD
            Donator d1 = new Donator("Dobrovat", "Mihai", "M", DateTime.Parse("10/22/1996"), "Str. Buftea", "Cluj-Napoca", "Cluj", "Str. Buftea", "Cluj-Napoca", "Cluj", "0123456789", "mihai@yahoo.com");
            Donator d2 = new Donator("Marin", "Andrei", "M", DateTime.Parse("11/23/1997"), "Str. Garii", "Iasi", "Iasi", "Str. Garii", "Iasi", "Iasi", "0223456789", "andrei@yahoo.com");
            Donator d3 = new Donator("Acatrinei", "Maria", "F", DateTime.Parse("12/24/1998"), "Str. Lacu Rosu", "Cluj-Napoca", "Cluj", "Str. Lacu Rosu", "Cluj-Napoca", "Cluj", "0323456789", "maria@yahoo.com");
=======
            //Donator d1 = new Donator("Dobrovat", "Mihai", "Masculin", DateTime.Parse("22/10/1996"), "Str. Buftea", "Cluj-Napoca", "Cluj", "Str. Buftea", "Cluj-Napoca", "Cluj", "0123456789", "mihai@yahoo.com");
            //Donator d2 = new Donator("Marin", "Andrei", "Masculin", DateTime.Parse("23/11/1997"), "Str. Garii", "Iasi", "Iasi", "Str. Garii", "Iasi", "Iasi", "0223456789", "andrei@yahoo.com");
            //Donator d3 = new Donator("Acatrinei", "Maria", "Feminin", DateTime.Parse("24/12/1998"), "Str. Lacu Rosu", "Cluj-Napoca", "Cluj", "Str. Lacu Rosu", "Cluj-Napoca", "Cluj", "0323456789", "maria@yahoo.com");
>>>>>>> TasksTeo

            //UserDonator ud1 = new UserDonator("Dmihai", "1234");
            //UserDonator ud2 = new UserDonator("Mandrei", "1234");
            //UserDonator ud3 = new UserDonator("Amaria", "1234");

            context.Donator.Add(donator1);
            context.UserDonator.Add(userDonator1);

            //context.Donator.Add(d1);
            //context.UserDonator.Add(ud1);

            //context.Donator.Add(d2);
            //context.UserDonator.Add(ud2);

            //context.Donator.Add(d3);
            //context.UserDonator.Add(ud3);

            context.SaveChanges();

        }
    }
}