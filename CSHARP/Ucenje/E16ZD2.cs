using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E16ZD2
    {
        public static void Izvedi()
        {
            // Unos broja
            Console.Write("Unesite broj: ");
            int broj = Convert.ToInt32(Console.ReadLine());

            // Provjera broja i ispis rezultata
            if (broj > 0)
            {
                Console.WriteLine("Broj je pozitivan.");
            }
            else if (broj < 0)
            {
                Console.WriteLine("Broj je negativan.");
            }
            else
            {
                Console.WriteLine("Broj je nula.");
            }
        }
    }
}
