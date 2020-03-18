using System;

namespace Oefening_62_PersoonProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon p1 = new Persoon();
            p1.Voornaam = "Rita";
            p1.Familienaam = "Peeters";
            p1.Rijksregisternummer = "54041219067";
            Console.WriteLine(p1.Voornaam == "Rita");                           // zou true moeten geven            
            Console.WriteLine(p1.Familienaam == "Peeters");                     // zou true moeten geven           
            Console.WriteLine(p1.IngekorteNaam == "R. Peeters");                // zou true moeten geven          
            Console.WriteLine(p1.Rijksregisternummer == "54041219067");         // zou true moeten geven        
            Console.WriteLine(p1.GeboorteDatum() == new DateTime(1954, 4, 12)); // zou true moeten geven        
            Console.WriteLine(p1.IsMan() == false);                             // zou true moeten geven      
            Console.WriteLine(p1.IsVrouw() == true);                            // zou true moeten geven              
            int leeftijdP1 = Datum.AantalVolledigeJarenTotNuSinds(new DateTime(1954, 4, 12));
            Console.WriteLine(p1.Leeftijd() == leeftijdP1);                     // zou true moeten geven

            p1.Rijksregisternummer = "11030812112";
            Console.WriteLine(p1.Voornaam == "Rita");                           // zou true moeten geven        
            Console.WriteLine(p1.Familienaam == "Peeters");                     // zou true moeten geven          
            Console.WriteLine(p1.IngekorteNaam == "R. Peeters");                // zou true moeten geven          
            Console.WriteLine(p1.Rijksregisternummer == "11030812112");         // zou true moeten geven         
            Console.WriteLine(p1.GeboorteDatum() == new DateTime(2011, 3, 8));  // zou true moeten geven          
            Console.WriteLine(p1.IsMan() == true);                              // zou true moeten geven         
            Console.WriteLine(p1.IsVrouw() == false);                           // zou true moeten geven          
            leeftijdP1 = Datum.AantalVolledigeJarenTotNuSinds(new DateTime(2011, 3, 8));
            Console.WriteLine(p1.Leeftijd() == leeftijdP1);                     // zou true moeten geven
            p1.Rijksregisternummer = null;
            Console.WriteLine(p1.Rijksregisternummer == null);                  // zou true moeten geven        
            Console.WriteLine(p1.IsMan() == false);                             // zou true moeten geven      
            Console.WriteLine(p1.IsVrouw() == false);                           // zou true moeten geven      
                                                                                // Console.WriteLine(p1.Leeftijd() == 0);                              // zou true moeten geven

            Console.ReadKey();
        }
    }
    class Datum
    {
        public static int AantalVolledigeJarenTotNuSinds(DateTime d)
        {
            int jaren = 0;
            while (d.AddYears(1) <= DateTime.Now)
            {
                jaren += 1; d = d.AddYears(1);
            }
            return jaren;
        }
    }
}
