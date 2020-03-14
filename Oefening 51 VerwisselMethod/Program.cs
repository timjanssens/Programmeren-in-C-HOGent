using System;

namespace Oefening_51_VerwisselMethod
{
    class Program
    {
        static void Main()

        {
            int hoogte = 10; int breedte = 20;
            Verwissel(ref hoogte,ref breedte);

            Console.WriteLine(" Hoogte: " + hoogte);  // 20       
            Console.WriteLine("Breedte: " + breedte); // 10
            
            Verwissel(ref hoogte,ref breedte);
            
            Console.WriteLine(" Hoogte: " + hoogte);  // 10           
            Console.WriteLine("Breedte: " + breedte); // 20      

            Console.ReadKey();
        }
        static void Verwissel(ref int hoogte, ref int breedte)
        {
            int hulp = hoogte;
            hoogte = breedte;
            breedte = hulp;
        }
    }
}
