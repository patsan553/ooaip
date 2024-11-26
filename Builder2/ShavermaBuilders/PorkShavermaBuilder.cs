using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.ShavermaBuilders;

namespace Builder.Builders
{
    public class PorkShavermaBuilder : GodFoodBuilder
    {
        public override void SetType() { GodFood.Type = new Type { Shava = "со свининой:" }; }
        public override void SetMeat() { GodFood.Meat = new Meat { Animal = "Свинина" }; }
        public override void SetPepper() { GodFood.Pepper = new Pepper { Spice = "Черный" }; }
        public override void SetCabbage() { GodFood.Cabbage = new Cabbage(); }
        public override void SetMushroom() { }
        public override void SetSauce() { GodFood.Sauce = new Sauce { Name = "Йогуртовый" }; }
    }
}
