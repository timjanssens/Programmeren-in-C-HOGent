using System;

namespace Oefening_35_NamenTabel
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] voornamen = { "Jan", "Piet", "Pol" };
            string[] familienamen = { "Jansens", "Pieters", "Polders" };

            //Tabel namen instantiëren:            
            string[] namen = new string[3];


            //Tabel namen opvullen:  
            for (int i = 0; i < namen.Length; i++)
            {
                namen[i] = voornamen[i] + " " + familienamen[i];
            }


            //Tabel afdrukken:

            foreach (string naam in namen)
                Console.WriteLine(naam);

            Console.ReadKey();
        }
    }
}
