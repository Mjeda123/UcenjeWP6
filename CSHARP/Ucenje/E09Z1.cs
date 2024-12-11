using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E09Z1
    {
        public static void Izvedi()
        {
            //Console.WriteLine("Z1");

            Console.Write("Unesi cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());
            Console.WriteLine(broj);

            int i = 0, suma = 0;
            while (i <= broj)
            {
                if (++i%2 == 0)
                {
                    suma += i;

                }
               
            
            }
            Console.WriteLine(suma);
        }

    }
}
