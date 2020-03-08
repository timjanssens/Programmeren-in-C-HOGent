using System;

namespace Oefening_32_BrutoNaarNetto
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] kortingen = { 10m, 50m, 19.4m }; 
            decimal brutoBedrag = 1000m;
            decimal nettoBedrag = brutoBedrag;

            foreach (var bedrag in kortingen)
            {
                nettoBedrag -= bedrag;
            }
           
            Console.Write("Netto bedrag: " + nettoBedrag);


            Console.ReadKey();
        }
    }
}
