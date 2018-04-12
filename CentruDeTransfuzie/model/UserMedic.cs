
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

public class UserMedic
{

    public int Id { get; set; }

    [Required(ErrorMessage = "Username is required")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    public string Parola { get; set; }

    [Required(ErrorMessage = "Medic is Required")]
    public Medic Medic { get; set; }

    public UserMedic(string username, string parola)
    {
        Username = username;
        Parola = parola;
    }

    public UserMedic()
    {
    }
}