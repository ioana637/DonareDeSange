
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Medic
{

    public int Id { get; set; }

    public string Cnp { get; set; }

    public string Nume { get; set; }

    public string Prenume { get; set; }

    public string Email { get; set; }

    public string Telefon { get; set; }

    public UserMedic UserMedic { get; set; }
    public List<Cerere> Cereri { get; set; }
    public List<SpitalMedic> SpitaleMedic { get; set; }
    public List<Pacient> Pacienti { get; set; }

    public Medic(string cnp, string nume, string prenume, string email, string telefon)
    {
        Cnp = cnp;
        Nume = nume;
        Prenume = prenume;
        Email = email;
        Telefon = telefon;
    }

    public Medic()
    {
    }
}