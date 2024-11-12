using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    public class FireHeroCreator : HeroCreator
    {
        public override Mage CreateMage()
        {
            return new FireMage();
        }

        public override Warrior CreateWarrior()
        {
            return new FireWarrior();
        }

        public override Archer CreateArcher()
        {
            return new FireArcher();
        }
    }
}
