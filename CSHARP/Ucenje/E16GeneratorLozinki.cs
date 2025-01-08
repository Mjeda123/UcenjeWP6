using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E16GeneratorLozinki
    {
        public static void Izvedi()
        {
            // Unos dužine lozinke
            Console.Write("Unesite dužinu lozinke: ");
            int duzina = int.Parse(Console.ReadLine());

            // Unos opcija za velika slova
            Console.Write("Uključiti velika slova? (da/ne): ");
            bool velikaSlova = Console.ReadLine().ToLower() == "da";

            // Unos opcija za mala slova
            Console.Write("Uključiti mala slova? (da/ne): ");
            bool malaSlova = Console.ReadLine().ToLower() == "da";

            // Unos opcija za brojeve
            Console.Write("Uključiti brojeve? (da/ne): ");
            bool brojevi = Console.ReadLine().ToLower() == "da";

            // Unos opcija za interpunkcijske znakove
            Console.Write("Uključiti interpunkcijske znakove? (da/ne): ");
            bool interpunkcija = Console.ReadLine().ToLower() == "da";

            // Unos pravila za početak lozinke
            Console.Write("Lozinka treba početi brojem? (da/ne): ");
            bool pocetakBroj = Console.ReadLine().ToLower() == "da";

            Console.Write("Lozinka treba početi interpunkcijskim znakom? (da/ne): ");
            bool pocetakInterpunkcija = Console.ReadLine().ToLower() == "da";

            // Unos pravila za završetak lozinke
            Console.Write("Lozinka treba završiti brojem? (da/ne): ");
            bool krajBroj = Console.ReadLine().ToLower() == "da";

            Console.Write("Lozinka treba završiti interpunkcijskim znakom? (da/ne): ");
            bool krajInterpunkcija = Console.ReadLine().ToLower() == "da";

            // Unos za ponavljajuće znakove
            Console.Write("Lozinka može imati ponavljajuće znakove? (da/ne): ");
            bool ponavljanje = Console.ReadLine().ToLower() == "da";

            // Unos broja lozinki koje treba generirati
            Console.Write("Unesite broj lozinki koje treba generirati: ");
            int brojLozinki = int.Parse(Console.ReadLine());

            // Generiranje i ispis lozinki
            for (int i = 0; i < brojLozinki; i++)
            {
                string lozinka = GenerirajLozinku(duzina, velikaSlova, malaSlova, brojevi, interpunkcija,
                                                  pocetakBroj, pocetakInterpunkcija, krajBroj, krajInterpunkcija, ponavljanje);
                Console.WriteLine($"Generirana lozinka {i + 1}: {lozinka}");
            }
        }

        static string GenerirajLozinku(int duzina, bool velikaSlova, bool malaSlova, bool brojevi, bool interpunkcija,
                                       bool pocetakBroj, bool pocetakInterpunkcija, bool krajBroj, bool krajInterpunkcija,
                                       bool ponavljanje)
        {
            StringBuilder lozinka = new StringBuilder();
            Random rand = new Random();

            // Definiramo skupove znakova
            string velikaSlovaSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string malaSlovaSet = "abcdefghijklmnopqrstuvwxyz";
            string brojeviSet = "0123456789";
            string interpunkcijaSet = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

            // Kreiramo prazan skup znakova na temelju odabira korisnika
            string validniZnakovi = "";
            if (velikaSlova) validniZnakovi += velikaSlovaSet;
            if (malaSlova) validniZnakovi += malaSlovaSet;
            if (brojevi) validniZnakovi += brojeviSet;
            if (interpunkcija) validniZnakovi += interpunkcijaSet;

            // Provjeravamo da li korisnik nije odabrao nijedan tip znakova
            if (validniZnakovi.Length == 0)
            {
                throw new InvalidOperationException("Morate uključiti barem jedan tip znakova (velika slova, mala slova, brojevi, interpunkcija).");
            }

            // Prilagodba za pravila o početku i završetku lozinke
            if (pocetakBroj || pocetakInterpunkcija)
            {
                // Lozinka mora početi s brojem ili interpunkcijskim znakom
                if (pocetakBroj)
                {
                    lozinka.Append(brojeviSet[rand.Next(brojeviSet.Length)]);
                }
                else if (pocetakInterpunkcija)
                {
                    lozinka.Append(interpunkcijaSet[rand.Next(interpunkcijaSet.Length)]);
                }
            }

            // Ispunjavanje sredine lozinke
            while (lozinka.Length < duzina)
            {
                char znak = validniZnakovi[rand.Next(validniZnakovi.Length)];

                if (!ponavljanje && lozinka.ToString().Contains(znak))
                {
                    continue;  // Preskoči znak ako ne želimo ponavljanje
                }

                lozinka.Append(znak);
            }

            // Provjeravamo pravila za završetak lozinke
            if (krajBroj || krajInterpunkcija)
            {
                // Lozinka mora završiti s brojem ili interpunkcijskim znakom
                if (krajBroj)
                {
                    lozinka[lozinka.Length - 1] = brojeviSet[rand.Next(brojeviSet.Length)];
                }
                else if (krajInterpunkcija)
                {
                    lozinka[lozinka.Length - 1] = interpunkcijaSet[rand.Next(interpunkcijaSet.Length)];
                }
            }

            // Ako lozinka počinje s brojem ili interpunkcijskim znakom, vratit ćemo lozinku sa željenom dužinom
            return lozinka.ToString();
        }
    }
}
