using System;

namespace Oefening_18_Vierkant
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Zijde: ");
            int zijde = int.Parse(Console.ReadLine());
            int hoogte = 0;
            do
            {
                int breedte = 0;
                while (breedte <= zijde)
                {
                    Console.Write("*");
                    breedte++;
                }

                Console.WriteLine();
                hoogte++;

            } while (hoogte <=  zijde);



            Console.ReadKey();
        }
    }
}
