using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Ingredient
    {
        public Ingredient(IngredientType type, int amount)
        {
            Amount = amount;
            Type = type;
        }

        public IngredientType Type { get; }

        public int Amount { get; }
    }
}
