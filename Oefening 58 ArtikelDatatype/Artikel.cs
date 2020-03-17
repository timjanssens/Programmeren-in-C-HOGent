using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_58_ArtikelDatatype
{
    class Artikel
    {

        public double BtwTarief { get; set; } = 21;
        public double PrijsZonderBtw { get; set; }

        private double prijsMetBtw;

        public double PrijsMetBtw
        {
            get { return PrijsZonderBtw + (PrijsZonderBtw * (BtwTarief/100)); }
        }



    }
}
