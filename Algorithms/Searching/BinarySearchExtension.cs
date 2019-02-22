using System;
using System.Collections.Generic;
using Algorithms.Consts;

namespace Algorithms.Searching
{
    public static class BinarySearchExtension
    {
        public static int BinarySearch<T>(this IList<T> items, T item)
            where T : IComparable
        {
            var left = 0;
            var right = items.Count - 1;
            while(left <= right)
            {
                var median = (left + right) >> 1;
                var compareResult = items[median].CompareTo(item);
                if (compareResult == CompareResult.Less)
                {
                    left = median + 1;
                }
                else if (compareResult == CompareResult.Greater)
                {
                    right = median - 1;
                }
                else
                {
                    return median;
                }
            }

            return SearchConsts.NotFoundValueIndex;
        }
    }
}
