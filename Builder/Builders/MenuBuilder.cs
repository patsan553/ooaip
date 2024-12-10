using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public class MenuBuilder : IShawarmaBuilder
    {
        private readonly List<string> _ingredients;
        public MenuBuilder()
        {
            _ingredients = new List<string>();
        }
        public void WithCheese()
        {
            _ingredients.Add("Cheese");
        }
        public void WithMeat()
        {
            _ingredients.Add("Meat");
        }
        public void WithTomato()
        {
            _ingredients.Add("Tomato");
        }
        public void WithSauce()
        {
            _ingredients.Add("Sauce");
        }
        public void WithSalad()
        {
            _ingredients.Add("Salad");
        }
        public void WithPepper()
        {
            _ingredients.Add("Pepper");
        }
        public List<string> Build()
        {
            return _ingredients;
        }
    }
}
