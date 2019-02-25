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
            if(data == null || data.Count < 2)
            {
                return;
            }

            int blockSize = 2,
                lastIndex = data.Count - 1,
                maxBlockSize = data.Count << 1;
            
            while (blockSize < maxBlockSize)
            {
                var index = 0;
                while (index < lastIndex)
                {
                    var right = index + blockSize - 1;
                    var left = index;

                    var middle = (left + right) >> 1;

                    var rightIndex = Math.Min(right, lastIndex);
                    Merge(data, left, rightIndex, middle);
                    index = index + blockSize;
                }

                blockSize = blockSize << 1;
            }
        }

        public static void Merge<T>(IList<T> data, int low, int high, int middle)
            where T : IComparable
        {
            if (high <= middle)
            {
                return;
            }

            int leftArrayIndex = 0,
                rightArrayIndex = 0,
                arrayIndex = low;

            var leftArray = new T[middle - low + 1];
            var rightArray = new T[high - middle];

            Copy(data, low, leftArray);
            Copy(data, middle + 1, rightArray);

            while (leftArrayIndex < leftArray.Length && rightArrayIndex < rightArray.Length)
            {
                if (leftArray[leftArrayIndex].CompareTo(rightArray[rightArrayIndex]) == CompareResult.Less)
                {
                    data[arrayIndex] = leftArray[leftArrayIndex];
                    leftArrayIndex++;
                }
                else
                {
                    data[arrayIndex] = rightArray[rightArrayIndex];
                    rightArrayIndex++;
                }

                arrayIndex++;
            }

            CopyRestItems(data, leftArray, leftArrayIndex, arrayIndex);
            CopyRestItems(data, rightArray, rightArrayIndex, arrayIndex);
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
