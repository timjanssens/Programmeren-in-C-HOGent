using System;

namespace Oefening_55_ToegangsPrijs
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


            Console.WriteLine(Toegangsprijs(Categorie.Jongere) == PrijsFormule.Korting);      // zou true moeten geven           
            Console.WriteLine(Toegangsprijs(Categorie.ZestigPlus) == PrijsFormule.Korting);   // zou true moeten geven            
            Console.WriteLine(Toegangsprijs(Categorie.Normaal) == PrijsFormule.Standaard);    // zou true moeten geven

            Console.ReadKey();

        }

        static Categorie GetCategorie(int leeftijd)
        {
            if (leeftijd <= (int)Categorie.Jongere)
            {
                return Categorie.Jongere;
            }
            else if (leeftijd < (int)Categorie.Normaal)
            {
                return Categorie.Normaal;
            }
            else
            {
                return Categorie.ZestigPlus;
            }
        }
        static PrijsFormule Toegangsprijs(Categorie categorie)
        {
            if (Categorie.Normaal == categorie)
            {
                return PrijsFormule.Standaard;
            }
            
            else
            {
                return PrijsFormule.Korting;
            }
        }
    }
    enum Categorie
    {
        Jongere = 16, Normaal = 60, ZestigPlus
    }
    enum PrijsFormule
    {
        Korting, Standaard
    }
}
