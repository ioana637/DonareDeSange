
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Donator
{

    public int Id { get; set; }

    public string Nume { get; set; }

    public string Prenume { get; set; }

    public string Sex { get; set; }

    public DateTime DataNastere { get; set; }

    public string Domiciliu { get; set; }

    public string Localitate { get; set; }

    public string Judet { get; set; }

    public string Resedinta { get; set; }

    public string LocalitateResedinta { get; set; }

    public string JudetResedinta { get; set; }

    public string Telefon { get; set; }

    public string Email { get; set; }

    public float Greutate { get; set; }

    public int Puls { get; set; }

    public int Tensiune { get; set; }

    public bool InterventiiUltimele6Luni { get; set; }

    public bool SubTratament { get; set; }

    public UserDonator UserDonator { get; set; }

    public Donator(string nume, string prenume, string sex, DateTime dataNastere, string domiciliu, string localitate, string judet, string resedinta, string localitateResedinta, string judetResedinta, string telefon, string email, float greutate, bool interventiiUltimele6Luni, bool subTratament)
    {
        Nume = nume;
        Prenume = prenume;
        Sex = sex;
        DataNastere = dataNastere;
        Domiciliu = domiciliu;
        Localitate = localitate;
        Judet = judet;
        Resedinta = resedinta;
        LocalitateResedinta = localitateResedinta;
        JudetResedinta = judetResedinta;
        Telefon = telefon;
        Email = email;
        Greutate = greutate;
        InterventiiUltimele6Luni = interventiiUltimele6Luni;
        SubTratament = subTratament;
    }

    public Donator()
    {
    }
}