using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GofDesignPatterns.Tasks.AbstractFactoryPattern.KitchenTypeFactory
{
    public static class KitchenTypeFactory
    {
        public static KitchenTypeAbstractFactory GetKitchenType(string kitchenType)
        {
            switch (kitchenType)
            {
                case "japanese":
                    return new JapaneseFactory();
                case "ukrainian":
                    return new UkrainianFactory();
                case "usa":
                    return new UsaFactory();
                default:
                    return new UsaFactory();
            }
        }
    }
}
