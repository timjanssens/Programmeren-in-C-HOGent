using System;

namespace Oefening_19_Driehoek
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Rechthoekszijde: ");
            int zijde = int.Parse(Console.ReadLine());
            int hoogte = zijde;
            int loopteller = 0;

            while (hoogte > 0)
            {

                int breedteTeller = zijde - loopteller;

                while (breedteTeller > 0)
                {
                    Console.Write("*");
                    breedteTeller--;
                }

                Console.WriteLine();
                hoogte--;
                loopteller++;
            }



            Console.ReadKey();
        }
    }
}
