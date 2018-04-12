
using CentruDeTransfuzie1.model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

public class PungaSange {

    public PungaSange() {
    }

    public PungaSange( DateTime dataPreluarii, float cantitateSange, float cantitateTrombocite, float cantitateGlobuleRosii, float cantitatePlasma)
    {
  
        DataPreluarii = dataPreluarii;
        CantitateSange = cantitateSange;
        CantitateTrombocite = cantitateTrombocite;
        CantitateGlobuleRosii = cantitateGlobuleRosii;
        CantitatePlasma = cantitatePlasma;
    }

    public int Id { get; set; }
    public CentruTransfuzie CentruTransfuzie { get; set; }

    [Required(ErrorMessage = "Donator is required")]
    public Donator Donator { get; set; }

    [Required(ErrorMessage = "DataPreluarii is required")]
    public DateTime DataPreluarii { get; set; }

    public float CantitateSange { get; set; }
    public float CantitateTrombocite { get; set; }
    public float CantitateGlobuleRosii { get; set; }
    public float CantitatePlasma { get; set; }
    public TraseuPunga TraseuPunga { get; set; }
    public Analiza Analiza { get; set; }



}