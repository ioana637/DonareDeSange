
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CentruTransfuzie {

  

    public int Id { get; set; }
    public string Nume { get; set; }
    public string Zona { get; set; }
    public string Oras { get; set; }
    public string Judet { get; set; }

    public List<Spital> Spitale { get; set; }
    public List<PungaSange> PungiSange { get; set; }
    public CentruTransfuzie()
    {
    }

    public CentruTransfuzie( string nume, string zona, string oras, string judet)
    {
       
        Nume = nume;
        Zona = zona;
        Oras = oras;
        Judet = judet;
        Spitale = new List<Spital>();
        PungiSange = new List<PungaSange>();
    }


}