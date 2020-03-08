using System;

namespace Oefening_30_ArrayInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dagen = new string[] {"ma", "di", "wo", "do", "vr", "za", "zo"};           
            
            Console.Write($"({dagen.Length} elementen): "); 

            for (int index = 0; index < dagen.Length; index++) 
                Console.Write(dagen[index] + " ");




            Console.ReadKey();
        }
    }
}
