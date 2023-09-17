using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class AddIngredientCommand : ICommand
    {
        private readonly IPizzaOrder pizza;
        private readonly Ingredient ingredient;

        public AddIngredientCommand(IPizzaOrder pizza, Ingredient ingredient)
        {
            this.pizza = pizza;
            this.ingredient = ingredient;
        }

        public void Execute()
        {
            pizza.AddIngredient(ingredient);
        }
    }
}
