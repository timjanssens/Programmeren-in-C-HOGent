using System;

namespace Oefening_41_PrintQuotient
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintQuotient(10, 2.5);
            PrintQuotient(9.9, 3);

            Console.ReadKey();
        }

        static void PrintQuotient(double deeltal, double deler)
        {
            Console.WriteLine($"{deeltal} / {deler} = {(deeltal/deler).ToString("0.##")}");
        }

    }
}
