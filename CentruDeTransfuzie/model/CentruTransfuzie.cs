
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CentruDeTransfuzie.model
{
    public class CentruTransfuzie
    {



        public int Id { get; set; }

        [Required(ErrorMessage = "Nume is required")]
        public string Nume { get; set; }

        [Required(ErrorMessage = "Zona is required")]
        public string Zona { get; set; }
        //[Required(ErrorMessage = "City is required")]
        public string Oras { get; set; }
        //[Required(ErrorMessage = "Judet is required")]
        public string Judet { get; set; }

        public List<Spital> Spitale { get; set; }
        public List<PungaSange> PungiSange { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Parola { get; set; }
        public CentruTransfuzie()
        {
        }

        public CentruTransfuzie(string nume, string zona, string oras, string judet)
        {

            Nume = nume;
            Zona = zona;
            Oras = oras;
            Judet = judet;
            Spitale = new List<Spital>();
            PungiSange = new List<PungaSange>();
        }

        public CentruTransfuzie(string nume, string zona, string oras, string judet, string parola) : this(nume, zona, oras, judet)
        {
            Parola = parola;
        }

        public override string ToString()
        {
            return Nume + "; " + Zona + "; " + Oras + "; " + Judet;
        }
    }
}