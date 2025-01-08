using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E16ZD8
    {
        public static void Izvedi()
        {
            // Pozdravna poruka
            Console.WriteLine("Pretvori temperaturu");

            // Tražimo od korisnika da odabere u kojoj skali želi unijeti temperaturu
            Console.WriteLine("Odaberite skalu u kojoj želite unijeti temperaturu:");
            Console.WriteLine("1. Celzijus (°C)");
            Console.WriteLine("2. Fahrenheit (°F)");

            // Unos od korisnika
            Console.Write("Vaš odabir (1 ili 2): ");
            int izbor = int.Parse(Console.ReadLine());

            // Ako korisnik odabere Celzijus
            if (izbor == 1)
            {
                // Unos temperature u Celzijusima
                Console.Write("Unesite temperaturu u Celzijusima: ");
                double tempCelsius = double.Parse(Console.ReadLine());

                // Pretvaranje u Fahrenheit
                double tempFahrenheit = (tempCelsius * 9 / 5) + 32;

                // Ispis rezultata
                Console.WriteLine($"{tempCelsius}°C je {tempFahrenheit}°F.");
            }
            // Ako korisnik odabere Fahrenheit
            else if (izbor == 2)
            {
                // Unos temperature u Fahrenheitu
                Console.Write("Unesite temperaturu u Fahrenheitu: ");
                double tempFahrenheit = double.Parse(Console.ReadLine());

                // Pretvaranje u Celzijus
                double tempCelsius = (tempFahrenheit - 32) * 5 / 9;

                // Ispis rezultata
                Console.WriteLine($"{tempFahrenheit}°F je {tempCelsius}°C.");
            }
            else
            {
                // Ako korisnik unese nevažeći broj
                Console.WriteLine("Nevažeći odabir. Molimo unesite 1 ili 2.");
            }
        }
    }
}
