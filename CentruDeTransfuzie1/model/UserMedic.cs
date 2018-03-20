
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class UserMedic {

    public int Id { get; set; }

    public string Username { get; set; }

    public string Parola { get; set; }

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