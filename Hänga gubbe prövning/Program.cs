using Microsoft.VisualBasic;
using System;

namespace Hänga_gubbe_prövning
{
    class Program
    {
        // en array med alla ord, static används för att array är utanför main metoden 
        static string[] ord = new string[4] { "andreas", "david", "alexander", "mikael", };

        static void Main(string[] args)
        {
            Console.WriteLine("välkommen till hänga gubbe spelet som kanske räddar mitt betyg");
            Console.WriteLine("");
            Console.WriteLine("Spelet går ut på att gissa vilka bokstäver finns i ett hemligt ord");

            // tar ut ett slumpmässigt ord från array listan
            Random random = new Random () ;
            int randomtal = random.Next(4);
            string ordet = ord[randomtal];


            // representationen för ordet 
            char[] stars = new char[ordet.Length];

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = '*';
            }

            // frågar användaren om hur många gissningar man vill ha 
            Console.WriteLine("Hur många gissningar vill du ha?");
            int antalGissningar = Convert.ToInt32(Console.ReadLine());
            



            // do while loopen körs så länge antalet gissningar är större än 0 
            do
            {

                // gissningen från användaren blir lagrad i variabeln string gissning
                Console.WriteLine("Gissa en bokstav");
                string gissning = Console.ReadLine();


                // om användaren har gissat rätt bokstav 
                if (ordet.Contains(gissning))
                {
                    char[] ordChars = ordet.ToCharArray();

                    for (int i = 0; i < ordChars.Length; i++)
                    {
                        if (gissning.ToCharArray()[0] == ordChars[i])
                        {
                            stars[i] = gissning.ToCharArray()[0];
                        }
                    }

                    Console.WriteLine(stars);
                    string starWord = new string(stars);



                    // om representationen inehåller blanka så fortsätter spelet 
                    if (starWord.Contains('*'))
                    {
                        continue;
                    }
                    // om inte så har spelaren gissa alla bokstäver och vunnit 
                    else
                    {
                        Console.WriteLine("Du vann");
                        break;
                    }

                }
                // om spelaren har gissat fel bokstav går antallet gissnigngar ner
                // och skriver ut hur många gissningar användaren har kvar. 
                else
                {
                    Console.WriteLine("Fell gissning");
                    antalGissningar--;
                    Console.WriteLine("Du har: " + antalGissningar + "kvar");

                }

            } while (antalGissningar > 0);

            


        }

        

        





    }
}
