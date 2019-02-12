using System;
using System.Collections.Generic;

namespace Algorithms.Graphs
{
    public class Graph<T>
        where T : IComparable<T>
    {
        private ICollection<Vertex<T>> _vertices;

        public Graph()
            : this(new List<Vertex<T>>())
        {
        }

        public Graph(ICollection<Vertex<T>> vertices)
        {
            _vertices = vertices;
        }

        public IEnumerable<Vertex<T>> Vertices => _vertices;

        public void Add(Vertex<T> vertex)
        {
            _vertices.Add(vertex);
        }

        public void Remove(Vertex<T> vertex)
        {
            _vertices.Add(vertex);
        }
    }
}
