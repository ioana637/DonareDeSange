
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CererePacient {

    public CererePacient() {
    }

    public CererePacient(int idc,int idp)
    {
        this.IdCerere = idc;
        this.IdPacient = idp;
    }

    public int IdCerere { get; set; }

    public int IdPacient { get; set; }
    public Pacient Pacient { get; set; }
    public Cerere Cerere { get; set; }

}