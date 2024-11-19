using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Core;

namespace Builder.ShavermaBuilders
{
    public class ValidationBuilder
    {
        public bool Validate(Shaverma shaverma)
        {
            if (shaverma.Type == null)
            {
                Console.WriteLine("Ошибка: Не указан тип шаурмы.");
                return false;
            }

            if (shaverma.Meat == null)
            {
                Console.WriteLine("Ошибка: Не указано мясо.");
                return false;
            }

            if (shaverma.Sauce == null)
            {
                Console.WriteLine("Ошибка: Не указан соус.");
                return false;
            }

            return true;
        }
    }
}
