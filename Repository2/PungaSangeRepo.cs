using CentruDeTransfuzie1;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository2
{
    public class PungaSangeRepo: GenericRepository<PungaSange>
    {

        public PungaSangeRepo(CTContext ctx) : base(ctx) { }

        public List<PungaSange> GetPungi()
        {
            List<PungaSange> pungi = new List<PungaSange>();
            dbset.Include(p=>p.Donator).Include(p=>p.Analiza).ToList().ForEach(p => pungi.Add(p));
            return pungi;
            
        }
    }
}
