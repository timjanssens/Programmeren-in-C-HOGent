using System;

namespace Oefening_57_RechthoekDatatype
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechthoek rechthoek1 = new Rechthoek();        
            rechthoek1.SetHoogte(4);
            rechthoek1.SetBreedte(8);         
            Rechthoek rechthoek2 = new Rechthoek();        
            rechthoek2.SetHoogte(5);        
            rechthoek2.SetBreedte(10);    
            PrintRechthoek(rechthoek1);     
            PrintRechthoek(rechthoek2);

            Console.ReadKey();
        }
        static void PrintRechthoek(Rechthoek r)
        {    
            Console.WriteLine($"Rechthoek met hoogte {r.GetHoogte()}, breedte {r.GetBreedte()} en oppervlakte {r.Oppervlakte()}.");
        }
    }
}
