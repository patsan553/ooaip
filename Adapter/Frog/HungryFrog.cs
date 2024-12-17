using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Frog
{
    public class HungryFrog : IFrog
    {
        public string Croak()
        {
            return "hungry frog is croacking";
        }

        public string Eat()
        {
            return "hungry frog is eating";
        }
    }
}
