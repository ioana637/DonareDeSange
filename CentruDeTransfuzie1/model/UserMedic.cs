
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class UserMedic {

   
    private int codUserMedic;

    private string username;

    private string parola;


    public  UserMedic(int cod, string username, string parola) {
        this.codUserMedic = cod;
        this.username = username;
        this.parola = parola;
    }

    public int GetCodUserMedic() {
       
        return codUserMedic;
    }

    public void SetCodUserMedic(int value) {
        this.codUserMedic = value;
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