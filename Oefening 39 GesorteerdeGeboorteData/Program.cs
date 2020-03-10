using System;
using System.Collections.Generic;

namespace Oefening_39_GesorteerdeGeboorteData
{
    class Program
    {
        static void Main(string[] args)
        {

            List<DateTime> geboorteData = new List<DateTime>() { new DateTime(1879, 3, 14) }; 
            List<string> namen = new List<string>() { "Einstein" };
           
            do
            {
                Console.WriteLine("Lijst: ");
                for (int index = 0; index < geboorteData.Count; index++)
                    Console.WriteLine(geboorteData[index] + " " + namen[index]);
                Console.WriteLine();
              
                Console.Write("Operatie (toevoegen/verwijderen)?: ");
                string operatie = Console.ReadLine();
               
                if (operatie == "toevoegen")
                {

                    Console.Write("Naam?: ");
                    string naam = Console.ReadLine();
                    DateTime geboren;
                    do
                    {
                        Console.Write("Geboren?: ");
                    } while (!DateTime.TryParse(Console.ReadLine(), out geboren));
                    //... geboren waarde toevoegen aan geboorteData (Add)     
                    geboorteData.Add(geboren);
                    //... geboorteData laten sorteren (Sort)       
                    geboorteData.Sort();
                    //... opvragen positie geboren in de gesorteerde geboorteData (IndexOf)          
                    int hulp = geboorteData.IndexOf(geboren);
                    //... invoegen van naam op die positie in namen (Insert)              
                    namen.Insert(hulp, naam);
                }
                else if
                    (operatie == "verwijderen")
                {
                    Console.Write("Naam?: ");
                    string naam = Console.ReadLine();
                    //... opvragen positie naam in namen (IndexOf)      
                    int hulp = namen.IndexOf(naam);
                    //... verwijderen van element op die positie in namen (RemoveAt)           
                    namen.RemoveAt(hulp);
                    //... verwijderen van element op die positie in geboorteData (RemoveAt)   
                    geboorteData.RemoveAt(hulp);
                }
                Console.WriteLine();
            }
            while (true);
        }



    }
}

