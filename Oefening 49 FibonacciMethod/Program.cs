using System;

namespace Oefening_49_FibonacciMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            TestFibonacci();

            Console.ReadKey();
        }

        static void TestFibonacci()
        {
            int[] target = Fibonacci(1);
            Console.WriteLine(target.Length == 1);  // zou true moeten geven            
            Console.WriteLine(target[0] == 1);      // zou true moeten geven            
            target = Fibonacci(2);
            Console.WriteLine(target.Length == 2);  // zou true moeten geven            
            Console.WriteLine(target[0] == 1);      // zou true moeten geven            
            Console.WriteLine(target[1] == 1);      // zou true moeten geven            
            target = Fibonacci(3);
            Console.WriteLine(target.Length == 3);  // zou true moeten geven           
            Console.WriteLine(target[0] == 1);      // zou true moeten geven            
            Console.WriteLine(target[1] == 1);      // zou true moeten geven            
            Console.WriteLine(target[2] == 2);      // zou true moeten geven          
            target = Fibonacci(4);
            Console.WriteLine(target.Length == 4);  // zou true moeten geven           
            Console.WriteLine(target[3] == 3);      // zou true moeten geven            
            target = Fibonacci(5);
            Console.WriteLine(target.Length == 5);  // zou true moeten geven            
            Console.WriteLine(target[4] == 5);      // zou true moeten geven        
        }

        static int[] Fibonacci(int getal)
        {
            int[] fibonacci = new int[getal];
            if (getal == 1)
            {
                fibonacci[0] = 1;
            }
            else if (getal == 2)
            {
                fibonacci[0] = 1;
                fibonacci[1] = 1;
            }
            //overige elementen gelijkstellen aan som van de vorige twee ...
            else  
            {

                fibonacci[0] = 1;
                fibonacci[1] = 1;

                for (int i = 2; i < fibonacci.Length; i++)
                {
                    fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
                }
            }


            return fibonacci;
        }

    }
}
