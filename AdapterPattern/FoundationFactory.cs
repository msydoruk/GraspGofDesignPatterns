using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public static class FoundationFactory
    {
        public static IFoundation GetFoundation(Country country)
        {
            switch (country)
            {
                case Country.Germany:
                    return new GermanFoundation();
                case Country.Italy:
                    return new ItalianFoundation();
                default:
                    return new GermanFoundation();
            }
        }
    }
}
