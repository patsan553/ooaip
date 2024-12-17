using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.TV
{
    public interface ITV
    {
        public void IsWorking(bool f);

        public void SetChannel(int channel);
    }
}
