using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Core
{
    public class Type
    {
        public string Shava { get; set; }
    }

    public class Meat
    {
        public string Animal { get; set; }
    }

    public class Pepper
    {
        public string Spice { get; set; }
    }

    public class Cabbage { }

    public class Mushroom { }

    public class Sauce
    {
        public string Name { get; set; }
    }
}