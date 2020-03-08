using System;

namespace Oefening_16_ReeksVanKleinNaarGroot
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int getal1; 
                Console.Write("Getal 1?: ");
                while (!int.TryParse(Console.ReadLine(), out getal1))
                    Console.Write("Gelieve een geheel getal in te voeren, getal 1?: ");

                int getal2; 
                Console.Write("Getal 2?: ");
                while (!int.TryParse(Console.ReadLine(), out getal2))
                    Console.Write("Gelieve een geheel getal in te voeren, getal 2?: ");

                if (getal2 < getal1)
                {
                    int hulp = getal1;
                    getal1 = getal2;
                    getal2 = hulp;

                }

                Console.Write("Reeks van klein naar groot: ");

                while (getal1 <= getal2)
                {
                    Console.Write(getal1 + " ");
                    getal1++;
                }



                Console.ReadKey();
            }
        }
    }
}
