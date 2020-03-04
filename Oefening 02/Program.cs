using System;

namespace Oefening_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double hoogteCilinderInMeter = 2.5;
            double diamterCilinderInMeter = 2.1;
            double opervlakteCilinderInMeter = Math.Pow(diamterCilinderInMeter, 2) * Math.PI / 4;
            double inhoudCilinder = opervlakteCilinderInMeter * hoogteCilinderInMeter * 1000;

            Console.WriteLine($"Inhoud in liter: {inhoudCilinder}");

            Console.ReadKey();
        }
    }
}
