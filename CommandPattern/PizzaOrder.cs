using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class PizzaOrder : IPizzaOrder
    {
        private List<Ingredient> ingredients = new();

        public void AddIngredient(Ingredient ingredient)
        {
            ingredients.Add(ingredient);
        }

        public List<Ingredient> GetIngredients()
        {
            return ingredients;
        }
    }
}
