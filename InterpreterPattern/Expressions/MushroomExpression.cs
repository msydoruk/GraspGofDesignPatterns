using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.Expressions
{
    public class MushroomExpression : IExpression
    {
        public void Interpret(IngredientContext context)
        {
            if (context.IngredientExpression.IndexOf("Mushroom", StringComparison.CurrentCultureIgnoreCase) >= 0)
                context.IngredientsOutput.Add(Ingredient.Mushroom);
        }
    }
}
