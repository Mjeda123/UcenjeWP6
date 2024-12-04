

namespace Ucenje
{
    internal class E03Operatori
    {
        public static void Izvodi()
        {

            //Console.WriteLine("E03");
            //operatori za rad s varijablama
            // = je dodijljivanje vrijednosti
            // == provjera jednakosti --> bool

            int i = 7; // sada zamislimo da je korisnik unio 7

            Console.WriteLine(i==6);

            // operatori + - * /

            int k = 2, l = 1;

            Console.WriteLine(l/k);

            Console.WriteLine(l/(float)k);

            Console.WriteLine(i!=k);

            // operator modul %

            Console.WriteLine("5%2={0}", 5 % 2);
            Console.WriteLine("4%2={0}", 4 % 2);

            // automatsko kom ctrl k d

            // uvećavanje za 1

            int b = 0;

            // uvećaj za 1
            b = b + 1; //1

            // kraće b +=1;
            b += 1;//2
            // najkraće b++;
            b++;//3

            // vrijedi i za -, prva dva vrijede i za * 1

            Console.WriteLine(b);

            // increment i decrement

            b = 0;

            // b++ prvo koristi pa uveća
            Console.WriteLine(b++); //0

            // ++b prvo uvećaj pa onda koristi
            Console.WriteLine(++b); //2

            // isto vrijedi i b-- i --b

            int t = 0, c = 1;
            t = c++ + t; // t = 1, c = 2
            c += --t; // C = 4, t = 2
            Console.WriteLine(c+t); //6


        }



    }
}
