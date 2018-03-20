
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CererePacienti {

    public CererePacienti() {
    }

    public int IdCerere;

    public int IdPacient;
    public Pacient Pacient { get; set; }
    public Cerere Cerere { get; set; }

}