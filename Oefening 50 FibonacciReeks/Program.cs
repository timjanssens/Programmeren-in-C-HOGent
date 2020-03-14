using System;

namespace Oefening_50_FibonacciReeks
{
    class Program
    {
        private static object ng21;

        static void Main()
        {
            int[] fibo = new int[100];
            VulMetFibonacciReeks(8, ref fibo);            
            Print(fibo);                          //1 1 2 3 5 8 13 21

                       
            VulMetFibonacciReeks(11, ref fibo);         
            Print(fibo);                          //1 1 2 3 5 8 13 21 34 55 89     

            Console.ReadKey();
        }

        static void VulMetFibonacciReeks(int aantalGetallen, ref int[] fibo)
        {
            Array.Resize(ref fibo, aantalGetallen);
            fibo[0] = 1;
            fibo[1] = 1;
            //overige elementen gelijkstellen aan som van de vorige twee ...
            for (int i = 2; i < aantalGetallen; i++)
            {  
                fibo[i] = fibo[i - 2] + fibo[i - 1];
            }
            for (int i = aantalGetallen; i < fibo.Length; i++)
            {
                //fibo[i] = ;
            }

           
        }
        static void Print(int[] getallen)
        {

            foreach (int getal in getallen)
            { Console.Write(getal + " "); }
            Console.WriteLine();
        }
    }
}
