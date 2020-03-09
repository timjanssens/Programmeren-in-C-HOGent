using System;

namespace Oefening_33_Aansprekingen
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] aansprekingen = { "Jan", "Piet", "Pol" };

            for (int i = 0; i < aansprekingen.Length; i++)
            {
                aansprekingen[i] = "Dag " + aansprekingen[i];
            }

            foreach (string aanspreking in aansprekingen) 
                Console.WriteLine(aanspreking);




            Console.ReadKey();
        }
    }
}
