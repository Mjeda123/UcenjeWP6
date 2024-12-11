using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10Z2
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E10");
            int b = 17;
            bool prin = true;
            for (int i = 2; i < b; i++)
            {
                if (b % i == 0) 
                {
                    prin = false;
                    break;
                }
            }
            Console.WriteLine(prin ? "DA" : "NE");
        }
    }
}
