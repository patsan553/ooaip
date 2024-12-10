using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Fire
{
    public class FireMage : IMage
    {
        public string CastSpell()
        {
            return "Fire Mage casts a fireball!";
        }
    }
}
