
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace CentruDeTransfuzie.model
{
    public class PungaSange
    {

        public PungaSange()
        {
        }

        public PungaSange(DateTime dataPreluarii, float cantitateSange, float cantitateTrombocite, float cantitateGlobuleRosii, float cantitatePlasma)
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
        public bool EliminatTrombocite { get; set; }
        public bool EliminatGlobuleRosii { get; set; }

        public bool EliminatPlasma { get; set; }
        public bool EliminatSange{get;set;}

        public TraseuPunga TraseuPunga { get; set; }
        public Analiza Analiza { get; set; }

        public override string ToString()
        {
            return "Nr. " + Id + " din data " + DataPreluarii;
        }
    }
}