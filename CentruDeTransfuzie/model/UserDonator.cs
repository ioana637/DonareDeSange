
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

public class UserDonator
{



    public int Id { get; set; }

    [Required(ErrorMessage = "Username is required")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    public string Parola { get; set; }

    [Required(ErrorMessage = "Donator is required")]
    public Donator Donator { get; set; }

    public UserDonator(string username, string parola)
    {
        Username = username;
        Parola = parola;
    }

    public UserDonator()
    {
    }
}