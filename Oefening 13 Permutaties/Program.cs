using System;

namespace Oefening_13_Permutaties
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Aantal liedjes in de playlist?: ");
            int aantalLiedjes;
            if (int.TryParse(Console.ReadLine(), out aantalLiedjes) && aantalLiedjes >= 1)
            {
                int faculteit = 1;
                int teller = 1;
                while (teller <= aantalLiedjes)
                {
                    faculteit *= teller;
                    teller++;

                }



                string meervoud = (faculteit > 1 ? "s" : "");
                Console.Write($"{aantalLiedjes} liedje{meervoud} kan je in {faculteit} verschillende volgorde{meervoud} in een playlist plaatsen.");
            }



            Console.ReadKey();
        }
    }
}
