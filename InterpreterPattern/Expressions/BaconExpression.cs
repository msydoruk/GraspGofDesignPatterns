using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.Expressions
{
    public class BaconExpression : IExpression
    {
        public void Interpret(IngredientContext context)
        {
            if (context.IngredientExpression.IndexOf("Bacon", StringComparison.CurrentCultureIgnoreCase) >= 0)
                context.IngredientsOutput.Add(Ingredient.Bacon);
        }
    }
}
