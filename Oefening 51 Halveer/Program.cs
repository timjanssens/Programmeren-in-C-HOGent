using System;

namespace Oefening_51_Halveer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dagen = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Print(dagen); // 31 28 31 30 31 30 31 31 30 31 30 31



            Halveer(ref dagen);
            Print(dagen); // 31 28 31 30 31 30

            Halveer(ref dagen);
            Print(dagen); // 31 28 31

            Halveer(ref dagen);
            Print(dagen); // 31        

            Console.ReadKey();
        }
        static void Halveer(ref int [] dagen )
        {
            Array.Resize(ref dagen, dagen.Length / 2);

        }
        static void Print(int[] getallen)
        {
            Console.Write($"({getallen.Length} elementen) ");
            foreach (int getal in getallen)
            {
                Console.Write(getal + " ");
            }
            Console.WriteLine();
        }
    }

}
