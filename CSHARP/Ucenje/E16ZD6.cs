using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E16ZD6
    {
        public static void Izvedi()
        {
            // Unos stringa
            Console.Write("Unesite string: ");
            string unos = Console.ReadLine();

            // Okretanje stringa
            char[] niz = unos.ToCharArray(); // Pretvaranje stringa u niz znakova
            Array.Reverse(niz);               // Okretanje niza znakova

            // Ispis naopako
            string obrnutiString = new string(niz); // Pretvaranje niza znakova natrag u string
            Console.WriteLine("Naopako uneseni string je: " + obrnutiString);
        }
    }
}
