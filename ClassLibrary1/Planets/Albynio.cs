using System;
using System.Xml;

namespace SpaceClassLibrary
{
    public class Albynio : Planet
    {     

        public Albynio(Player player) : base(player)
        {
            this.Name = "Albynio";
            this.Size = 10000;
            this.Description = ("A relativley small planet where all matter lacks any kind of pigment.\n" +
                "While not understood completley the planet is the only source of Neoplasmin Cubes in the sector\n" +
                "The weather is -20 degrees, Atmosphere reading:\n" +
                "No atmosphere\n" +
                "Best to stay on your scooter and let the drones do the trading.");
            Items AlbynioInventory = new AlbynioInventory();
            this.Inventory = AlbynioInventory;
            
        }
    }
}
