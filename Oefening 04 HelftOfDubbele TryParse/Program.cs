using System;

namespace Oefening_04_HelftOfDubbele_TryParse
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Getal (int)?: ");
            
            bool geldigGetal = int.TryParse(Console.ReadLine(), out int getal);
            if (geldigGetal)
            {
                if (getal % 2 == 0)
                {
                    Console.WriteLine($"Helft: {getal/2}");
                }
                else
                {
                    Console.WriteLine($"Dubbele: {getal*2}");
                }
            }
            else
            {
                Console.WriteLine("Je mocht enkel een int invoeren");
            }



            Console.ReadKey();
        }
    }
}
