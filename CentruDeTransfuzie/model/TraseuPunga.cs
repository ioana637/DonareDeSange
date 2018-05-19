
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentruDeTransfuzie.model
{
    public class TraseuPunga
    {

        public TraseuPunga()
        {
        }

        public int Id { get; set; }
        public PungaSange PungaSange { get; set; }

        public bool Prelevata { get; set; }

        public bool TrimiseLaAnalize { get; set; }

        public bool SosireAnalize { get; set; }

        public bool StocCentru { get; set; }

        public bool SpitalPacient { get; set; }


    }
}