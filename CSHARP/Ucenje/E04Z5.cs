using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04Z5
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E04");
            Console.WriteLine("Unesite ime grada:");
            string grad = Console.ReadLine();

            // Provjera regije koristeći if
            if (grad == "Osijek")
            {
                Console.WriteLine("Regija: Slavonija");
            }
            else if (grad == "Zadar")
            {
                Console.WriteLine("Regija: Dalmacija");
            }
            else if (grad == "Čakovec")
            {
                Console.WriteLine("Regija: Međimurje");
            }
            else if (grad == "Pula")
            {
                Console.WriteLine("Regija: Istra");
            }
            else
            {
                Console.WriteLine("Ne znam koja je to regija.");
            }
        }
    }
}
