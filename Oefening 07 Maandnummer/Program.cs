using System;

namespace Oefening_07_Maandnummer
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.Write("Maandnummer (1-12) ?:"); int maandNummer;
            if (int.TryParse(Console.ReadLine(), out maandNummer))
            {
                if (maandNummer < 1) Console.Write("Gelieve een geldig maandnummer in te voeren.");
                else
                {
                    if (maandNummer > 12) Console.Write("Gelieve een geldig maandnummer in te voeren.");
                    else if (maandNummer == 1 || maandNummer == 3 || maandNummer == 5 || maandNummer == 7 || maandNummer == 8 || maandNummer == 10 || maandNummer == 12)
                    {
                            Console.Write("In deze maand zijn er 31 dagen.");
                    }
                    else if (maandNummer == 4 || maandNummer == 6 || maandNummer == 9 || maandNummer == 11)
                    {
                            Console.Write("In deze maand zijn er 30 dagen.");
                    }
                    else
                    {
                            Console.Write("In deze maand zijn er 28 of 29 dagen.");
                    }
                     
                }
            }
            else Console.Write("Gelieve een geldig maandnummer in te voeren.");









            Console.ReadKey();
        }
    }
}
