using System;
using System.Collections.Generic;
using Algorithms.Consts;

namespace Algorithms.Searching
{
    public static class JumpSearchExtension
    {
        public static int JumpSearch<T>(this IList<T> items, T item)
            where T : IComparable
        {
            int step = (int)Math.Sqrt(items.Count);
            var index = -1;
            while(index < items.Count - 1)
            {
                var position = Math.Min(index + step, items.Count - 1);
                var compareResult = items[position].CompareTo(item);
                if (compareResult == CompareResult.Less)
                {
                    index = position;
                }
                else if (compareResult == CompareResult.Greater)
                {
                    return LinearSearch(items, item, Math.Max(index, 0), position);
                }
                else
                {
                    return position;
                }
            }

            return SearchConsts.NotFoundValueIndex;
        }

        private static int LinearSearch<T>(IList<T> items, T item, int from, int to)
            where T : IComparable
        {
            for(int index = from; index <= to; index++)
            {
                if (items[index].CompareTo(item) == CompareResult.Equal)
                {
                    return index;
                }
            }

            return SearchConsts.NotFoundValueIndex;
        }
    }
}
