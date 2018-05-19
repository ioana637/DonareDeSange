using CentruDeTransfuzie.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CentruDeTransfuzie.model
{
    public class Stoc
    {
        public float TotalSange { get; set; }
        public float Trombocite { get; set; }
        public float GlobuleRosii { get; set; }
        public float Plasma { get; set; }
        public int TermenTrombocite { get; set; }
        public int TermenGlobuleRosii { get; set; }
        public int TermenPlasma { get; set; }
        public GrupaSange Grupa { get; set; }
        public TipRh RH { get; set; }


        public Stoc()
        {
            TotalSange = 0;
        }

        public Stoc(GrupaSange grupa, TipRh tipRh)
        {
            Grupa = grupa;
            RH = tipRh;
            Trombocite = 0;
            GlobuleRosii = 0;
            Plasma = 0;
            TermenTrombocite = 0;
            TermenGlobuleRosii = 0;
            TermenPlasma = 0;
        }
    }
}

