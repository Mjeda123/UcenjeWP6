using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E16ZD9
    {
        public static void Izvedi()
        {
            // Tražimo od korisnika da unese broj elemenata niza
            Console.Write("Unesite broj elemenata niza: ");
            int n = int.Parse(Console.ReadLine());

            // Deklaracija niza cijelih brojeva sa veličinom n
            int[] niz = new int[n];

            // Unos vrijednosti u niz
            Console.WriteLine("Unesite elemente niza:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                niz[i] = int.Parse(Console.ReadLine());
            }

            // Sortiranje niza uzlazno
            Array.Sort(niz);

            // Ispis sortiranja niza
            Console.WriteLine("\nSortirani niz:");
            foreach (int broj in niz)
            {
                Console.Write(broj + " ");
            }
        }
    }
}
