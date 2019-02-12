using System;
using System.Collections.Generic;

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
                if (compareResult == -1)
                {
                    index = position;
                }
                else if (compareResult == 1)
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
                if (items[index].CompareTo(item) == 0)
                {
                    return index;
                }
            }

            return SearchConsts.NotFoundValueIndex;
        }
    }
}
