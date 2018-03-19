
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Medic {

    private int codMedic;

    private string cnp;

    private string nume;

    private string prenume;

    private string email;

    private string telefon;

    public Medic(int codMedic, string cnp, string nume, string prenume, string email, string telefon)
    {
        this.codMedic = codMedic;
        this.cnp = cnp;
        this.nume = nume;
        this.prenume = prenume;
        this.email = email;
        this.telefon = telefon;
    }

    public int GetCodMedic()
    {
        return codMedic;
    }

    public void SetCodMedic(int value)
    {
        this.codMedic = value;
    }

    public string GetCnp()
    {
        return cnp;
    }

    public void SetCnp(string value)
    {
        this.cnp = value;
    }

    public string GetNume()
    {
        return nume;
    }

    public void SetNume(string value)
    {
        this.nume = value;
    }

    public string GetPrenume()
    {
        return prenume;
    }

    public void SetPrenume(string value)
    {
        this.prenume = value;
    }

    public string GetEmail()
    {
        return email;
    }

    public void SetEmail(string value)
    {
        this.email = value;
    }

    public string GetTelefon()
    {
        return telefon;
    }

    public void SetTelefon(string value)
    {
        this.telefon = value;
    }

}