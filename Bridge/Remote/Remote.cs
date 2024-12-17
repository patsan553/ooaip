using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.TV;

namespace Bridge.Remote
{
    public abstract class Remote
    {
        protected ITV _tv;

        public Remote(ITV tv)
        {
            _tv = tv;
        }

        public virtual void On()
        {
            _tv.IsWorking(true);
        }

        public virtual void Off()
        {
            _tv.IsWorking(false);
        }

        public virtual void SetChannel(int channel)
        {
            _tv.SetChannel(channel);
        }
    }
}
