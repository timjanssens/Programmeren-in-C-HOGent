using System;

namespace Oefening_10_TafelsVan7
{
    class Program
    {
        static void Main(string[] args)
        {

            int getal = 7;
            int factor = 1;

            do
            {

                Console.WriteLine($"{factor} x {getal} = {factor * getal}");
                factor++;

            } while (factor <=10);



            Console.ReadKey();
        }
    }
}
