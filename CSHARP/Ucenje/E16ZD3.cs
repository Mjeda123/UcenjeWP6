using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E16ZD3
    {
        public static void Izvedi()
        {
            // Unos broja elemenata niza
            Console.Write("Unesite broj elemenata niza: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Deklaracija niza
            int[] niz = new int[n];

            // Unos vrijednosti u niz
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Unesite {i + 1}. broj: ");
                niz[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Izračunavanje zbroja svih elemenata niza
            int zbroj = 0;
            for (int i = 0; i < n; i++)
            {
                zbroj += niz[i];
            }

            // Ispis rezultata
            Console.WriteLine($"Zbroj svih elemenata niza je: {zbroj}");
        }
    }
}
