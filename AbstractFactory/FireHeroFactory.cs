using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FireHeroFactory : IHeroFactory
    {
        public IMage CreateMage()
        {
            return new FireMage();
        }

        public IWarrior CreateWarrior()
        {
            return new FireWarrior();
        }

        public IArcher CreateArcher()
        {
            return new FireArcher();
        }
    }
}
