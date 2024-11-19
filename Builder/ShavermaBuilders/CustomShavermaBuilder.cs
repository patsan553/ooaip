using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.ShavermaBuilders;

namespace Builder.Builders
{
    public class CustomShavermaBuilder : GodFoodBuilder
    {
        private string Prompt(string message)
        {
            string input;
            do
            {
                Console.Write(message + ": ");
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Ошибка: Поле не может быть пустым. Попробуйте снова.");
                }
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }

        public override void SetType()
        {
            string type = Prompt("Введите название шаурмы");
            GodFood.Type = new Type { Shava = type };
        }

        public override void SetMeat()
        {
            string meat = Prompt("Введите вид мяса");
            GodFood.Meat = new Meat { Animal = meat };
        }
        public override void SetPepper()
        {
            string pepper = Prompt("Введите вид перца");
            GodFood.Pepper = new Pepper { Spice = pepper };
        }

        public override void SetCabbage()
        {
            string addCabbage = Prompt("Добавить капусту? (да/нет)").ToLower();
            if (addCabbage == "да")
            {
                GodFood.Cabbage = new Cabbage();
            }
        }

        public override void SetMushroom()
        {
            string addMushrooms = Prompt("Добавить грибы? (да/нет)").ToLower();
            if (addMushrooms == "да")
            {
                GodFood.Mushroom = new Mushroom();
            }
        }
        public override void SetSauce()
        {
            string sauce = Prompt("Введите вид соуса");
            GodFood.Sauce = new Sauce { Name = sauce };

        }
    }
}
