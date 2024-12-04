

namespace Ucenje
{

    // Napišite program koji unosi ime i broj godina

    // Program ispisuje: Osoba XXXXX ima YY godina


    internal class E02Z1
    {

        public static void Izvedi()
        {

            Console.Write("Unesi ime: ");

            string ime = Console.ReadLine();
            Console.Write("Unesi broj godina (cijeli broj): ");
            int godine = int.Parse(Console.ReadLine());

            Console.WriteLine("Osoba {0} ima {1} godina.", ime, godine);

        }



    }
}
