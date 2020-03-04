using System;

namespace Oefening_03_Optellen_muntstukken
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Aantal muntstukken van 2 Euro?: ");
            int muntenTweeEuro = int.Parse(Console.ReadLine());

            Console.Write("Aantal munten van 1 euro?: ");
            int muntenEenEuro = int.Parse(Console.ReadLine());

            int totaalBedrag = muntenEenEuro * 1 + muntenTweeEuro * 2;

            Console.WriteLine($"Het totale bedrag is {totaalBedrag}");
            
            
            
            
            
            Console.ReadKey();
        }
    }
}
