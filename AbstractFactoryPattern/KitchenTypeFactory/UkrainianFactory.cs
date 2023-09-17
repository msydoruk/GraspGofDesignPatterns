using GofDesignPatterns.Tasks.AbstractFactoryPattern.Base;
using GofDesignPatterns.Tasks.AbstractFactoryPattern.KitchenType.Ukrainian;

namespace GofDesignPatterns.Tasks.AbstractFactoryPattern.KitchenTypeFactory
{
    public class UkrainianFactory : KitchenTypeAbstractFactory
    {
        public override Salad CreateSalad()
        {
            return new UkrainianSalad();
        }

        public override Soup CreateSoup()
        {
            return new UkrainianSoup();
        }

        public override SecondCourse CreateSecondCourse()
        {
            return new UkrainianSecondCourse();
        }

        public override Drink CreateDrink()
        {
            return new UkrainianDrink();
        }
    }
}
