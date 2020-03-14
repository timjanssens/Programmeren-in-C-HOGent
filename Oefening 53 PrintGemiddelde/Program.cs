using System;

namespace Oefening_53_PrintGemiddelde
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturen = { 10.4d, 13.4d, 24.8d };         
            PrintGemiddelde(temperaturen);
            PrintGemiddelde(10.5d, 30.5d);
            PrintGemiddelde(4.1d, 38.5d, 41.9d, 8.6d, 11.7d, 9.8d);
            PrintGemiddelde();        
            Console.ReadKey();
        }
         static void PrintGemiddelde(params double[]temperaturren)

        {
            double totaal = 0;
            for (int i = 0; i < temperaturren.Length; i++)
            {
                totaal += temperaturren[i];
            }

            Console.WriteLine($"Het gemiddelde is {totaal/temperaturren.Length}");

        }
        


    }
}
