using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FabricMethod
{
    public class IceHeroCreator : HeroCreator
    {
        public override Mage CreateMage()
        {
            return new IceMage();
        }

        public override Warrior CreateWarrior()
        {
            return new IceWarrior();
        }

        public override Archer CreateArcher()
        {
            return new IceArcher();
        }
    }
}
