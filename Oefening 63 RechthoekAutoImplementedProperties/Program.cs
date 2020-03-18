using System;

namespace Oefening_63_RechthoekAutoImplementedProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechthoek rechthoek1 = new Rechthoek() { Hoogte = 4.1, Breedte = 8.0 } ;
            //rechthoek1.Hoogte = 4.1; 
            //rechthoek1.Breedte = 8.0;

            Rechthoek rechthoek2 = new Rechthoek() { Hoogte = 5.0, Breedte = 10.2 };
            //rechthoek2.Hoogte = 5.0;
            //rechthoek2.Breedte = 10.2;

            PrintRechthoek(rechthoek1);
            PrintRechthoek(rechthoek2);

            Console.ReadKey();

        }
        static void PrintRechthoek(Rechthoek r)
        {
            Console.WriteLine($"Rechthoek met hoogte {r.Hoogte}, breedte {r.Breedte} en oppervlakte {r.Oppervlakte}.");
        }
    }
    class Rechthoek
    {
        private double _hoogte;
        public double Hoogte
        {
            get
            {
                return _hoogte;
            }
            set
            {
                _hoogte = value;
            }
        }
        private double _breedte;
        public double Breedte
        {
            get
            {
                return _breedte;
            }
            set
            {
                _breedte = value;
            }
        }
        public double Oppervlakte
        {
            get
            {
                return Hoogte * Breedte;
            }
        }
    }
}
