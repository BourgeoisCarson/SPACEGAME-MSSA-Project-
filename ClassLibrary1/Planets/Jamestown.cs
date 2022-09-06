using System;
using System.Xml;

namespace SpaceClassLibrary
{

    public class Jamestown : Planet
    {
        public Jamestown(Player player) : base(player)
        {
            this.Name = "Jamestown";
            this.Size = 25000;
            this.Description = ("A lush forest planet home to many dangerous species of flora and fauna.\n" +
                "Many deep veins of explodium keep the mining towns operational and profitable.\n" +
                "The weather is currently 72 degrees, Atmosphere reading:\nO2 52%\n" +
                "Nitrogen 20%\n" +
                "Methane 28%\n" +
                "Perfect weather for fishing for Jamesian Snappers!");
            Items newJTItmes = new JamesTownInventory();
            this.Inventory = newJTItmes;

        }
    }


}
