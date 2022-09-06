using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceClassLibrary
{
    public class Items //: Planet
    {
        public virtual string FuelName { get; set; }
        public virtual int FuelQuantity { get; set; }
        public virtual int FuelBuyPrice { get; set; }
        public virtual int FuelSalePrice { get; set; }

        public virtual string ToolName { get; set; }
        public virtual int ToolQuantity { get; set; }
        public virtual int ToolBuyPrice { get; set; }
        public virtual int ToolSalePrice { get; set; }

        public virtual string FoodName { get; set; }
        public virtual int FoodQuantity { get; set; }
        public virtual int FoodBuyPrice { get; set; }
        public virtual int FoodSalePrice { get; set; }

        public virtual string ExplodiumName { get; set; }
        public virtual int ExplodiumQuantity { get; set; }
        public virtual int ExplodiumBuyPrice { get; set; }
        public virtual int ExplodiumSalePrice { get; set; }
    }




}
