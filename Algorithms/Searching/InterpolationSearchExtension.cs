﻿using System;
using System.Collections.Generic;

namespace Algorithms.Searching
{
    public static class InterpolationSearchExtension
    {
        public static int InterpolationSearch(this IList<int> items, int item)
        {
            if (items != null && items.Count > 0)
            {
                var left = 0;
                var right = items.Count - 1;
                while (left <= right)
                {
                    int position = GetPosition(items, item, left, right);
                    if (items[position] < item)
                    {
                        left = position + 1;
                    }
                    else if (items[position] > item)
                    {
                        right = position - 1;
                    }
                    else
                    {
                        return position;
                    }
                }
            }

            return SearchConsts.NotFoundValueIndex;
        }

        private static int GetPosition(IList<int> items, int item, int left, int right)
        {
            var leftValue = items[left];
            var rightValue = items[right];
            var position = (int)(left + (((double)(right - left) / (rightValue - leftValue)) * (item - leftValue)));
            position = Math.Min(position, items.Count - 1);
            position = Math.Max(position, 0);
            return position;
        }
    }
}
