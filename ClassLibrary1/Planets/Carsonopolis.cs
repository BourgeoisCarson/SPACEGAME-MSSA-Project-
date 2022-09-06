using System;
using System.Xml;

namespace SpaceClassLibrary
{
    public class Carsonopolis : Planet
    {
        public Carsonopolis(Player player) : base(player)
        {
            this.Name = "Carsonopolis";
            this.Size = 30000;
            this.Description = ("A massive planet dedicated to corporate production, almost all space scooters in the sector are produced here\n" +
                "Tools of all kinds from the common HyperScrewdriver to the commercial Spatial Relocator are exported from here\n" +
                "The weather is 10 degrees, Atmosphere reading:\n" +
                "O2 15%\n" +
                "CO2 80%\n" +
                "Nitrogen 5%\n" +
                "Perfect conditions for staying in the climate controlled factories and continuing work!");
            Items newCarsonInventory = new CarsonopilisInventory();
            this.Inventory = newCarsonInventory; 

        }
    }
}
