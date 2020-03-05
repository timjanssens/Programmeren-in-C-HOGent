using System;

namespace Oefening_08_Schrikkeljaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jaartal: ");
            int jaartal = int.Parse(Console.ReadLine());

            if (jaartal % 4 == 0 && jaartal % 100 != 0 || jaartal % 400 == 0)
            {
                Console.WriteLine($"{jaartal} is een schrikkeljaar");
            }
            else
            {
                Console.WriteLine($"{jaartal} is geen schrikkeljaar");
            }



            Console.ReadKey();
        }
    }
}
