
using CentruDeTransfuzie1.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

public class Cerere {

    public Cerere() {
    }

    public int Id { get; set; }

    [Required(ErrorMessage = "Medic is required")]
    public Medic Medic { get; set; }

    [DataType(DataType.Date)]
    public string Data { get; set; }

    public float CantitateSange { get; set; }
    public float CantitateTrombocite { get; set; }
    public float CantitateGlobuleRosii { get; set; }
    public float CantitatePlasma { get; set; }
    public bool Efectuata { get; set; }
    public GrupaSange Grupa { get; set; }
    public TipRh RH { get; set; }

    public List<CererePacient> CererePacienti { get; set; }

    public Cerere( string data, float cantitateSange, float cantitateTrombocite, float cantitateGlobuleRosii, float cantitatePlasma, bool efectuata)
    {

        Data = data;
        CantitateSange = cantitateSange;
        CantitateTrombocite = cantitateTrombocite;
        CantitateGlobuleRosii = cantitateGlobuleRosii;
        CantitatePlasma = cantitatePlasma;
        Efectuata = efectuata;
        CererePacienti = new List<CererePacient>();
    }
}