using System;

namespace Oefening_56_Uitlening
{
    class Program
    {
        static void Main(string[] args)
        {
            Uitlening.SetOntleendatum(new DateTime(2018, 12, 30));            
            Uitlening.SetMaximumTeOntlenenWeken(3);


            Console.WriteLine($"Ontleendatum: {Uitlening.GetOntleendatum():dd/MM/yyyy}");            
          Console.WriteLine($"Max. te ontlenen weken: {Uitlening.GetMaximumTeOntlenenWeken()}");            
          Console.WriteLine($"Ten laatste inleveren op: {Uitlening.GetUitersteInleverdatum():dd/MM/yyyy}");


            Console.ReadKey();

        }
    }
}
