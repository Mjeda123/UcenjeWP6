using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E16ZD5
    { 
        public static void Izvedi()
        {
            // Unos broja n
            Console.Write("Unesite broj n (koliko brojeva Fibonaccijevog niza želite ispisati): ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Provjera da broj n bude veći od 0
            if (n <= 0)
            {
                Console.WriteLine("Unesite broj veći od 0.");
                return;
            }

            // Deklaracija prvih dva broja Fibonaccijevog niza
            long a = 0, b = 1;

            // Ispis prvih n brojeva Fibonaccijevog niza
            Console.WriteLine("Prvih {0} brojeva Fibonaccijevog niza:", n);

            for (int i = 0; i < n; i++)
            {
                // Ispis trenutnog broja u nizu
                Console.Write(a + " ");

                // Izračun sljedećeg broja u nizu
                long temp = a;
                a = b;
                b = temp + b;
            }

            // Novi red nakon ispisivanja brojeva
            Console.WriteLine();
        }
    }
}
