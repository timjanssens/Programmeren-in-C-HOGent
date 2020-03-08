using System;

namespace Oefening_23_SecondenLijst
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int seconden = 00; seconden < 60; seconden += 5)
            {
                Console.WriteLine($"23u59m{seconden.ToString("00")}s");
            }

            Console.ReadLine();
        }
    }
}
