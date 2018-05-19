
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CentruDeTransfuzie.model
{

    public class Medic
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "CNP is required")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "CNP must have exactly 13 digits")]
        [RegularExpression("[1234567890]", ErrorMessage = "cnp must have just digits")]
        public string Cnp { get; set; }

        [Required(ErrorMessage = "Nume is required")]
        public string Nume { get; set; }

        public string Prenume { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon is required")]
        [DataType(DataType.PhoneNumber)]
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
}