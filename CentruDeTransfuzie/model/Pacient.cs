
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

public class Pacient {

    public Pacient() {
    }

    public Pacient(string nume, string prenume, string email, bool eDonator)
    {
        Nume = nume;
        Prenume = prenume;
        Email = email;
        EDonator = eDonator;
 
    }

    public int Id { get; set; }

    [Required(ErrorMessage = "Nume is required")]
    public string Nume { get; set; }
    public string Prenume { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    public bool EDonator { get; set; }
    public Medic Medic { get; set; }
    public List<CererePacient> CereriPacienti { get; set; }




}