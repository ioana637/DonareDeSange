
using CentruDeTransfuzie1.model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

public class Donator
{

    public int Id { get; set; }

    public string Nume { get; set; }

    public string Prenume { get; set; }

    [Required(ErrorMessage = "Gender is required")]
    [MaxLength(1)]
    [RegularExpression("[FM]", ErrorMessage = "Gender must be F(female) OR M(male)")]
    public string Sex { get; set; }

    [Required(ErrorMessage = "DataNastere is required")]
    public DateTime DataNastere { get; set; }

    public string Domiciliu { get; set; }

    public string Localitate { get; set; }

    public string Judet { get; set; }

    public string Resedinta { get; set; }

    public string LocalitateResedinta { get; set; }

    public string JudetResedinta { get; set; }

    [Required(ErrorMessage = "Telefon is required")]
    [DataType(DataType.PhoneNumber)]
    public string Telefon { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    public float Greutate { get; set; }

    public int Puls { get; set; }

    public int TensiuneSistolica { get; set; }
    public int TensiuneDiastolica { get; set; }

    public int InterventiiUltimele6Luni { get; set; }

    public int SubTratament { get; set; }


    

    [MaxLength(1)]
    [RegularExpression("[TF]", ErrorMessage = "Activ must be T(true) OR F(false)")]
    public string Activ { get; set; }

    public UserDonator UserDonator { get; set; }
    public List<PungaSange> PungiSange { get; set; }

    public List<Analiza> Analize { get; set; }

    public Donator(string nume, string prenume, string sex, DateTime dataNastere, string domiciliu, string localitate, string judet, string resedinta, string localitateResedinta, string judetResedinta, string telefon, string email)
    {
        Activ = "T";
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
        Greutate = 0;
        InterventiiUltimele6Luni = 0;
        SubTratament = 0;
        PungiSange = new List<PungaSange>();
        Analize = new List<Analiza>();
    }

    public Donator()
    {
    }
}
