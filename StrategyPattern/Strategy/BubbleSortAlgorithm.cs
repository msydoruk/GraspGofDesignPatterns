﻿namespace StrategyPattern.Strategy
{
    internal class BubbleSortAlgorithm : ISortAlgorithmStrategy
    {
        public List<int> Sort(List<int> list)
        {
            var array = BubbleSort(list.ToArray());
            return array.ToList();
        }

        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        static int[] BubbleSort(int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }
    }
}
