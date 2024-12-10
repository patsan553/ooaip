using Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    public class StudentShawarmaDirector
    {
        private IShawarmaBuilder _shawarma;
        public StudentShawarmaDirector(IShawarmaBuilder shawarma)
        {
            _shawarma = shawarma;
        }
        public void Build()
        {
            _shawarma.WithSauce();
            _shawarma.WithSalad();
            _shawarma.WithTomato();
        }
    }
}
