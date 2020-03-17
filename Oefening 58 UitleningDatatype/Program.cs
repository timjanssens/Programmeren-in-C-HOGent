using System;

namespace Oefening_58_UitleningDatatype
{
    class Program
    {
        static void Main(string[] args)
        {

            do           
            {            
                PrintUitleningen();


                Console.Write("Nieuwe ontlening op: ");
                DateTime d = DateTime.Parse(Console.ReadLine());
                Console.Write("Omschrijving: ");
                string o = Console.ReadLine();

                Toevoegen(o, d);

                Console.WriteLine();
            }
            while (true);

            Console.ReadKey();

        }







        static Uitlening[] _uitleningen = new Uitlening[2];
        static int _aantal = 0;

        static void PrintUitleningen()        
        {        
            for (int index = 0; index < _aantal; index++)           
            {          
                Uitlening u = _uitleningen[index];        
                Console.WriteLine($"- {u.GetOmschrijving()}: ontleent op {u.GetOntleendatum():dd/MM/yyyy} binnen ten laatste op {u.GetUitersteInleverdatum():dd/MM/yyyy}.");            
            }         
            Console.WriteLine();        
        }
        static void Toevoegen(string omschrijving, DateTime ontleendatum)
        {
            Uitlening nieuweUitlening = new Uitlening();
            nieuweUitlening.SetOmschrijving(omschrijving);
            nieuweUitlening.SetOntleendatum(ontleendatum);

            _aantal++;        
            if (_aantal > _uitleningen.Length) Array.Resize(ref _uitleningen, _uitleningen.Length * 2);
            _uitleningen[_aantal - 1] = nieuweUitlening;
        }

    }

}
