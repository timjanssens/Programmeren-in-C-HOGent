using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_61__RechthoekProperties
{
    class Rechthoek
    {
        public double Breedte { get; set; }
        public double Hoogte { get; set; }
        private double oppervlakte;

        public double Oppervlakte
        {
            get { return Breedte * Hoogte; }
        }



    }
}
