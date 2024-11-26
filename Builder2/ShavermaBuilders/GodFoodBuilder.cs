using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Core;

namespace Builder.ShavermaBuilders
{
    public abstract class GodFoodBuilder
    {
        public Shaverma GodFood { get; private set; }

        public void CreateBread()
        {
            GodFood = new Shaverma();
        }

        public abstract void SetType();
        public abstract void SetMeat();
        public abstract void SetPepper();
        public abstract void SetCabbage();
        public abstract void SetMushroom();
        public abstract void SetSauce();
    }
}
