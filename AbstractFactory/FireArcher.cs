using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FireArcher : IArcher
    {
        public string ShootArrow()
        {
            return "Fire Archer shoots a flaming arrow!";
        }
    }
}
