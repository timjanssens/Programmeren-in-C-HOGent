using System;

namespace Oefening_04_Berekenen_BMI
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Lengte in cm?: "); 
            double lengteInCm = double.Parse(Console.ReadLine());

            Console.Write("Gewicht in kg?: "); 
            int gewichtInKg = int.Parse(Console.ReadLine());

            double bmi = gewichtInKg / Math.Pow(lengteInCm/100, 2);

            Console.WriteLine($"BMI: {bmi}");




            Console.ReadKey();
        }
    }
}
