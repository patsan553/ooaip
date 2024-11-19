using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Core
{
    public class Shaverma
    {
        public Type Type { get; set; }
        public Meat Meat { get; set; }
        public Pepper Pepper { get; set; }
        public Cabbage Cabbage { get; set; }
        public Mushroom Mushroom { get; set; }
        public Sauce Sauce { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Type != null) sb.Append("Шаурма " + Type.Shava + "\n");
            if (Meat != null) sb.Append("Мясо: " + Meat.Animal + "\n");
            if (Pepper != null) sb.Append("Перец: " + Pepper.Spice + "\n");
            if (Cabbage != null) sb.Append("Капуста\n");
            if (Mushroom != null) sb.Append("Грибы\n");
            if (Sauce != null) sb.Append("Соус: " + Sauce.Name + "\n");
            return sb.ToString();
        }
    }
}
