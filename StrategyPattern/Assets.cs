using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Strategy;

namespace StrategyPattern
{
    public class Assets
    {
        private ISortAlgorithmStrategy sortAlgorithmStrategy;

        private List<int> passes = new();

        public Assets(ISortAlgorithmStrategy sortAlgorithmStrategy)
        {
            this.sortAlgorithmStrategy = sortAlgorithmStrategy;
        }

        public void AddUpc(int pass)
        {
            passes.Add(pass);
        }

        public void SetSortAlgorithm(ISortAlgorithmStrategy sortAlgorithm)
        {
            sortAlgorithmStrategy = sortAlgorithm;
        }

        public void Sort()
        {
            passes = sortAlgorithmStrategy.Sort(passes);
        }

        public void PrintAllPasses()
        {
            foreach (var pass in passes)
            {
                Console.WriteLine(pass);
            }
        }
    }
}
