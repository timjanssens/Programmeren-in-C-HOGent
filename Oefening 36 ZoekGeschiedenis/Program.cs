using System;

namespace Oefening_36_ZoekGeschiedenis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] zoekGeschiedenis = { "Britney", "lamp vervangen", "arrays", "rijst koken", "nexus" };
            do

            {
                // Afdrukkken lijst van recent geopende documenten:                

                foreach (string zoekterm in zoekGeschiedenis)
                    Console.Write(zoekterm + " ");
                Console.WriteLine();

                // Opvragen nieuw document:               

                Console.Write("Nieuwe zoekterm: ");
                string nieuweZoekterm = Console.ReadLine();
                Console.WriteLine();

                // Naar voor schuiven van laatste 4 elementen (eerste gaat verloren):                

                for (int i = 0; i < zoekGeschiedenis.Length-1; i++)
                {
                    zoekGeschiedenis[i] = zoekGeschiedenis[i + 1];
                }


                // Invoegen nieuwe zoekterm (in laatste element):     
                zoekGeschiedenis[4] = nieuweZoekterm;

            } while (true);
        }
    }
}
