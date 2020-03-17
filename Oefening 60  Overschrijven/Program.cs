using System;

namespace Oefening_60__Overschrijven
{
    class Program
    {
        static void Main(string[] args)
        {

            Bankrekening b1 = new Bankrekening(); 
            Bankrekening b2 = new Bankrekening();
            decimal bedrag = 100m;
            //Met één commando maak je het mogelijk 'bedrag' van 'b1' naar 'b2' over te schrijven:            
            //...SchrijfOver...

           b1.SchrijfOver(b2, 100);

            Console.WriteLine(b1.Saldo() == -100m); // zou true moeten geven         
            Console.WriteLine(b2.Saldo() == 100m);  // zou true moeten geven





            Console.ReadKey();
        }


    }
}
