using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Game
    {
        private static Game instance;
        public string Name { get; private set; }
        private Game(string name)
        {
            this.Name = name;
        }
        public static Game GetInstance(string name)
        {
            if (instance == null)
                instance = new Game(name);
            return instance;
        }
    }
}
