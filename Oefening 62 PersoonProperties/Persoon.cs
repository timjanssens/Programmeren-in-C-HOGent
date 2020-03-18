using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_62_PersoonProperties
{
    class Persoon
    {

        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public string Rijksregisternummer { get; set; }
        private string ingekorteNaam;

        public string IngekorteNaam
        {
            get
            {
                return $"{Voornaam.Substring(0, 1)}. {Familienaam}";
            }
        }

        public DateTime GeboorteDatum()
        {
            int jaar = int.Parse(Rijksregisternummer.Substring(0, 2));
            if (jaar < 20)
            {
                jaar += 2000;
            }
            else
            {
                jaar += 1900;
            }
            int maand = int.Parse(Rijksregisternummer.Substring(2, 2));
            int dag = int.Parse(Rijksregisternummer.Substring(4, 2));

            return new DateTime(jaar, maand, dag);
        }

        public bool IsMan()
        {
            int geslacht = int.Parse(Rijksregisternummer.Substring(8, 1));
            if (geslacht % 2 == 0)
            {
                return false;
            }
            return true;
        }
        public bool IsVrouw()
        {
            int geslacht = int.Parse(Rijksregisternummer.Substring(8, 1));
            if (geslacht % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public int Leeftijd()
        {
            int jaren = 0;
            DateTime GB = this.GeboorteDatum();
            while (GB.AddYears(1) <= DateTime.Now)
            {
                jaren += 1; GB = GB.AddYears(1);
            }
            return jaren;

        }


    }
}
