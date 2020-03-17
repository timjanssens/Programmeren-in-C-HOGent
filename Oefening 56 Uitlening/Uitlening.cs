using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_56_Uitlening
{
    class Uitlening
    {
        static private int _weken;
        static private DateTime _ontleningsDatum;
        public static void SetMaximumTeOntlenenWeken(int weken)
        {
            _weken = weken;
        }
        public static void SetOntleendatum(DateTime ontleningsdatum)
        {
            _ontleningsDatum = ontleningsdatum;
        }

        public static DateTime GetOntleendatum()
        {
            return _ontleningsDatum;
        }
        public static int GetMaximumTeOntlenenWeken()
        {
            return _weken;
        }

        public static DateTime GetUitersteInleverdatum()
        {
            DateTime terug = _ontleningsDatum.AddDays(7 * _weken);
            return terug;
        }




    }
}
