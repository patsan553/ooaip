using Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    public class DragonShawarmaDirector
    {
        private IShawarmaBuilder _shawarma;
        public DragonShawarmaDirector(IShawarmaBuilder shawarma)
        {
            _shawarma = shawarma;
        }
        public void Build()
        {
            _shawarma.WithPepper();
            _shawarma.WithSauce();
            _shawarma.WithSalad();
            _shawarma.WithCheese();
            _shawarma.WithTomato();
        }
    }
}
