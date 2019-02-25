using System.Collections.Generic;
using Algorithms.Graphs;
using Algorithms.Graphs.BreadthFirstSearch;
using Xunit;

namespace Algorithms.Tests.Graphs
{
    public class BreadthFirstSearchTests
    {
        [Fact]
        public void BreadthFirstSearchReturnsTrueWhenGraphContainsValueAndVerticesAreConnected()
        {
            var value = 32;
            var graph = new Graph<int>(new List<Vertex<int>>()
            {
                new Vertex<int>(3, new Vertex<int>(5,  new Vertex<int>(value))),
            });

            var actualResult = graph.ContainsValue(value);
            Assert.True(actualResult);
        }

        [Fact]
        public void BreadthFirstSearchReturnsFalseWhenGraphDoesNotContainValue()
        {
            var value = 32;
            var graph = new Graph<int>(new List<Vertex<int>>()
            {
                new Vertex<int>(3, new Vertex<int>(5)),
                new Vertex<int>(5)
            });

            var actualResult = graph.ContainsValue(value);
            Assert.False(actualResult);
        }

        [Fact]
        public void BreadthFirstSearchReturnsTrueWhenGraphContainsValueAndVerticesAreNotConnected()
        {
            var value = 32;
            var graph = new Graph<int>(new List<Vertex<int>>()
            {
                new Vertex<int>(3, new Vertex<int>(5)),
                new Vertex<int>(value)
            });

            var actualResult = graph.ContainsValue(value);
            Assert.True(actualResult);
        }

        [Fact]
        public void BreadthFirstSearchReturnsTrueWhenGraphContainsValueAndVerticesAreConnectedInCircle()
        {
            var value = 32;
            var searchedVertex = new Vertex<int>(value);
            var otherVertex = new Vertex<int>(3, new Vertex<int>(5));
            searchedVertex.AddEdge(otherVertex);
            otherVertex.AddEdge(searchedVertex);
            var graph = new Graph<int>(new List<Vertex<int>>()
            {
                otherVertex
            });

            var actualResult = graph.ContainsValue(value);
            Assert.True(actualResult);
        }

        [Fact]
        public void BreadthFirstSearchReturnsFalseWhenGraphDoesNotContainsVertex()
        {
            var value = 32;
            var graph = new Graph<int>(new List<Vertex<int>>());

            var actualResult = graph.ContainsValue(value);
            Assert.False(actualResult);
        }

        [Fact]
        public void BreadthFirstSearchReturnsFalseWhenGraphIsNull()
        {
            var value = 32;
            Graph<int> graph = null;

            var actualResult = graph.ContainsValue(value);
            Assert.False(actualResult);
        }
    }
}
