﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Graphs.BreadthFirstSearch
{
    public static class BreadthFirstSearchExtension
    {
        public static bool ContainsValue<T>(this Graph<T> graph, T value)
            where T : IComparable<T>
        {
            var visited = new HashSet<Vertex<T>>();
            var queue = new Queue<Vertex<T>>(graph.Vertices);

            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();

                if (!visited.Contains(vertex))
                {
                    if (vertex.Value.CompareTo(value) == 0)
                    {
                        return true;
                    }

                    visited.Add(vertex);

                    foreach (var neighbor in vertex.Neighbors)
                    {
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return false;
        }
    }
}
