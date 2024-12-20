using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E12Metode
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E12");
            // metode dva dijela 1 tijelo metode 2. poziv metode
            Tip1();
            Tip1();
            
            Tip2(7);
            Tip2(5);

            Tip2(10, "Poziv druge varijante i metode Tip2");

            int i = Tip3() + 1;
            Console.WriteLine(i);

            int[] niz = { 2, 5, 2, 1, 4, 1, 2, 1, 4, 2, 3 };
            Console.WriteLine(Tip4(niz));

            Tip4(niz);
            
        }

        // tijelo metode
        // ne prima parametre ne vraća vrijednost
        static void Tip1(/*Ovdje dođu parametri ili ne*/)
        {
            Console.WriteLine("Ispis iz 1. tipa metode");
            Console.WriteLine("***********************");
            Console.WriteLine("Kraj ispisa iz 1. tipa metode");
        }

        // tip 2 prima parametre ali ne vraća vrijednost
        private static void Tip2(int x) // x je parametar tipa int
        {
            for (int i = 0; i < x; i++) 
            {
                Console.WriteLine(i);
            }
        
        }

        // potpis metode
        // naziv + lista parametara
        // metod overloading
        private static void Tip2(int x, string naslov)
        {
            Console.WriteLine(naslov);
            Tip2(x);
        }

        //trip3 ne prima parametre vraća vrijednost
        private static int Tip3()
        {
            return int.MaxValue;
        }

        // 4 vraća parametr
        /// <summary>
        /// 
        /// </summary>
        /// <param name="niz"></param>
        /// <returns></returns>
        private static int Tip4(int[] niz)
        {
            int suma = 0;
            foreach(int i in niz)
            {
                suma += i;
            }
            return suma;
        }


        // nama bitne metode
        // write once, use everywhere

        public static int UcitajCijeliBroj(string poruka)
        {
            while (true) 
            {
                Console.Write(poruka);
                try
                {

                    return int.Parse(Console.ReadLine());

                }
                catch 
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                    
                }
            
            }


            //return 0;
        }


        public static int UcitajCijeliBroj(string poruka, int min, int max)
        {
            int i;
            while (true)
            {
                Console.Write(poruka);
                try
                {

                    i = int.Parse(Console.ReadLine());
                    if(i < min || i > max)
                    {
                        Console.WriteLine("Broj nije u danom rasponu {0} - {1}",min,max);
                        continue;
                    }
                    return i;

                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");

                }

            }


            //return 0;
        }








        public static string UcitajString(string poruka) 
        {
            string s = "";
            while (true) 
            {
                Console.Write(poruka);
                s += Console.ReadLine().Trim();
                if(s.Length == 0)
                {
                    Console.WriteLine("Obavezan unos");
                    continue;
                }
                return s;
            }
            
            
            
            //return "";
        
        }



    }
}
