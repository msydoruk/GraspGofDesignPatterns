using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class PizzaDecorator : IPizza
    {
        protected readonly IPizza pizza;

        protected PizzaDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public abstract string GetIngredients();
    }
}
