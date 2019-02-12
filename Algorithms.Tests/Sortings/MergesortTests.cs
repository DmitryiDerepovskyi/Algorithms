using Algorithms.Sorting;
using Xunit;

namespace Algorithms.Tests.Sortings
{
    public class MergesortTests
    {
        [Fact]
        public void MergesortReturnsOrderedArrayWhenOnlyPositiveNumber()
        {
            var inputArray = new[] { 94, 95, 32, 56, 6, 3 };
            var expectedResult = new[] { 3, 6, 32, 56, 94, 95 };

            inputArray.Mergesort();
            Assert.Equal(expectedResult, inputArray);
        }

        [Fact]
        public void MergesortReturnsOrderedArrayWhenOnlyNegativeNumber()
        {
            var inputArray = new[] { -94, -95, -32, -56, -6, -3 };
            var expectedResult = new[] { -95, -94, -56, -32, -6, -3 };

            inputArray.Mergesort();
            Assert.Equal(expectedResult, inputArray);
        }

        [Fact]
        public void MergesortReturnsOrderedArray()
        {
            var inputArray = new[] { 0, -95, 32, -56, 6, -3 };
            var expectedResult = new[] { -95, -56, -3, 0, 6, 32 };

            inputArray.Mergesort();
            Assert.Equal(expectedResult, inputArray);
        }

        [Fact]
        public void MergesortReturnsOrderedArrayWhenAllNumbersAreTheSame()
        {
            var inputArray = new[] { 1, 1, 1, 1 };
            var expectedResult = new[] { 1, 1, 1, 1 };

            inputArray.Mergesort();
            Assert.Equal(expectedResult, inputArray);
        }

        [Fact]
        public void MergesortReturnsOrderedArrayWhenArrayAlreadyWasSorted()
        {
            var inputArray = new[] { 1, 22, 33, 44 };
            var expectedResult = new[] { 1, 22, 33, 44 };

            inputArray.Mergesort();
            Assert.Equal(expectedResult, inputArray);
        }


        [Fact]
        public void MergesortReturnsOrderedArrayWhenArrayWasSortedByDesc()
        {
            var inputArray = new[] { 44, 33, 22, 1 };
            var expectedResult = new[] { 1, 22, 33, 44 };

            inputArray.Mergesort();
            Assert.Equal(expectedResult, inputArray);
        }


        [Fact]
        public void MergesortReturnsOrderedArrayWhenArrayContainsOneNumber()
        {
            var inputArray = new[] { 1 };
            var expectedResult = new[] { 1 };

            inputArray.Mergesort();
            Assert.Equal(expectedResult, inputArray);
        }

        [Fact]
        public void MergesortReturnsEmptyArrayWhenArrayIsEmpty()
        {
            var inputArray = new int[0];
            var expectedResult = new int[0];

            inputArray.Mergesort();
            Assert.Equal(expectedResult, inputArray);
        }
    }
}
