using System;
using Dataspel;


namespace Dataspel
{

    class Program
    {
        static void Main(string[] args)
        {
            string gamesearched;

            Dataspel Fortnite = new Dataspel("Multiplayer", "Shooter", "Fortnite");
            Dataspel Ark = new Dataspel("Singleplayer", "Survival", "Ark");

            Console.WriteLine("Search for a game: ");
              gamesearched = Console.ReadLine();

            foreach (Dataspel spel in new Dataspel[] { Fortnite, Ark })
            {
                if (gamesearched == spel.Namn)
                {
                    Console.WriteLine("\nName: " + spel.Namn + "\nGenre: " + spel.Genre + "\nSpelarläge: " + spel.Spelarläge);
                }
                else if (gamesearched != spel.Namn)
                { 
                    Console.Write(""); }
            
            }

            
        }
    }



}