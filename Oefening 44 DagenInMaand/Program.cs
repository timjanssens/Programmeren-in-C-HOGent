using System;

namespace Oefening_44_DagenInMaand
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Maand?: ");
                string maand = Console.ReadLine();
                Console.Write("Jaar?: ");
                int jaar = int.Parse(Console.ReadLine());
                string[] maanden = { "januari", "februari", "maart", "april", "mei", "juni", "juli", "augustus", "september", "oktober", "november", "december" };
                int dagen = GetAantalDagen(maand, jaar, maanden);

                Console.WriteLine($"In {maand} van {jaar} zijn er {dagen} dagen.");         
                
                Console.WriteLine();
            }
            while (true);


            Console.ReadKey();
        }

        static bool IsSchrikkeljaar(int jaartal)
        {
            return (jaartal % 400 == 0 || jaartal % 4 == 0 && jaartal % 100 != 0);
        }

        static int GetAantalDagen(string maand, int jaartal, string[] maanden)
        {
            if (maanden[0] == maand || maanden[2] == maand || maanden[4] == maand || maanden[6] == maand || maanden[7] == maand || maanden[9] == maand || maanden[11] == maand)
            {
                return 31;
            }
            else if (maanden[3] == maand || maanden[5] == maand || maanden[8] == maand || maanden[10] == maand)
            {
                return 30;
            }
            else
            {
                if (IsSchrikkeljaar(jaartal))
                    return 29;
                else
                    return 28;
            }

        }


    }
}
