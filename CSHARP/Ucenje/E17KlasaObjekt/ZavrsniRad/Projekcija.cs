using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.ZavrsniRad
{
    public class Projekcija
    {
        public int Sifra { get; set; }
        public Film Film { get; set; } = new Film();
        public DateTime Termin { get; set; }
        public Dvorana Dvorana { get; set; } = new Dvorana();
    }
}
