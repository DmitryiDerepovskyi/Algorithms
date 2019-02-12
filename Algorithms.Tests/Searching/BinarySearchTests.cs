using Algorithms.Searching;
using Xunit;

namespace Algorithms.Tests.Sortings
{
    public class BinarySearchTests
    {
        [Fact]
        public void BinarySearchReturnsItemIndexWhenArrayContainElements()
        {
            var item = 32;
            var inputArray = new[] { -95, -94, 31, item, 33, 66 };
            var expectedIndex = 3;

            var actualIndex = inputArray.BinarySearch(item);
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void BinarySearchReturnsItemIndexWhenArrayContainOneElement()
        {
            var item = 32;
            var inputArray = new[] { item };
            var expectedIndex = 0;

            var actualIndex = inputArray.BinarySearch(item);
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void BinarySearchReturnsItemIndexWhenItemIsFirstOne()
        {
            var item = 2;
            var inputArray = new[] { item, 3, 5, 8 };
            var expectedIndex = 0;

            var actualIndex = inputArray.BinarySearch(item);
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void BinarySearchReturnsItemIndexWhenItemIsLastOne()
        {
            var item = 25;
            var inputArray = new[] { 3, 5, 8, item };
            var expectedIndex = 3;

            var actualIndex = inputArray.BinarySearch(item);
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void BinarySearchReturnsDefaultValueWhenArrayDoesNotContainItem()
        {
            var item = 25;
            var inputArray = new[] { 3, 5, 8, 9 };
            var expectedIndex = -1;

            var actualIndex = inputArray.BinarySearch(item);
            Assert.Equal(expectedIndex, actualIndex);
        }

    }
}