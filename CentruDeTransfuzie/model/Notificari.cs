using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentruDeTransfuzie.model
{
    public class Notificari
    {
        public int Id { get; set; }
        public int id_donator { get; set; }
        public int id_cerere { get; set; }

        public Notificari() { }

        public Notificari(int id_donator, int id_cerere) {
            this.id_donator = id_donator;
            this.id_cerere = id_cerere;
        }

    }
}
