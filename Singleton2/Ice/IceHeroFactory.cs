using AbstractFactory.Fire;
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
        private IceHeroFactory() { }
        private static IceHeroFactory _instance;
        public static IceHeroFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new IceHeroFactory();
                }
                return _instance;
            }
        }
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
