using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt
{
    public class Program
    {
        public Program() { 

            Osoba osoba = new Osoba();

            osoba.Sifra = 1;

            osoba.Ime = "Pero";
            osoba.Prezime = "Perić";

            Console.WriteLine(osoba.Ime);

            osoba = new Osoba() { 
                Sifra=2,
                Ime="Karlo",
                Prezime="Lik"
            };

            Console.WriteLine("{0} {1}", osoba.Ime, osoba.Prezime);
            Console.WriteLine(osoba.ImePrezime());

            Osoba.Izvedi();

            Mjesto mjesto = new Mjesto() { Naziv = "Osijek", PostanskiBroj = "31000" };

            //osoba.Mjesto = mjesto;

            Console.WriteLine(osoba.Mjesto.Naziv);
        
        }
    }
}
