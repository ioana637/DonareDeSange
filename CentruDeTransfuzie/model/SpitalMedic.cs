
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SpitalMedic {

    public SpitalMedic() {
    }

    public int IdSpital { get; set; }

    public int IdMedic { get; set; }
    public Medic Medic { get; set; }
    public Spital Spital { get; set; }

}