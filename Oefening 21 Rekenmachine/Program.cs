using System;

namespace Oefening_21_Rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {

            string bewerking = "+";
            int uitkomst = 0;
            int getal;
            string invoer = "";

            while (invoer != "=")
            {
                invoer = Console.ReadLine();
                if (int.TryParse(invoer, out getal))
                {

                    if (bewerking == "-")
                    {
                        uitkomst -= getal;
                    }

                    if (bewerking == "+")
                    {
                        uitkomst += getal;
                    }
                }

                else if (invoer == "+")
                {
                    bewerking = "+";
                }
                else if (invoer == "-")
                {
                    bewerking = "-";
                }


            }

            Console.WriteLine($"{uitkomst}");


            Console.ReadKey();
        }
    }
}
