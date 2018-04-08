using CentruDeTransfuzie1.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CentruDeTransfuzie1.model
{
    
    public class Analiza
    {
    

       public int Id { get; set; }

       [Required(ErrorMessage = "Donator is required")]
       public Donator Donator { get; set; }

        public PungaSange PungaSange { get; set; }
        public GrupaSange Grupa { get; set; }
        public TipRh Rh { get; set; }

        public bool HIV { get; set; } 
      
       public bool HepatitaB { get; set; }
    
       public bool HepatitaC { get; set; }
      
       public bool Sifilis { get; set; }
        
       public bool HTLV { get; set; }
     
       public int NivelALT { get; set; }

        public Analiza(GrupaSange grupa, TipRh rh, bool hIV, bool hepatitaB, bool hepatitaC, bool sifilis, bool hTLV, int nivelALT)
        {
         
            Grupa = grupa;
            Rh = rh;
            HIV = hIV;
            HepatitaB = hepatitaB;
            HepatitaC = hepatitaC;
            Sifilis = sifilis;
            HTLV = hTLV;
            NivelALT = nivelALT;
        }

        public Analiza()
        {
        }
    }
}
