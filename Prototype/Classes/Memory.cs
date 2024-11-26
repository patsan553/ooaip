using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Classes
{
    public class Memory : IComponent
    {
        private string type;
        private int size;

        public Memory(string type, int size)
        {
            this.type = type;
            this.size = size;
        }

        public IComponent Clone()
        {
            return new Memory(type, size);
        }

        public void GetInfo()
        {
            Console.WriteLine("Память: тип {0}, размер {1} GB", type, size);
        }
    }
}
