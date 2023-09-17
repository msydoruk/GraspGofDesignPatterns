using GofDesignPatterns.Tasks.AbstractFactoryPattern.Base;

namespace GofDesignPatterns.Tasks.AbstractFactoryPattern.KitchenTypeFactory
{
    public abstract class KitchenTypeAbstractFactory
    {
        public abstract Salad CreateSalad();

        public abstract Soup CreateSoup();

        public abstract SecondCourse CreateSecondCourse();

        public abstract Drink CreateDrink();
    }
}
