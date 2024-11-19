using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Computer
    {
        public Game CurrentGame { get; set; }
        public void LaunchGame(string gameName)
        {
            CurrentGame = Game.GetInstance(gameName);
        }
    }
}
