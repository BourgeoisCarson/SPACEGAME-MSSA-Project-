using System;
using SpaceClassLibrary;
using System.Xml;
namespace SpaceClassLibrary
{
    //made by David Ramsay, Ryan Donato, Carson Bourgeois, and James Tipton
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate planets with their own names.
            Player player = new Player();
            Jamestown Jamestown = new Jamestown(player);
            Davesanity Davesanity = new Davesanity(player);
            Carsonopolis Carsonopolis = new Carsonopolis(player);
            Albynio Albynio = new Albynio(player);
            Lenoritarium Lenoritarium = new Lenoritarium(player);
            Console.WindowWidth = 200;
            //instantiate player and scooter, user selects names for each and is introduced.
            
            Scooter scooter = new Scooter();
            ConsoleArt.Start();
            player.StartScreen(); //print start screen
            player.SelectName(); 
            scooter.SelectName();
            Console.WriteLine($"Hello, {player.Name}! you are travelling through space on your trusty scooter, {scooter.Name}.");

            //player selects a planet
            int run = 0;
            while (run == 0)
            {
                
                int planetSelection = player.PlanetSelector();
                Console.Clear();
                switch (planetSelection)
                {
                    case 1:
                        ConsoleArt.AlbynioVista();
                        Albynio.Welcome();
                        if (player.SpaceosAmount > 10000)
                        {
                            Console.WriteLine("Congratulations, You have won the game!");
                            Environment.Exit(0);
                        }
                        break;
                    case 2:
                        ConsoleArt.CarsonopolisVista();
                        Carsonopolis.Welcome();
                        break;
                    case 3:
                        ConsoleArt.DavesanityVista();
                        Davesanity.Welcome();
                        break;
                    case 4:
                        ConsoleArt.JamestownVista();
                        Jamestown.Welcome();
                        break;
                    case 5:
                        ConsoleArt.LenoritariumVista();
                        Lenoritarium.Welcome();                 
                        break;
                }
                continue;
            }
        }        
    }
}
