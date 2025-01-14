using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.ZavrsniRad
{
    public class Karta
    {
        public int Sifra { get; set; }
        public decimal Cijena { get; set; }
        public Gledatelj[]? Gledatelji { get; set; }
        public Projekcija Projekcija { get; set; }  = new Projekcija();

        public void DetaljiKarte()
        {
            Console.WriteLine(Cijena);
            Console.WriteLine(Projekcija.Dvorana);
            foreach (Gledatelj g in Gledatelji?? [])
            {
                Console.WriteLine(g.ImePrezime());
            }
        }
    }
}
