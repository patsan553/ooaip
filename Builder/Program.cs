using System;
using Builder.Core;
using Builder.ShavermaBuilders;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Rustam rustam = new Rustam();
            ValidationBuilder validator = new ValidationBuilder();

            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Выбрать готовую шаурму из меню");
            Console.WriteLine("2. Создать свою шаурму");

            string choice = Console.ReadLine();

            GodFoodBuilder builder = null;

            if (choice == "1")
            {
                Console.WriteLine("Выберите шаурму:");
                Console.WriteLine("1. со свининой");
                Console.WriteLine("2. с говядиной");
                Console.WriteLine("3. с курицей");

                string shavermaChoice = Console.ReadLine();
                builder = shavermaChoice switch
                {
                    "1" => new PorkShavermaBuilder(),
                    "2" => new BeefShavermaBuilder(),
                    "3" => new ChickenShavermaBuilder(),
                    _ => throw new ArgumentException("Неверный выбор."),
                };
            }
            else if (choice == "2")
            {
                builder = new CustomShavermaBuilder();
            }
            else
            {
                Console.WriteLine("Неверный выбор.");
                return;
            }

            Shaverma shaverma = rustam.Cook(builder);

            if (validator.Validate(shaverma))
            {
                Console.WriteLine("\nВаша шаурма готова:");
                Console.WriteLine(shaverma.ToString());
            }
            else
            {
                Console.WriteLine("Ошибка: Шаурма не валидна.");
            }

            Console.ReadLine();
        }
    }
}