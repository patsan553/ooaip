using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FabricMethod
{
    public abstract class HeroCreator
    {
        public abstract Mage CreateMage();
        public abstract Warrior CreateWarrior();
        public abstract Archer CreateArcher();

        public void CreateAndShowHeroes()
        {
            var mage = CreateMage();
            var warrior = CreateWarrior();
            var archer = CreateArcher();

            System.Console.WriteLine(mage.CastSpell());
            System.Console.WriteLine(warrior.Attack());
            System.Console.WriteLine(archer.ShootArrow());
        }
    }
}
