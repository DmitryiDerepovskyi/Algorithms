using Algorithms.Searching;
using Xunit;

namespace Algorithms.Tests.Sortings
{
    public class InterpolationSearchTests
    {
        [Fact]
        public void InterpolationSearchReturnsItemIndexWhenArrayContainElements()
        {
            var item = 32;
            var inputArray = new[] { -95, -94, 31, item, 33, 66 };
            var expectedIndex = 3;

            var actualIndex = inputArray.InterpolationSearch(item);
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void InterpolationSearchReturnsItemIndexWhenArrayContainOneElement()
        {
            var item = 32;
            var inputArray = new[] { item };
            var expectedIndex = 0;

            var actualIndex = inputArray.InterpolationSearch(item);
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void InterpolationSearchReturnsItemIndexWhenItemIsFirstOne()
        {
            var item = 2;
            var inputArray = new[] { item, 3, 5, 8 };
            var expectedIndex = 0;

            var actualIndex = inputArray.InterpolationSearch(item);
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void InterpolationSearchReturnsItemIndexWhenItemIsLastOne()
        {
            var item = 25;
            var inputArray = new[] { 3, 5, 8, item };
            var expectedIndex = 3;

            var actualIndex = inputArray.InterpolationSearch(item);
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void InterpolationSearchReturnsDefaultValueWhenArrayDoesNotContainItem()
        {
            var item = 25;
            var inputArray = new[] { 3, 5, 8, 9 };
            var expectedIndex = -1;

            var actualIndex = inputArray.InterpolationSearch(item);
            Assert.Equal(expectedIndex, actualIndex);
        }

    }
}
