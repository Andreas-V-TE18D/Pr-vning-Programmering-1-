using Microsoft.VisualBasic;
using System;

namespace Hänga_gubbe_prövning
{
    class Program
    {
        static int gissningar = 30;
        static string[] ord = new string[4] { "andreas", "david", "alexander", "mikael", };
        static void Main(string[] args)
        {
            Console.WriteLine("välkommen till hänga gubbe spelet som kanske räddar mitt betyg");
            Console.WriteLine("");
            Console.WriteLine("Du kommer att ha 30 gissningar");

            // tar ut ett slumpmässigt ord från array listan
            Random rand = new Random () ;
            int randomtal = rand.Next(3);
            string ordet = ord[randomtal];

            


            string gissning = Console.ReadLine();

            char[] bokstav = gissning.ToCharArray();


            while (gissningar > 0)
            {
                if (ordet.Contains(gissning))
                {
                    Console.WriteLine("RÄTT GISSAT");
                    Console.WriteLine(bokstav);

                }

                else
                {
                    Console.WriteLine("FEL GISSAT");

                }


            }
            if (gissningar < 0)
            {
                Console.WriteLine("Game Over");
            }


           

        }
      
    }
}
