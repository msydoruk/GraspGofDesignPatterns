using InterpreterPattern;
using InterpreterPattern.Expressions;

IngredientContext ingredientContext = new IngredientContext("Bacon Mushroom sire PINEAPPLE");

List<IExpression> expressions = new List<IExpression>()
{
    new BaconExpression(),
    new MushroomExpression(),
    new PineappleExpression(),
    new SeafoodExpression(),
    new SireExpression()
};

foreach (var expression in expressions)
{
    expression.Interpret(ingredientContext);
}

