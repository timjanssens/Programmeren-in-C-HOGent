using System;
using System.Collections.Generic;

namespace Oefening_48_PrintLijst
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lijst1 = Lijst(6, 11);
            Print(lijst1);       //           6 7 8 9 10 11            
            Print(Lijst(7, 3));  // 3 4 5 6 7        


            Console.ReadKey();
        }      
        static void Print(List<int> lijst)
        {
            foreach (int element in lijst)
                Console.Write(element + " ");
            Console.WriteLine();
        }

        static List<int> Lijst(int eerste, int tweede)
        {
            int grootste;
            int kleinste;
            if(eerste >= tweede)
            {
                grootste = eerste;
                kleinste = tweede;
            }
            else
            {
                grootste = tweede;
                kleinste = eerste;
            }

            List<int> lijst = new List<int>();

            for (int i = kleinste ; i <= grootste;  i++)
            {
                lijst.Add(i);
            }


            return lijst;
        }

    }
}
