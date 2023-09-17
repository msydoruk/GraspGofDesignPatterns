using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Pizza
    {
        private readonly List<Ingredient> ingredients = new();

        public void AddIngredient(Ingredient element)
        {
            ingredients.Add(element);
        }

        public List<Ingredient> GetIngredients()
        {
            return ingredients;
        }
    }
}
