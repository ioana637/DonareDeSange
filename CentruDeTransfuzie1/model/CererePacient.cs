
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CererePacient {

    public CererePacient() {
    }

    public int IdCerere { get; set; }

    public int IdPacient { get; set; }
    public Pacient Pacient { get; set; }
    public Cerere Cerere { get; set; }

}