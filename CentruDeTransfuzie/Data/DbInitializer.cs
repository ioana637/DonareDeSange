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
            context.Database.EnsureCreated();

            if (context.UserMedic.Any()) return;

            Medic m1 = new Medic("2770111123456", "Coste", "Claudia", "ioana@yahoo.com", "0742345678");
            Medic m2 = new Medic("2661223654321", "Dordai", "Raul", "raul@yahoo.com", "0785123456");
            UserMedic um1 = new UserMedic("ioana", "12345");
            UserMedic um2 = new UserMedic("raul", "12345");
            var usersM = new UserMedic[]
            {
                um1, um2
            };
            var medici = new Medic[] { m1, m2 };

            foreach (UserMedic um in usersM)
            {

                context.UserMedic.Add(um);
            }
            foreach (Medic m in medici)
            {
                context.Medic.Add(m);
            }
            context.SaveChanges();
            context.UserMedic.Find(1).Medic = context.Medic.Find(1);
            context.Medic.Find(1).UserMedic = context.UserMedic.Find(1);
            context.UserMedic.Find(2).Medic = context.Medic.Find(2);
            context.Medic.Find(2).UserMedic = context.UserMedic.Find(2);


            context.SaveChanges();
        }
    }
}