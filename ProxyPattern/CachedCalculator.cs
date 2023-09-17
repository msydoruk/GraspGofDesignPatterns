using System.Collections.Concurrent;
using FacadePattern;

namespace ProxyPattern
{
    public class CachedCalculator : ICalculator
    {
        private readonly ICalculator calculator;

        private readonly ConcurrentDictionary<string, int> concurrentDictionary = new();

        public CachedCalculator(ICalculator calculator)
        {
            this.calculator = calculator;
        }

        public int Add(int intA, int intB)
        {
            var cacheKey = $"cache:Add{intA}^{intB}";
            if (concurrentDictionary.ContainsKey(cacheKey))
                return concurrentDictionary[cacheKey];

            return concurrentDictionary[cacheKey] = calculator.Add(intA, intB);
        }

        public int Subtract(int intA, int intB)
        {
            var cacheKey = $"cache:Subtract{intA}^{intB}";
            if (concurrentDictionary.ContainsKey(cacheKey))
                return concurrentDictionary[cacheKey];

            return concurrentDictionary[cacheKey] = calculator.Subtract(intA, intB);
        }

        public int Multiply(int intA, int intB)
        {
            var cacheKey = $"cache:Multiply{intA}^{intB}";
            if (concurrentDictionary.ContainsKey(cacheKey))
                return concurrentDictionary[cacheKey];

            return concurrentDictionary[cacheKey] = calculator.Multiply(intA, intB);
        }

        public int Divide(int intA, int intB)
        {
            var cacheKey = $"cache:Divide{intA}^{intB}";
            if (concurrentDictionary.ContainsKey(cacheKey))
                return concurrentDictionary[cacheKey];

            return concurrentDictionary[cacheKey] = calculator.Divide(intA, intB);
        }
    }
}
