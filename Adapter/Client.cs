using Adapter.Duck;
using Adapter.Frog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Client
    {
        public void SetDucks()
        {
            List<IDuck> ducks = new List<IDuck>();
            IDuck firstFastDuck = new FastDuck();
            IDuck firstSleepyDuck = new SleepyDuck();
            IDuck secondFastDuck = new FastDuck();
            IFrog hiddenFrog = new AgressiveFrog();

            ducks.Add(firstFastDuck);
            ducks.Add(secondFastDuck);
            ducks.Add(firstSleepyDuck);

            IDuck adaptedDuck = new Adapter(hiddenFrog);
            ducks.Add(adaptedDuck);

            foreach (var duck in ducks)
            {
                Console.WriteLine(duck.Quack());
            }
        }
    }
}