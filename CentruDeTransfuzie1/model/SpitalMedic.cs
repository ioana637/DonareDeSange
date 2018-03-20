
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SpitalMedic {

    public SpitalMedic() {
    }

    public int IdSpital { get; set; }

    public int IdMedic { get; set; }
    public List<Medic> Medici { get; set; }
    public List<Spital> Spitale { get; set; }

}