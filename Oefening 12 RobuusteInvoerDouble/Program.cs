using System;

namespace Oefening_12_RobuusteInvoerDouble
{
    class Program
    {
        static void Main(string[] args)
        {

            double getal;
            bool invoerOk = true;
            Console.Write("Voer een (double) getal in?: ");

            while (invoerOk)
            {
                invoerOk = double.TryParse(Console.ReadLine(), out getal);
                if (invoerOk)
                {
                    Console.WriteLine("Dank je voor het (double) getal.");
                    Console.Write("Gelieve nog een (double) getal in te voeren: ");
                }
                else
                {
                    Console.WriteLine("Einde (wegens geen double getal).");
                }
            }






            Console.ReadKey();

        }
    }
}
