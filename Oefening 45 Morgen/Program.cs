using System;

namespace Oefening_45_Morgen
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime morgen = Morgen();
            Console.WriteLine(morgen);
                                          
            Console.ReadKey();
        }

        static DateTime Morgen()
        {
            DateTime morgen = DateTime.Now.AddDays(1);

            return morgen;
        }
    }
}
