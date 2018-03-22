
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Spital {

    public Spital() {
    }

    public Spital(string adresa, string oras, string judet)
    {
        Adresa = adresa;
        Oras = oras;
        Judet = judet;
        SpitalMedici = new List<SpitalMedic>();
    }

    public int Id { get; set; }
    public CentruTransfuzie CentruTransfuzie { get; set; }
    public List<SpitalMedic> SpitalMedici { get; set; }
    public string Adresa { get; set; }
    public string Oras { get; set; }
    public string Judet { get; set; }


}