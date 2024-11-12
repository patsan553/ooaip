using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AbstractFactory
{
    public class IceHeroFactory : IHeroFactory
    {
        public IMage CreateMage()
        {
            return new IceMage();
        }

        public IWarrior CreateWarrior()
        {
            return new IceWarrior();
        }

        public IArcher CreateArcher()
        {
            return new IceArcher();
        }
    }
}
