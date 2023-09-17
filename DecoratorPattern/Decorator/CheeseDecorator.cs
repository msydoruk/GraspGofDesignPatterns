using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetIngredients()
        {
            return "Bacon ingredients + " + pizza.GetIngredients();
        }
    }
}
