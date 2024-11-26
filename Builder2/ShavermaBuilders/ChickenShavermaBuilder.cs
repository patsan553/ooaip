using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.ShavermaBuilders;

namespace Builder.Builders
{
    public class ChickenShavermaBuilder : GodFoodBuilder
    {
        public override void SetType() { GodFood.Type = new Type { Shava = "с курицей:" }; }
        public override void SetMeat() { GodFood.Meat = new Meat { Animal = "Курица" }; }
        public override void SetPepper() { GodFood.Pepper = new Pepper { Spice = "Паприка" }; }
        public override void SetCabbage() { GodFood.Cabbage = new Cabbage(); }
        public override void SetMushroom() { GodFood.Mushroom = new Mushroom(); }
        public override void SetSauce() { GodFood.Sauce = new Sauce { Name = "Чесночный" }; }
    }
}
