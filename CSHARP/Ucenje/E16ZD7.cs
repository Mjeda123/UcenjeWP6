using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E16ZD7
    {
        public static void Izvedi()
        {
            // Tražimo od korisnika da unese string
            Console.Write("Unesite string: ");
            string input = Console.ReadLine();

            // Definiranje samoglasnika
            string samoglasnici = "aeiouAEIOU";

            int brojSamoglasnika = 0;

            // Prolazimo kroz svaki karakter u stringu
            foreach (char c in input)
            {
                // Ako je karakter samoglasnik, povećaj brojač
                if (samoglasnici.Contains(c))
                {
                    brojSamoglasnika++;
                }
            }

            // Ispisujemo rezultat
            Console.WriteLine("Broj samoglasnika u unesenom stringu je: " + brojSamoglasnika);
        }
    }
}
