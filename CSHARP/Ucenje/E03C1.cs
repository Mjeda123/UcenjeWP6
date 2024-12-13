
namespace Ucenje
{

    // program od korisnika unosi dva cijela broja
    // program ispisuje u novim redovima
    //1. zbroj
    //2. razlika drugog i prvog
    //3. umnožak
    //4. zbroj kvadrata prvog i drugog broj
    //5. kvocijent prvog i drugog broja
    internal class E03C1
    {

        public static void Izvedi()
        {
            //Console.WriteLine("E03");

            Console.WriteLine("Unesi cijeli broj: ");
            int ab = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi cijeli broj: ");
            int bc = int.Parse(Console.ReadLine());

            int suma = ab + bc;

            Console.WriteLine("Suma brojeva je: " + suma);

            int razlika = ab - bc;

            Console.WriteLine("Razlika između brojeva je: " + razlika);

            int umnozak = ab * bc;

            Console.WriteLine("Umnožak brojeva je: " + umnozak);

            int kvadrat1 = ab * ab;
            int kvadrat2 = bc * bc;
            int zbrojKvadrata = kvadrat1 + kvadrat2;

            Console.WriteLine($"Zbroj kvadrata {ab} i {bc} je: {zbrojKvadrata}");

            if (bc == 0)
            {
                Console.WriteLine("Ne možete dijeliti s nulom.");
            }
            else 
            { 
                double kvocijent = ab / bc;

                Console.WriteLine($"Kvocijent {ab} i {bc} je: {kvocijent}");
            }
            
            


        }




    }
}
