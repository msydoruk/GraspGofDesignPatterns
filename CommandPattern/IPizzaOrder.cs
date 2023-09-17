using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public interface IPizzaOrder
    {
        void AddIngredient(Ingredient ingredient);

        List<Ingredient> GetIngredients();
    }
}
