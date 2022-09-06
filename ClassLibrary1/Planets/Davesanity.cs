using System;
using System.Xml;

namespace SpaceClassLibrary
{

    public class Davesanity : Planet
    {
        public Davesanity(Player player) : base(player)
        {
            this.Name = "Davesanity";
            this.Size = 20000;
            this.Description = ("An ocean world teeming with aquatic life and natural wonders hidden under an amethyst sea\n" +
                "Also home to many of the materials required to make radiation meds making this world a hub of medical production\n" +
                "The weather is currently 60 degrees, Atmosphere reading:\n" +
                "O2 75%\n" +
                "CO2 15%\n" +
                "Nitrogen 10%\n" +
                "Excellent surf conditions to catch a wave or two!");
            Items newDaveInventory = new DavesanityInventory();
            this.Inventory = newDaveInventory;
                       
        }
    }


}
