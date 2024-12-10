using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractFactory
{
    public class IceArcher : IArcher
    {
        public string ShootArrow()
        {
            return "Ice Archer shoots an icy arrow!";
        }
    }
}
