using GofDesignPatterns.Tasks.AbstractFactoryPattern.Base;
using GofDesignPatterns.Tasks.AbstractFactoryPattern.KitchenType.Japanese;
using GofDesignPatterns.Tasks.AbstractFactoryPattern.KitchenType.Ukrainian;

namespace GofDesignPatterns.Tasks.AbstractFactoryPattern.KitchenTypeFactory
{
    public class JapaneseFactory : KitchenTypeAbstractFactory
    {
        public override Salad CreateSalad()
        {
            return new JapaneseSalad();
        }

        public override Soup CreateSoup()
        {
            return new JapaneseSoup();
        }

        public override SecondCourse CreateSecondCourse()
        {
            return new UkrainianSecondCourse();
        }

        public override Drink CreateDrink()
        {
            return new JapaneseDrink();
        }
    }
}
