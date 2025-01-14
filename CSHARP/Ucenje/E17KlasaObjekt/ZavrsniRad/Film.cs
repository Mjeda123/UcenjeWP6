using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.ZavrsniRad
{
    public class Film
    {
        public int Sifra { get; set; }
        public string Naziv { get; set; } = "";
        public string? Zanr { get; set; }   

        public string NazivZanr()
        {
            return Naziv + " " + Zanr;
        }
    }
}
