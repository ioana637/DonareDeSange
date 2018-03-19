
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class UserDonator {

    public UserDonator() {
    }

    private int codUserDonator;

    private string username;

    private string parola;

    public UserDonator(int cod, string username, string parola)
    {
        this.codUserDonator = cod;
        this.username = username;
        this.parola = parola;
    }

    public int GetCodUserDonator() {
        return codUserDonator;
    }

    public void SetCodUserDonator(int value) {
        this.codUserDonator = value;
    }

    public string GetUsername() {
        return username;
    }

    public void SetUsername(string value) {
        this.username = value;
    }

    public string GetParola() {
        return parola;
    }

    public void SetParola(string value) {
        this.parola = value;
    }

}