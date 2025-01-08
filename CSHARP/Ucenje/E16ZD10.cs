using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E16ZD10
    {
        public static void Izvedi()
        {
            // Unos dva broja
            Console.Write("Unesite prvi broj: ");
            double broj1 = double.Parse(Console.ReadLine());

            Console.Write("Unesite drugi broj: ");
            double broj2 = double.Parse(Console.ReadLine());

            // Unos operacije
            Console.Write("Unesite operaciju (+, -, *, /): ");
            string operacija = Console.ReadLine();

            // Rezultat
            double rezultat = 0;

            // Korišćenje switch izjave za odabir operacije
            switch (operacija)
            {
                case "+":
                    rezultat = broj1 + broj2;
                    break;
                case "-":
                    rezultat = broj1 - broj2;
                    break;
                case "*":
                    rezultat = broj1 * broj2;
                    break;
                case "/":
                    // Provjera da li je dijeljenje sa nulom
                    if (broj2 == 0)
                    {
                        Console.WriteLine("Greška: Nema dijeljenje sa nulom!");
                        return; // Prekida program ako je dijeljenje sa nulom
                    }
                    rezultat = broj1 / broj2;
                    break;
                default:
                    // Ako unesena operacija nije prepoznata
                    Console.WriteLine("Greška: Nepoznata operacija!");
                    return; // Prekida program ako je operacija neprepoznata
            }

            // Ispis rezultata
            Console.WriteLine($"Rezultat: {broj1} {operacija} {broj2} = {rezultat}");
        }
    }
}
