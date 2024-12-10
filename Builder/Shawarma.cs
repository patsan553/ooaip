using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Shawarma
    {
        private readonly List<string> ingredients;
        public Shawarma()
        {
            ingredients = new List<string>();
        }
        public void AddIngredient(string ingredient)
        {
            ingredients.Add(ingredient);
        }
        public List<string> GetIngredients()
        {
            return ingredients;
        }
    }
}
