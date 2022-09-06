using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceClassLibrary
{
    class JamesTownInventory : Items
    {
        public override string FuelName { get; set; } = "Fuel";
        public override int FuelQuantity { get; set; } = 30;
        public override int FuelBuyPrice { get; set; } = 15;
        public override int FuelSalePrice { get; set; } = 20;

        public override string ToolName { get; set; } = "Tools";
        public override int ToolQuantity { get; set; } = 40;
        public override int ToolBuyPrice { get; set; } = 50;
        public override int ToolSalePrice { get; set; } = 70;

        public override string FoodName { get; set; } = "Food";
        public override int FoodQuantity { get; set; } = 55;
        public override int FoodBuyPrice { get; set; } = 5;
        public override int FoodSalePrice { get; set; } = 10;

        public override string ExplodiumName { get; set; } = "Explodium";
        public override int ExplodiumQuantity { get; set; } = 20;
        public override int ExplodiumBuyPrice { get; set; } = 2000;
        public override int ExplodiumSalePrice { get; set; } = 230;
    }
}
