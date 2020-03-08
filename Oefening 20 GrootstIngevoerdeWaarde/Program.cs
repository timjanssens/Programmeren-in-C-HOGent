using System;

namespace Oefening_20_GrootstIngevoerdeWaarde
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            int grootste;


            if (!int.TryParse(Console.ReadLine(), out getal))
            {
                Console.WriteLine("Er zijn geen getallen ingevoerd");
            }

            else
            {

                grootste = getal;


                while (int.TryParse(Console.ReadLine(), out getal))
                {

                    if (getal > grootste)
                    {
                        grootste = getal;
                    }

                }

                Console.WriteLine($"De grootst ingevoerde waarde is {grootste}"); ;

            }




            Console.ReadKey();
        }
    }
}
