using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E16ZD4
    {
        public static void Izvedi()
        {
            // Unos broja ocjena
            Console.Write("Unesite broj ocjena: ");
            int brojOcjena = Convert.ToInt32(Console.ReadLine());

            // Deklaracija niza za pohranu ocjena
            double[] ocjene = new double[brojOcjena];

            // Unos ocjena u niz
            for (int i = 0; i < brojOcjena; i++)
            {
                Console.Write($"Unesite {i + 1}. ocjenu: ");
                ocjene[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Izračunavanje prosjeka ocjena
            double zbroj = 0;
            for (int i = 0; i < brojOcjena; i++)
            {
                zbroj += ocjene[i];
            }

            double prosjek = zbroj / brojOcjena;

            // Ispis rezultata
            Console.WriteLine($"Prosjek ocjena je: {prosjek:F2}");
        }
    }
}
