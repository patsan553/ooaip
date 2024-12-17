using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Frog
{
    public class AgressiveFrog : IFrog
    {
        public string Croak()
        {
            return "agressive frog is croacking";
        }

        public string Attack()
        { 
            return "agressive frog is attacking";
        }
    }
}
