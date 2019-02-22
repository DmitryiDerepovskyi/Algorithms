using System;
using System.Collections.Generic;
using Algorithms.Consts;

namespace Algorithms.Sorting
{
    public static class MergeSortExtension
    {
        public static void Mergesort<T>(this IList<T> data) 
            where T : IComparable
        {
            int subarraySize = 2,
                lastIndex = data.Count - 1,
                maxSubarraySize = data.Count << 1;
            
            while (subarraySize < maxSubarraySize)
            {
                var index = 0;
                while (index < lastIndex)
                {
                    int right = index + subarraySize - 1;
                    int left = index;

                    int middle = (left + right) >> 1;

                    Merge(data, left, Math.Min(right, lastIndex), middle);
                    index = index + subarraySize;
                }

                subarraySize = subarraySize << 1;
            }
        }

        public static void Merge<T>(IList<T> data, int low, int high, int middle)
            where T : IComparable
        {
            int leftIndex = 0, rightIndex = 0, resultIndex = low;
            var leftArray = new T[middle - low + 1];
            if (high <= middle)
            {
                return;
            }

            var rightArray = new T[high - middle];

            Copy(data, low, leftArray);
            Copy(data, middle + 1, rightArray);

            while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
            {
                if (leftArray[leftIndex].CompareTo(rightArray[rightIndex]) == CompareResult.Less)
                {
                    data[resultIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    data[resultIndex] = rightArray[rightIndex];
                    rightIndex++;
                }

                resultIndex++;
            }

            CopyRestItems(data, leftArray, leftIndex, resultIndex);
            CopyRestItems(data, rightArray, rightIndex, resultIndex);
        }

        private static void CopyRestItems<T>(IList<T> data, T[] source, int sourceIndex, int index)
            where T : IComparable
        {
            while (sourceIndex < source.Length)
            {
                data[index] = source[sourceIndex];
                sourceIndex++;
                index++;
            }
        }

        private static void Copy<T>(IList<T> data, int sourceIndex, T[] destination)
           where T : IComparable
        {
            for (int i = 0; i < destination.Length; i++)
            {
                destination[i] = data[sourceIndex + i];
            }
        }
    }
}
