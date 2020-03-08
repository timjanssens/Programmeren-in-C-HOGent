using System;

namespace Oefening_14_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Aantal maanden groei?: "); 
            int maanden;
            if (int.TryParse(Console.ReadLine(), out maanden) && maanden >= 1)
            {
                int fibo1 = 0; 
                int fibo2 = 1; 
                int fibo3 = fibo1 + fibo2;
                int teller = 2;
                

                while (teller < maanden)
                {
                    fibo1 = fibo2;
                    fibo2 = fibo3;
                    fibo3 = fibo1 + fibo2;
                    teller++;
                }
                                                                      
                Console.Write($"Aantal knooppunten: {fibo3}");
            }                
                Console.ReadKey();
        }
    }
}
