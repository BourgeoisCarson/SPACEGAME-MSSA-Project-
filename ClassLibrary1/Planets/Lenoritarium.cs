using System;
using System.Xml;

namespace SpaceClassLibrary
{
    public class Lenoritarium : Planet
    {
        public Lenoritarium(Player player) : base(player)
        {
            this.Name = "Lenoritarium";
            this.Size = 18000;
            this.Description = ("A world wholey dedicated to research and knowlege\n" +
                "Its proximity to Albynio and Carsonopolis ensure a steady supply of research tools and Neoplasmin Cubes allowing the production of hyper drives\n" +
                "The weather is 78 degrees, Atmosphere reading:\n" +
                "O2 70%\n" +
                "CO2 10%\n" +
                "Nitrogen 20%\n" +
                "Stay a while and you might learn a thing or two!");
            Items newLenoreItems = new LenorInventory();
            this.Inventory = newLenoreItems;

        }
    }
}
