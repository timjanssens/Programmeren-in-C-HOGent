using System;

namespace Oefening_42_FeestdagenVerschuiven
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] feestdagen = { new DateTime(2017, 01, 01), new DateTime(2017, 04, 16), 
                new DateTime(2017, 04, 17), new DateTime(2017, 05, 01),
                new DateTime(2017, 05, 27), new DateTime(2017, 06, 04), 
                new DateTime(2017, 06, 05), new DateTime(2017, 07, 21), 
                new DateTime(2017, 08, 15), new DateTime(2017, 11, 01), 
                new DateTime(2017, 11, 11), new DateTime(2017, 12, 25) };

            Print(feestdagen);            
            VerschuifEénJaar(feestdagen);            
            Print(feestdagen);




            Console.ReadKey();
        }

        static void VerschuifEénJaar(DateTime[] feestdagen)
        {
            for (int i = 0; i < feestdagen.Length; i++)
            {
                feestdagen[i] = feestdagen[i].AddYears(1);
            }
        }
        
        static void Print(DateTime[] feestdagen)
        {
            foreach (DateTime date in feestdagen)
            {
                Console.WriteLine(date);
            }
            Console.WriteLine();
        }

    }
}
