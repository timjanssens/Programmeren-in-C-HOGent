using System;

namespace Oefening_29_TabelOpvullen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[9];
            // opvullen:            
            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = 101 + i;
            }
            
            
            // afdrukken:            

            for (int index = 0; index < getallen.Length; index++)
                Console.Write(getallen[index] + " ");


            Console.ReadKey();
        }
    }
}
