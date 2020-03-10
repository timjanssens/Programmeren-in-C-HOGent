using System;

namespace Oefening_45_FahrenheitMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFahrenheit();
        }

        static void TestFahrenheit()
        {
            Console.WriteLine(Fahrenheit(12.399) == 54.32);     // veronderstelling zou true moeten opleveren            
            Console.WriteLine(Fahrenheit(12.399, 3) == 54.318); // veronderstelling zou true moeten opleveren            
            Console.WriteLine(Fahrenheit(12.399, 0) == 54);     // veronderstelling zou true moeten opleveren        

            Console.ReadKey();
        }
        static double Fahrenheit(double gradenCelcius, int cijfersNaKomma = 2)
        {

            double gradenFarenheit = gradenCelcius * 1.8 + 32;



            return Math.Round(gradenFarenheit, cijfersNaKomma);

        }

    }
}
