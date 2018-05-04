
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    public Spital(CentruTransfuzie centruTransfuzie, string adresa, string oras, string judet)
    {
        CentruTransfuzie = centruTransfuzie;
        Adresa = adresa;
        Oras = oras;
        Judet = judet;
        SpitalMedici = new List<SpitalMedic>();
    }

    public int Id { get; set; }

    [Required(ErrorMessage = "CentruTransfuzie is required")]
    public CentruTransfuzie CentruTransfuzie { get; set; }

    public List<SpitalMedic> SpitalMedici { get; set; }
    public string Adresa { get; set; }
    public string Oras { get; set; }
    public string Judet { get; set; }

    public override string ToString()
    {
        return Adresa +"; "+ Oras + "; "+Judet;
    }
}