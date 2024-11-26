using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Classes
{
    public class Processor : IComponent
    {
        private string model;
        private double frequency;

        public Processor(string model, double frequency)
        {
            this.model = model;
            this.frequency = frequency;
        }

        public IComponent Clone()
        {
            return new Processor(model, frequency);
        }

        public void GetInfo()
        {
            Console.WriteLine("Процессор: {0}, частота: {1} GHz", model, frequency);
        }
    }
}
