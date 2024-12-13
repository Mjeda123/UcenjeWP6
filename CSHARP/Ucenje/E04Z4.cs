using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04Z4
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E04");
            Console.WriteLine("Unesite prvi broj:");
            int broj1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj:");
            int broj2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite treći broj:");
            int broj3 = int.Parse(Console.ReadLine());

            int najmanji = Math.Min(Math.Min(broj1, broj2), broj3);

            
            Console.WriteLine("Najmanji broj je: " + najmanji);
        }
    }
}
