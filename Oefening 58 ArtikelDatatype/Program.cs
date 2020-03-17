using System;

namespace Oefening_58_ArtikelDatatype
{
    class Program
    {
        static void Main(string[] args)
        {


            Artikel artikel = new Artikel();
            artikel.PrijsZonderBtw = 100;
            Console.WriteLine(artikel.PrijsMetBtw);
            Console.WriteLine(artikel.BtwTarief);



            Console.ReadKey();
        }
    }
}
