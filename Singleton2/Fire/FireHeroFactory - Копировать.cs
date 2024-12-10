using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractFactory.Fire
{
    public class FireHeroFactory : IHeroFactory
    {
        private FireHeroFactory() { } 
        private static FireHeroFactory _instance;
        public static FireHeroFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FireHeroFactory();
                }
                return _instance;
            }
        }
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
