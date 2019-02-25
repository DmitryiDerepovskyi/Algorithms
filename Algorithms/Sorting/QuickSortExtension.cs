using System;
using System.Collections.Generic;
using Algorithms.Consts;

namespace Algorithms.Sorting
{
    public static class QuickSortExtension
    {
        public static void Quicksort<T>(this IList<T> list)
            where T : IComparable
        {
            if (list == null || list.Count < 2)
            {
                return;
            }

            int startIndex = 0;
            int endIndex = list.Count - 1;
            var stack = new Stack<int>();

            stack.Push(startIndex);
            stack.Push(endIndex);

            while (stack.Count > 0)
            {
                endIndex = stack.Pop();
                startIndex = stack.Pop();

                int partition = Partition(list, startIndex, endIndex);

                if (partition - 1 > startIndex)
                {
                    stack.Push(startIndex);
                    stack.Push(partition - 1);
                }

                if (partition + 1 < endIndex)
                {
                    stack.Push(partition + 1);
                    stack.Push(endIndex);
                }
            }
        }

        private static int Partition<T>(IList<T> data, int leftIndex, int rightIndex)
            where T : IComparable
        {
            var pivot = data[rightIndex];
            int i = leftIndex - 1;
            for (var j = leftIndex; j < rightIndex; j++)
            {
                if (data[j].CompareTo(pivot) != CompareResult.Greater)
                {
                    i++;
                    Swap(data, i, j);
                }
            }

            i++;
            Swap(data, i, rightIndex);
            return i;
        }

        private static void Swap<T>(IList<T> data, int left, int right)
        {
            if (left != right)
            {
                var temp = data[left];
                data[left] = data[right];
                data[right] = temp;
            }
        }

    }
}
