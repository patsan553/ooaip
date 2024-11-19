using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.ShavermaBuilders;

namespace Builder.Core
{
    public class Rustam
    {
        public Shaverma Cook(GodFoodBuilder builder)
        {
            builder.CreateBread();
            builder.SetType();
            builder.SetMeat();
            builder.SetPepper();
            builder.SetCabbage();
            builder.SetMushroom();
            builder.SetSauce();
            return builder.GodFood;
        }
    }
}
