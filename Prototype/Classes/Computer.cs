using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Classes
{
    public class Computer : IComponent
    {
        private string name;
        private Processor processor;
        private Memory memory;

        public Computer(string name, Processor processor, Memory memory)
        {
            this.name = name;
            this.processor = processor;
            this.memory = memory;
        }

        public IComponent Clone()
        {
            return new Computer(name, (Processor)processor.Clone(), (Memory)memory.Clone());
        }

        public void GetInfo()
        {
            Console.WriteLine("Компьютер: {0}", name);
            processor.GetInfo();
            memory.GetInfo();
        }

        public void SetProcessor(Processor newProcessor)
        {
            processor = newProcessor;
        }

        public void SetMemory(Memory newMemory)
        {
            memory = newMemory;
        }
    }
}
