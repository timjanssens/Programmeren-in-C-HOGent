using System;

namespace Oefening_24_Rechthoek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoogte?: "); 
            int hoogte = int.Parse(Console.ReadLine());


            Console.Write("Breedte?: "); 
            int breedte = int.Parse(Console.ReadLine());


            for (int i = 0; i < hoogte; i++)
            {
                for (int j = 0; j < breedte; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }


            Console.ReadKey();
        }
    }
}
