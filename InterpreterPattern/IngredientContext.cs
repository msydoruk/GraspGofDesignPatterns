using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class IngredientContext
    {
        public IngredientContext(string ingredientExpression)
        {
            IngredientExpression = ingredientExpression;
        }

        public List<Ingredient> IngredientsOutput { get; } = new();

        public string IngredientExpression { get; set; }
    }
}
