using System;

namespace Oefening_5_Quotient
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Deeltal?: "); 
            double deeltal = double.Parse(Console.ReadLine());

            Console.Write("Deler?: "); 
            double deler = double.Parse(Console.ReadLine());

            if (deler == 0)
            {
                Console.WriteLine("Deling door nul wordt niet toegelaten");
            }
            else
            {
                double quotient = deeltal / deler;
                Console.WriteLine($"Quotient: {quotient}");
            }

            Console.ReadKey();
        }
    }
}
