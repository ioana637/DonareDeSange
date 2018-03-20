using System;
using System.Collections.Generic;
using System.Text;

namespace CentruDeTransfuzie1.model
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

        public Stoc()
        {
        }

        public Stoc(float totalSange, float trombocite, float globuleRosii, float plasma, int termenTrombocite, int termenGlobuleRosii, int termenPlasma)
        {
            TotalSange = totalSange;
            Trombocite = trombocite;
            GlobuleRosii = globuleRosii;
            Plasma = plasma;
            TermenTrombocite = termenTrombocite;
            TermenGlobuleRosii = termenGlobuleRosii;
            TermenPlasma = termenPlasma;
        }
    }
}
