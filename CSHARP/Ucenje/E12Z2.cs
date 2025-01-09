using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E12Z2
    {
        public static void Izvedi()
        {
            int redova = 5; //E12Metode.UcitajCijeliBroj("Unesi broj redova: ");
            int kolona = 5; //E12Metode.UcitajCijeliBroj("Unesi broj kolona: ");

            int[,] tablica = new int[redova, kolona];

            IspisiTablicu(tablica);
            int brojac = 1;
            for(int i = kolona - 1; i >= 0; i--)
            {
                tablica[redova - 1, i] = brojac++;
            }

            IspisiTablicu(tablica);

        }

        private static void IspisiTablicu(int[,] tablica)
        {
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*************************");
        }
    }
}
