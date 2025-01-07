using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E16ZD1
    {
        public static void Izvedi()
        {
            // Unos duljine i širine pravokutnika
            Console.Write("Unesite duljinu pravokutnika: ");
            double duljina = Convert.ToDouble(Console.ReadLine());

            Console.Write("Unesite širinu pravokutnika: ");
            double sirina = Convert.ToDouble(Console.ReadLine());

            // Izračunavanje površine
            double povrsina = duljina * sirina;

            // Ispis rezultata
            Console.WriteLine($"Površina pravokutnika je: {povrsina}");
        }
    }
}
