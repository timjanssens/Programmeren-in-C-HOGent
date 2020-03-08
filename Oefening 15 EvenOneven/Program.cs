using System;

namespace Oefening_15_EvenOneven
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 1;
            //output wordt voor even gezet, niets bij even, on bij oneven.
            string output = "";

            while (getal <= 10)
            {
                output = (getal % 2 == 0) ? "" : "on";
                Console.WriteLine($"{getal} is een {output}even getal.");
                getal++;

            }


            Console.ReadKey();
        }
    }
}
