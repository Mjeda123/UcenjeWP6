using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04Z3
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E04");

            Console.WriteLine("Unesi jedan cijeli broj: ");
            int broj1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi cijeli broj: ");
            int broj2 = int.Parse(Console.ReadLine());

            int manji = (broj1 < broj2) ? broj1 : broj2;

            Console.WriteLine("Manji broj je: " + manji);

            //if(a+b)



        }


    }
}
