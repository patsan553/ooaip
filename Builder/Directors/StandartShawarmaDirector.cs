using Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    public class StandartShawarmaDirector
    {
        private IShawarmaBuilder _shawarma;
        public StandartShawarmaDirector(IShawarmaBuilder shawarma)
        {
            _shawarma = shawarma;
        }
        public void Build()
        {
            _shawarma.WithCheese();
            _shawarma.WithSauce();
            _shawarma.WithSalad();
            _shawarma.WithMeat();
            _shawarma.WithTomato();
        }
    }
}
