using Builder.Builders;
using Builder.Directors;
using System.Reflection.Emit;

namespace Builder
{
    public class Client
    {
        public void OrderBurger()
        {
            ShawarmaBuilder builder = new ShawarmaBuilder();
            var burger = new DragonShawarmaDirector(builder);
            burger.Build();
            MenuBuilder menu = new MenuBuilder();
            List<string> ingredients = menu.Build();
            TestShawarmaBuilder test = new TestShawarmaBuilder();
            if (test.Build())
            {
                Console.WriteLine("The shawarma is cooked correctly ");
            }
            else
            {
                Console.WriteLine("The shawarma is cooked incorrectly ");
            }
        }
    }
}