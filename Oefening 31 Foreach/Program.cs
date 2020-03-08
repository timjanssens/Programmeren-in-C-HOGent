using System;

namespace Oefening_31_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] getallen = new decimal[] { -5.1m, 0m, 10.4m, -15m };
            foreach (var getal in getallen)
            {

                if (getal < 0)
                    Console.WriteLine($"{getal} is negatief.");
                else if (getal == 0m)
                    Console.WriteLine($"{getal} is nul.");
                else
                    Console.WriteLine($"{getal} is positief.");
            }

            Console.ReadKey();
        }
    }
}

