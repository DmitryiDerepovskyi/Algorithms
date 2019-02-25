using Algorithms.Searching;
using Xunit;

namespace Algorithms.Tests.Sortings
{
    public class JumpSearchTests
    {
        [Fact]
        public void JumpSearchReturnsItemIndexWhenArrayContainsElements()
        {
            var item = 32;
            var inputArray = new[] { -95, -94, 31, item, 33, 66 };
            var expectedIndex = 3;

            var actualIndex = inputArray.JumpSearch(item);
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void JumpSearchReturnsItemIndexWhenArrayContainsOneElement()
        {
            var item = 32;
            var inputArray = new[] { item };
            var expectedIndex = 0;

            var actualIndex = inputArray.JumpSearch(item);
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void JumpSearchReturnsDefaultIndexWhenArrayContainsOnlyOneElement()
        {
            var item = 32;
            var inputArray = new[] { 33 };
            var expectedIndex = -1;

            var actualIndex = inputArray.JumpSearch(item);
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void JumpSearchReturnsItemIndexWhenItemIsFirstOne()
        {
            var item = 2;
            var inputArray = new[] { item, 3, 5, 8 };
            var expectedIndex = 0;

            var actualIndex = inputArray.JumpSearch(item);
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void JumpSearchReturnsItemIndexWhenItemIsLastOne()
        {
            var item = 25;
            var inputArray = new[] { 3, 5, 8, item };
            var expectedIndex = 3;

            var actualIndex = inputArray.JumpSearch(item);
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void JumpSearchReturnsDefaultIndexWhenArrayDoesNotContainItem()
        {
            var item = 25;
            var inputArray = new[] { 3, 5, 8, 9 };
            var expectedIndex = -1;

            var actualIndex = inputArray.JumpSearch(item);
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void JumpSearchReturnsDefaultIndexWhenArrayIsNull()
        {
            var item = 25;
            int[] inputArray = null;
            var expectedIndex = -1;

            var actualIndex = inputArray.JumpSearch(item);
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void JumpSearchReturnsDefaultIndexWhenArrayIsEmpty()
        {
            var item = 25;
            int[] inputArray = new int[0];
            var expectedIndex = -1;

            var actualIndex = inputArray.JumpSearch(item);
            Assert.Equal(expectedIndex, actualIndex);
        }
    }
}
