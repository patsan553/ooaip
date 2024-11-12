using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class GameClient
    {
        private readonly IHeroFactory _heroFactory;

        public GameClient(IHeroFactory heroFactory)
        {
            _heroFactory = heroFactory;
        }

        public void Run()
        {
            var mage = _heroFactory.CreateMage();
            var warrior = _heroFactory.CreateWarrior();
            var archer = _heroFactory.CreateArcher();

            Console.WriteLine(mage.CastSpell());
            Console.WriteLine(warrior.Attack());
            Console.WriteLine(archer.ShootArrow());
        }
    }
}
