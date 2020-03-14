using System;

namespace Oefening_54_Leeftijdscategorie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetCategorie(15) == Categorie.Jongere);      // zou true moeten geven            
            Console.WriteLine(GetCategorie(16) == Categorie.Jongere);      // zou true moeten geven            
            Console.WriteLine(GetCategorie(17) == Categorie.Normaal);      // zou true moeten geven            
            Console.WriteLine(GetCategorie(59) == Categorie.Normaal);      // zou true moeten geven            
            Console.WriteLine(GetCategorie(60) == Categorie.ZestigPlus);   // zou true moeten geven
            Console.WriteLine(GetCategorie(61) == Categorie.ZestigPlus);   // zou true moeten geven
            
            Console.WriteLine(Toegangsprijs(Categorie.Jongere) == 10m);    // zou true moeten geven            
            Console.WriteLine(Toegangsprijs(Categorie.ZestigPlus) == 12m); // zou true moeten geven           
            Console.WriteLine(Toegangsprijs(Categorie.Normaal) == 19m);    // zou true moeten geven

            Console.ReadKey();

        }

        static Categorie GetCategorie(int leeftijd)
        {
            if (leeftijd <= (int) Categorie.Jongere)
            {
                return Categorie.Jongere;
            }
            else if (leeftijd < (int) Categorie.Normaal)
            {
                return Categorie.Normaal;
            }
            else
            {
                return Categorie.ZestigPlus;
            }
        }
        static decimal Toegangsprijs(Categorie categorie)
        {
            if (Categorie.Jongere == categorie)
            {
                return 10m;
            }
            else if (Categorie.Normaal == categorie)
            {
                return 19m;
            }
            else
            {
                return 12m;
            }
        }
    }
    enum Categorie
    {
        Jongere = 16, Normaal = 60, ZestigPlus
    }
}
