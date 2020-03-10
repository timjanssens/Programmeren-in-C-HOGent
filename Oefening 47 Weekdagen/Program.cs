using System;

namespace Oefening_47_Weekdagen
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = Weekdagen();         
           
            foreach (string dag in week) 
                Console.Write(dag + " ");


            Console.ReadKey();
        }

        static string[] Weekdagen()
        {
            return new string[] { "maandag", "dinsdag", "woensdag", "donderdag", "vrijdag", "zaterdag", "zondag" };
        }
    }
}
