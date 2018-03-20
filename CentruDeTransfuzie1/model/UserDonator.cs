
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class UserDonator
{



    public int Id { get; set; }

    public string Username { get; set; }

    public string Parola { get; set; }

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