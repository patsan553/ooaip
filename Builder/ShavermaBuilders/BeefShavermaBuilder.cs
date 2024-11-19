using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.ShavermaBuilders;

namespace Builder.Builders
{
    public class BeefShavermaBuilder : GodFoodBuilder
    {
        public override void SetType() { GodFood.Type = new Type { Shava = "с говядиной:" }; }
        public override void SetMeat() { GodFood.Meat = new Meat { Animal = "Говядина" }; }
        public override void SetPepper() { GodFood.Pepper = new Pepper { Spice = "Чили" }; }
        public override void SetCabbage() { GodFood.Cabbage = new Cabbage(); }
        public override void SetMushroom() { }
        public override void SetSauce() { GodFood.Sauce = new Sauce { Name = "Острый" }; }
    }
}
