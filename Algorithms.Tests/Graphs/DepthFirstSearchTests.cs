using System.Collections.Generic;
using Algorithms.Graphs;
using Algorithms.Graphs.DepthFirstSearch;
using Xunit;

namespace Algorithms.Tests.Graphs
{
    public class DepthFirstSearchTests
    {
        [Fact]
        public void DepthFirstSearchReturnsTrueWhenGraphContainsValueAndVerticesAreConnected()
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
        public void DepthFirstSearchReturnsFalseWhenGraphDoesNotContainValue()
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
        public void DepthFirstSearchReturnsTrueWhenGraphContainsValueAndVerticesAreNotConnected()
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
        public void DepthFirstSearchReturnsTrueWhenGraphContainsValueAndVerticesAreConnectedInCircle()
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
    }
}
