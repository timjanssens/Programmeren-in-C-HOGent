using System;

namespace Oefening_01
{
    class Program
    {
        static void Main(string[] args)
        {


            int lengteInCm = 985;
            Console.WriteLine($"Lengte in cm: {lengteInCm}");
            //Uncomment onderstaande en vul de ... aan:            
            
            int aantalResterendeCm = lengteInCm;
            int teller = 0;

            while (aantalResterendeCm >= 100)
            {
                aantalResterendeCm -= 100;
                teller++;
            }


            int volledigAantalMeters = teller;

            Console.WriteLine($"Dit is {volledigAantalMeters}m en {aantalResterendeCm}cm.");     



            Console.ReadKey();
        }
    }
}
