using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adapter : IDuck
    {
        private readonly IFrog _frog;

        public Adapter(IFrog frog)
        {
            _frog = frog == null ? throw new ArgumentNullException() : frog;
        }

        public string Quack()
        {
            return _frog.Croak();
        }
    }
}
