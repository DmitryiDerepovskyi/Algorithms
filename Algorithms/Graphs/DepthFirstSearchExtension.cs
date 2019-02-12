using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Graphs.DepthFirstSearch
{
    public static class DepthFirstSearchExtension
    {
        public static bool ContainsValue<T>(this Graph<T> graph, T value)
            where T : IComparable<T>
        {
            var visited = new HashSet<Vertex<T>>();
            var stack = new Stack<Vertex<T>>(graph.Vertices);

            while (stack.Count > 0)
            {
                var vertex = stack.Pop();

                if (!visited.Contains(vertex))
                {
                    if (vertex.Value.CompareTo(value) == 0)
                    {
                        return true;
                    }

                    visited.Add(vertex);

                    foreach (var neighbor in vertex.Neighbors)
                    {
                        stack.Push(neighbor);
                    }
                }
            }

            return false;
        }
    }
}
