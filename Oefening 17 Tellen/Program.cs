using System;

namespace Oefening_17_Tellen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoogte?: ");
            int hoogte = int.Parse(Console.ReadLine());
            int hoogteTeller = 0;

            Console.Write("Breedte?: ");
            int breedte = int.Parse(Console.ReadLine());


            do
            {

                int breedteTeller = 0;

                do
                {
                    Console.Write("*");
                    breedteTeller++;
                } while (breedteTeller < breedte);

                Console.WriteLine();
                hoogteTeller++;

            } while (hoogteTeller < hoogte);

                       
            Console.ReadKey();
        }
    }
}
