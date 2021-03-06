
using CentruDeTransfuzie.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CentruDeTransfuzie.model
{
    public class Cerere
    {

        public Cerere()
        {
            CererePacienti = new List<CererePacient>();

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

        [Required(ErrorMessage = "Grupa is required")]
        public GrupaSange Grupa { get; set; }

        [Required(ErrorMessage = "RH is required")]
        public TipRh RH { get; set; }

        [Required(ErrorMessage = "Prioritate is required")]
        public GradUrgenta Prioritate { get; set; }

        public List<CererePacient> CererePacienti { get; set; }

        public Cerere(string data, float cantitateSange, float cantitateTrombocite, float cantitateGlobuleRosii, float cantitatePlasma, bool efectuata, Medic m, GrupaSange grupaSange, TipRh tipRh)
        {

            Data = data;
            CantitateSange = cantitateSange;
            CantitateTrombocite = cantitateTrombocite;
            CantitateGlobuleRosii = cantitateGlobuleRosii;
            CantitatePlasma = cantitatePlasma;
            Efectuata = efectuata;
            Medic = m;
            CererePacienti = new List<CererePacient>();
            Grupa = grupaSange;
            RH = tipRh;
            CererePacienti = new List<CererePacient>();
        }
    }
}