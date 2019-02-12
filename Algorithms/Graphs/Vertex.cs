using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Graphs
{
    public class Vertex<T>
        where T : IComparable<T>
    {
        public Vertex(T value, params Vertex<T>[] parameters)
            : this(value, (IEnumerable<Vertex<T>>)parameters) { }

        public Vertex(T value, IEnumerable<Vertex<T>> neighbors)
        {
            Value = value;
            Neighbors = neighbors?.ToList() ?? new List<Vertex<T>>();
        }

        public Vertex(T value)
            : this(value, new List<Vertex<T>>())
        {
        }

        public T Value { get; }

        public List<Vertex<T>> Neighbors { get; }

        public int NeighborCount => Neighbors.Count;

        public void AddEdge(Vertex<T> vertex)
        {
            this.Neighbors.Add(vertex);
        }

        public void AddEdges(params Vertex<T>[] newNeighbors)
        {
            this.AddEdges();
        }

        public void AddEdges(IEnumerable<Vertex<T>> newNeighbors)
        {
            this.Neighbors.AddRange(newNeighbors);
        }

        public void RemoveEdge(Vertex<T> vertex)
        {
            this.Neighbors.Remove(vertex);
        }

        public override string ToString()
        {
            return this.Neighbors.Aggregate(new StringBuilder($"{Value}: "), (sb, n) => sb.Append($"{n.Value} ")).ToString();
        }
    }
}
