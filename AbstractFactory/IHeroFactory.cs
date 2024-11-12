using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AbstractFactory
{
    public interface IHeroFactory
    {
        IMage CreateMage();
        IWarrior CreateWarrior();
        IArcher CreateArcher();
    }
}