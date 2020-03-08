using System;

namespace Oefening_21_Som
{
    class Program
    {
        static void Main(string[] args)
        {

            int getal;

            while (!int.TryParse(Console.ReadLine(), out getal))
                Console.WriteLine("Gelieve een geheel getal in te voeren.");

            int som = getal;

            while (getal != 0)
            {
                Console.WriteLine("+");
            
                while (!int.TryParse(Console.ReadLine(), out getal))
                    Console.WriteLine("Gelieve een geheel getal in te voeren.");

                som += getal;
                
            }

            Console.Write($"=\n{som}");
            
            Console.ReadKey();
        }
    }
}
