using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Duck
{
    public class FastDuck : IDuck
    {
        public string Quack()
        {
            return "fast duck is quacking";
        }

        public string Run()
        {
            return "fast duck is running";
        }
    }
}
