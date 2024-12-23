using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    //abba
    //kisik
    //anavolimilovana
    //amenetuniminutenema


    internal class E10Z3
    {
        public static void Izvedi()
        {
            string s = "Ružanedoodenažur";
            Console.WriteLine(string.Join(';', s.ToCharArray()));

            Console.WriteLine("palindrom");
            string izraz = E12Metode.UcitajString("Unesi izraz za provjeru palindroma: ");

            bool palindrom = true;
            izraz = izraz.ToUpper();
            Console.WriteLine(izraz[0]);
            Console.WriteLine(izraz[izraz.Length-1-0]);

            Console.WriteLine(izraz[1]);
            Console.WriteLine(izraz[izraz.Length-1-1]);
            for(int i = 0; i < izraz.Length/2; i++)
            {
                if (izraz[i] != izraz[izraz.Length-1 -i])
                {
                    palindrom = false;
                    break;
                }
            }

            Console.WriteLine("Izraz {0} {1} palindrom", izraz, palindrom ? "JE" : "NIJE");
        }

    }
}
