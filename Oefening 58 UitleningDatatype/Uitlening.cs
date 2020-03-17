using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_58_UitleningDatatype
{
    class Uitlening
    {
        static private DateTime _ontleendatum;
        static private string _omschrijving;

        public void SetOmschrijving(string omschrijving)
        {
            _omschrijving = omschrijving;
        }
        public string GetOmschrijving()
        {
            return _omschrijving;
        }

        public  void SetOntleendatum(DateTime ontleendatum)
        {
            _ontleendatum = ontleendatum;
        }
        public  DateTime GetOntleendatum()
        {
            return _ontleendatum;
        }

        public DateTime GetUitersteInleverdatum()
        {
            return _ontleendatum.AddDays(21);
        }




    }
}

