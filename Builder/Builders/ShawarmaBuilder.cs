using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public class ShawarmaBuilder : IShawarmaBuilder
    {
        private Shawarma _shawarma;
        public ShawarmaBuilder()
        {
            _shawarma = new Shawarma();
        }
        public void WithCheese()
        {
            _shawarma.AddIngredient("Cheese");
        }
        public void WithMeat()
        {
            _shawarma.AddIngredient("Meat");
        }
        public void WithTomato()
        {
            _shawarma.AddIngredient("Tomato");
        }
        public void WithSauce()
        {
            _shawarma.AddIngredient("Sauce");
        }
        public void WithSalad()
        {
            _shawarma.AddIngredient("Salad");
        }
        public void WithPepper()
        {
            _shawarma.AddIngredient("Pepper");
        }
        public Shawarma Build()
        {
            return _shawarma;
        }
    }
}
