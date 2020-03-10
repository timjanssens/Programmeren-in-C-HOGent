using System;

namespace Oefening_38_ArrayResize
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[] { 10, 20, 30, 40, 50 };

            foreach (int getal in getallen) Console.Write($"{getal} ");
            Console.WriteLine($" ({getallen.Length} getallen)");

            int nieuweGrootte;

            nieuweGrootte = 10;
            Array.Resize(ref getallen, nieuweGrootte);

            foreach (int getal in getallen)
                Console.Write($"{getal} ");

            Console.WriteLine($" ({getallen.Length} getallen)");
            nieuweGrootte = 20;
            //... zonder 'Array.Resize(ref getallen, nieuweGrootte);' call
            int[] copyGetallen = new int[nieuweGrootte];
            for (int i = 0; i < getallen.Length; i++)
            {
                copyGetallen[i] = getallen[i];
            }

            getallen = new int[nieuweGrootte];

            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = copyGetallen[i];
            }


            foreach (int getal in getallen)
                Console.Write($"{getal} ");

            Console.WriteLine($" ({getallen.Length} getallen)");

            nieuweGrootte = 3;
            //... zonder 'Array.Resize(ref getallen, nieuweGrootte);' call

            copyGetallen = new int[nieuweGrootte];
            for (int i = 0; i < copyGetallen.Length; i++)
            {
                copyGetallen[i] = getallen[i];
            }

            getallen = new int[nieuweGrootte];

            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = copyGetallen[i];
            }


            foreach (int getal in getallen)
                Console.Write($"{getal} ");

            Console.WriteLine($" ({getallen.Length} getallen)");

            Console.ReadKey();
        }
    }
}
