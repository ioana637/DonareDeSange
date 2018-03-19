
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Donator {

    private int codDonator;

    private string nume;

    private string prenume;

    private string sex;

    private DateTime dataNastere;

    private string domiciliu;

    private string localitate;

    private string judet;

    private string resedinta;

    private string localitateResedinta;

    private string judetResedinta;

    private string telefon;

    private string email;

    private float greutate;

    private int puls;

    private int tensiune;

    private bool interventiiUltimele6Luni;

    private bool subTratament;

    public Donator(int cod, string nume, string prenume, string sex, DateTime data, string domiciliu, string localitate, string judet, string resedinta, string locResedinta, string judResedinta, string telefon, string email)
    {
        this.codDonator = cod;
        this.nume = nume;
        this.prenume = prenume;
        this.sex = sex;
        this.dataNastere = data;
        this.domiciliu = domiciliu;
        this.localitate = localitate;
        this.judet = judet;
        this.resedinta = resedinta;
        this.localitateResedinta = locResedinta;
        this.judetResedinta = judResedinta;
        this.email = email;
        this.telefon = telefon;

    }



    public int GetCodDonator() {
        return codDonator;
    }

    public void SetCodDonator(int value) {
        this.codDonator = value;
    }

    public string GetNume() {
        return nume;
    }

    public void SetNume(string value) {
        this.nume = value;
    }

    public string GetPrenume() {
        return prenume;
    }

    public void SetPrenume(string value) {
        this.prenume = value;
    }

    public string GetSex() {
        return sex;
    }

    public void SetSex(string value) {
        this.sex = value;
    }

    public DateTime GetDataNastere() {
        return dataNastere;
    }

    public void SetDataNastere(DateTime value) {
        this.dataNastere = value;
    }

    public string GetDomiciliu() {
        return domiciliu;
    }

    public void SetDomiciliu(string value) {
        this.domiciliu = value;
    }

    public string GetLocalitate() {
        return localitate;
    }

    public void SetLocalitate(string value) {
        this.localitate = value;
    }

    public string GetJudet() {
        return judet;
    }

    public void SetJudet(string value) {
        this.judet = value;
    }

    public string GetResedinta() {
        return resedinta;
    }

    public void SetResedinta(string value) {
        this.resedinta = value;
    }

    public string GetLocalitateResedinta() {
        return localitateResedinta;
    }

    public void SetLocalitateResedinta(string value) {
        this.localitateResedinta = value;
            }

    public string GetJudetResedinta() {
        return judetResedinta;
    }

    public void SetJudetResedinta(string value) {
        this.judetResedinta = value;
    }

    public string GetTelefon() {
        return telefon;
    }

    public void SetTelefon(string value) {
        this.telefon = value;
    }

    public string GetEmail() {
        return email;
    }

    public void SetEmail(string value) {
        this.email = value;
    }

    public float GetGreutate()
    {
        return greutate;
    }

    public void SetGreutate(float value)
    {
        this.greutate = value;
    }

    public int GetPuls()
    {
        return puls;
    }

    public void SetPuls(int value)
    {
        this.puls = value;
    }

    public int GetTensiune()
    {
        return tensiune;
    }

    public void SetTensiune(int value)
    {
        this.tensiune = value;
    }

    public bool GetInterventiiUltimele6Luni()
    {
        return interventiiUltimele6Luni;
    }

    public void SetInterventiiUltimele6Luni(bool value)
    {
        this.interventiiUltimele6Luni = value;
    }

    public bool GetSubTratament()
    {
        return subTratament;
    }

    public void SetSubTratament(bool value)
    {
        this.subTratament = value;
    }


}