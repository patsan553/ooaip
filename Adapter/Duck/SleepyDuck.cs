using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Duck
{
    public class SleepyDuck : IDuck
    {
        public string Quack()
        {
            return "sleepy duck is quacking";
        }

        public string Sleep()
        {
            return "sleepy duck is sleeping";
        }
    }
}
