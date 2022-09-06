using System;
using System.Xml;

namespace SpaceClassLibrary
{


    public class Player 
    {

        public string Name { get; set; } = "Traveler";

        //inventory fields
        public string FoodName = "Food";
        public int FoodAmount = 0;

        public string FuelName = "Fuel";
        public int FuelAmount = 30;

        public string ToolName = "Tools";
        public int ToolAmount = 0;

        public string ExplodiumName = "Explodium";
        public int ExplodiumAmount = 0;

        public string SpaceosName = "Spaceos";
        public int SpaceosAmount = 100;

        
        public void StartScreen()
        {
            Console.WriteLine("Welcome to Space!\nPress any key to begin playing...");
            Console.ReadKey();
        }
        public void SelectName()
        {
            Console.WriteLine("Enter Your Name:");
            string inputname = Console.ReadLine();
            this.Name = inputname;
        }
        public int PlanetSelector()
        {
            string temp;
            int tempInt;
            int input = 0;
            Console.Clear();
            ConsoleArt.SpaceVista();
            Console.WriteLine("Which planet would you like to travel to?\nPress a number and then hit enter:\n1) Albynio\n2) Carsonopolis\n3) Davesanity\n4) Jamestown\n5) Lenoritarium");
            temp = Console.ReadLine();
            //if the input by the use parses to an integer and is between 1 and 5, return the input.
            if (int.TryParse(temp, out tempInt) && (tempInt >= 1 && tempInt <= 5))
            {
                input = tempInt;
                return input;
            }
            else
            {
                //if the input by the user doesnt parse to an integer or is not between 1 and 5, do not return the input. Loop until user enters an acceptable value.
                Console.WriteLine("Please enter a nubmer listed above and press enter.");
                while (!int.TryParse(Console.ReadLine(), out tempInt) || (tempInt < 1 || tempInt > 5))
                {
                    Console.WriteLine("Please enter a nubmer listed above and press enter.");
                }
                input = tempInt;
                return input;
            }
        }    
    }
        
    

    
    
}
