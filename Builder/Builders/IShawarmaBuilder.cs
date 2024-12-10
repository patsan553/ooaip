using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public interface IShawarmaBuilder
    {
        void WithCheese() { }
        void WithMeat() { }
        void WithTomato() { }
        void WithSauce() { }
        void WithSalad() { }
        void WithPepper() { }
    }
}
