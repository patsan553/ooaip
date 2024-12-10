using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class IceMage : IMage
    {
        public string CastSpell()
        {
            return "Ice Mage casts an ice shard!";
        }
    }
}
