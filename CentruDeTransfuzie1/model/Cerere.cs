
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Cerere {

    public Cerere() {
    }

    public int Id { get; set; }
    public Medic Medic { get; set; }
    public DateTime Data { get; set; }
    public float CantitateSange { get; set; }
    public float CantitateTrombocite { get; set; }
    public float CantitateGlobuleRosii { get; set; }
    public float CantitatePlasma { get; set; }
    public bool Efectuata { get; set; }
    public List<CererePacient> CererePacienti { get; set; }

    public Cerere( DateTime data, float cantitateSange, float cantitateTrombocite, float cantitateGlobuleRosii, float cantitatePlasma, bool efectuata)
    {

        Data = data;
        CantitateSange = cantitateSange;
        CantitateTrombocite = cantitateTrombocite;
        CantitateGlobuleRosii = cantitateGlobuleRosii;
        CantitatePlasma = cantitatePlasma;
        Efectuata = efectuata;
    }
}