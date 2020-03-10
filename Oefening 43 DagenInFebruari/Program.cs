using System;

namespace Oefening_43_DagenInFebruari
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Jaar?: ");
                int jaar = int.Parse(Console.ReadLine());
                int dagen;
                if (IsSchrikkeljaar(jaar))
                {
                    dagen = 29;
                }
                else
                {
                    dagen = 28;
                }


                    Console.WriteLine($"In februari van {jaar} zijn er {dagen} dagen.");
                Console.WriteLine();
            }
            while (true);
        }
        //...        
        static bool IsSchrikkeljaar(int jaartal)
        {
            return (jaartal % 400 == 0 || jaartal % 4 == 0 && jaartal % 100 != 0);
        }
    }

}
