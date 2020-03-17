using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_57_RechthoekDatatype
{
    class Rechthoek
    {
        public int Hoogte { get; set; }
        public int Breedte { get; set; }

        public void SetHoogte(int hoogte)
        {
            Hoogte = hoogte;
        }
        public void SetBreedte(int breedte)
        {
            Breedte = breedte;
        }

        public int GetHoogte()
        {
            return Hoogte;
        }

        public int GetBreedte()
        {
            return Breedte;
        }

        public int Oppervlakte()
        {
            return this.Breedte * this.Hoogte;
        }


    }
}
