using System;

namespace Oefening_09_TwintigTemTien
{
    class Program
    {
        static void Main(string[] args)
        {

            int getal = 20;

            do
            {
                if (getal % 2 == 0)
                {
                    Console.WriteLine(getal);
                }
                getal--;
            } while (getal >= 10);


            Console.ReadKey();
        }
    }
}
