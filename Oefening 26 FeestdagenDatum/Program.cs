using System;

namespace Oefening_26_FeestdagenDatum
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime[] feestdagen = new DateTime[12];

            feestdagen[0] = new DateTime(2017, 1, 1);    // Nieuwjaar            
            feestdagen[1] = new DateTime(2017, 4, 16);   // Pasen           
            feestdagen[2] = new DateTime(2017, 4, 17);   // Paasmaandag            
            feestdagen[3] = new DateTime(2017, 5, 1);    // Dag vd Arbeid           
            feestdagen[4] = new DateTime(2017, 5, 27);   // OLH Hemelvaart           
            feestdagen[5] = new DateTime(2017, 6, 4);    // Pinksteren
            feestdagen[6] = new DateTime(2017, 6, 5);    // Pinkstermaandag           
            feestdagen[7] = new DateTime(2017, 7, 21);   // Nationale Feestdag            
            feestdagen[8] = new DateTime(2017, 8, 15);   // OLV Hemelvaart            
            feestdagen[9] = new DateTime(2017, 11, 1);   // Allerheiligen           
            feestdagen[10] = new DateTime(2017, 11, 11); // Wapenstilstand           
            feestdagen[11] = new DateTime(2017, 12, 25); // Kerstdag
            
            Console.WriteLine(feestdagen.Length);


            Console.ReadKey();

        }
    }
}
