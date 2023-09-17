using GofDesignPatterns.Tasks.AbstractFactoryPattern.Base;
using GofDesignPatterns.Tasks.AbstractFactoryPattern.KitchenType.Usa;

namespace GofDesignPatterns.Tasks.AbstractFactoryPattern.KitchenTypeFactory
{
    public class UsaFactory : KitchenTypeAbstractFactory
    {
        public override Salad CreateSalad()
        {
            return new UsaSalad();
        }

        public override Soup CreateSoup()
        {
            return new UsaSoup();
        }

        public override SecondCourse CreateSecondCourse()
        {
            return new UsaSecondCourse();
        }

        public override Drink CreateDrink()
        {
            return new UsaDrink();
        }
    }
}
