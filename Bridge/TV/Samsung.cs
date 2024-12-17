using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.TV
{
    public class Samsung : ITV
    {
        private int _currentChannel = 1;

        public void IsWorking(bool f)
        {
            if (f)
            {
                Console.WriteLine("Samsung is working");
            }
            else
            {
                Console.WriteLine("Samsung isn't working");
            }
        }

        public void SetChannel(int channel)
        {
            _currentChannel = channel;
            Console.WriteLine($"channel {_currentChannel} is installed");
        }
    }
}
