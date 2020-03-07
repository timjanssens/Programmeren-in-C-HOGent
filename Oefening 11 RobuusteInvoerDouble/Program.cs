using System;

namespace Oefening_11_RobuusteInvoerDouble
{
    class Program
    {
        static void Main(string[] args)
        {

            double getal;
            bool invoerOK;

            do
            {
                Console.Write("Voer een (Double) getal in: ");
                invoerOK = double.TryParse(Console.ReadLine(), out getal);

            } while (invoerOK);


            Console.WriteLine("Einde (wegens geen double getal).");

            Console.ReadKey();
        }
    }
}
