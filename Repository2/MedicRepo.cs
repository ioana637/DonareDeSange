using CentruDeTransfuzie;
using CentruDeTransfuzie.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MedicRepo: GenericRepository<Medic>
    {
        public MedicRepo(CTContext ctx) : base(ctx) { }

        public Medic GetMedic(int id)
        {
            return dbset.Include(m => m.UserMedic).Include(m=>m.Pacienti).Include(m => m.Cereri).Where(m => m.Id.Equals(id)).FirstOrDefault();
        }
    }
}
