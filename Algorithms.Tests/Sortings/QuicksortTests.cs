using Algorithms.Sorting;
using Xunit;

namespace Algorithms.Tests.Sortings
{
    public class QuicksortTests
    {
        [Fact]
        public void QuicksortReturnsOrderedArrayWhenOnlyPositiveNumber()
        {
            var inputArray = new[] { 94, 95, 32, 56, 6, 3 };
            var expectedResult = new[] { 3, 6, 32, 56, 94, 95 };

            inputArray.Quicksort();
            Assert.Equal(expectedResult, inputArray);
        }

        [Fact]
        public void QuicksortReturnsOrderedArrayWhenOnlyNegativeNumber()
        {
            var inputArray = new[] { -94, -95, -32, -56, -6, -3 };
            var expectedResult = new[] { -95, -94, -56, -32, -6, -3 };

            inputArray.Quicksort();
            Assert.Equal(expectedResult, inputArray);
        }

        [Fact]
        public void QuicksortReturnsOrderedArray()
        {
            var inputArray = new[] { 0, -95, 32, -56, 6, -3 };
            var expectedResult = new[] { -95, -56, -3, 0, 6, 32 };

            inputArray.Quicksort();
            Assert.Equal(expectedResult, inputArray);
        }

        [Fact]
        public void QuicksortReturnsOrderedArrayWhenAllNumbersAreTheSame()
        {
            var inputArray = new[] { 1, 1, 1, 1 };
            var expectedResult = new[] { 1, 1, 1, 1 };

            inputArray.Quicksort();
            Assert.Equal(expectedResult, inputArray);
        }

        [Fact]
        public void QuicksortReturnsOrderedArrayWhenArrayAlreadyWasSorted()
        {
            var inputArray = new[] { 1, 22, 33, 44 };
            var expectedResult = new[] { 1, 22, 33, 44 };

            inputArray.Quicksort();
            Assert.Equal(expectedResult, inputArray);
        }


        [Fact]
        public void QuicksortReturnsOrderedArrayWhenArrayWasSortedByDesc()
        {
            var inputArray = new[] { 44, 33, 22, 1 };
            var expectedResult = new[] { 1, 22, 33, 44 };

            inputArray.Quicksort();
            Assert.Equal(expectedResult, inputArray);
        }


        [Fact]
        public void QuicksortReturnsOrderedArrayWhenArrayContainsOneNumber()
        {
            var inputArray = new[] { 1 };
            var expectedResult = new[] { 1 };

            inputArray.Quicksort();
            Assert.Equal(expectedResult, inputArray);
        }

        [Fact]
        public void QuicksortReturnsEmptyArrayWhenArrayIsEmpty()
        {
            var inputArray = new int[0];
            var expectedResult = new int[0];

            inputArray.Quicksort();
            Assert.Equal(expectedResult, inputArray);
        }

        [Fact]
        public void QuicksortReturnsNullArrayWhenArrayIsNull()
        {
            int[] inputArray = null;
            int[] expectedResult = null;

            inputArray.Quicksort();
            Assert.Equal(expectedResult, inputArray);
        }
    }
}
