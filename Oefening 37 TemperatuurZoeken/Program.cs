using System;

namespace Oefening_37_TemperatuurZoeken
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temperaturen = { 5, 11, 12, 32, 37 };
            do
            {
                Console.Write("Temperatuur?: ");
                int zoekwaarde = int.Parse(Console.ReadLine());

                bool grotereTempGevonden = false;
                int index = -1;

                while (!grotereTempGevonden && index < temperaturen.Length - 1)
                {

                    index++;
                    grotereTempGevonden = (temperaturen[index] > zoekwaarde);

                }


                //...

                if (grotereTempGevonden)
                {
                    Console.WriteLine("Index eerste grotere temperatuur: " + index);
                    Console.WriteLine("Eerste grotere temperatuur: " + temperaturen[index]);
                }
                else
                    Console.WriteLine("Geen grotere temperatuur gevonden.");

                Console.WriteLine();

            } while (true);


            Console.ReadKey();
        }
    }
}
