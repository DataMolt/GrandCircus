using System;
using System.Collections.Generic;
using Xunit;

namespace GrandCircus_Day27.GrandCircus_Day27_Test
{
    public class BubbleSortTests
    {
        [Fact]
        public void EmptyListReturnsEmpty()
        {
            // arrange
            var unsorted = new List<int>();

            // act
            var sut = new BubbleSort();
            var sorted = sut.Sort(unsorted);

            // assert
            Assert.Empty(sorted);
        }

        [Fact]
        public void SortedListReturnsSorted()
        {
            // arrange
            var unsorted = new List<int> { 1, 2, 3, 4 };

            // act
            var sut = new BubbleSort();
            var sorted = sut.Sort(unsorted);

            // assert
            Assert.Equal(1, sorted[0]);
            Assert.Equal(2, sorted[1]);
            Assert.Equal(3, sorted[2]);
            Assert.Equal(4, sorted[3]);
        }

        [Fact]
        public void NullReturnsNull()
        {
            // arrange
            List<int> unsorted = null;

            // act
            var sut = new BubbleSort();
            var sorted = sut.Sort(unsorted);

            // assert
            Assert.Null(sorted);
        }

        [Fact]
        public void SingleListReturnsSingle()
        {
            // arrange
            var unsorted = new List<int> { 2 };

            // act
            var sut = new BubbleSort();
            var sorted = sut.Sort(unsorted);

            // assert
            Assert.Equal(2, sorted[0]);
            Assert.Equal(1, sorted.Count);
        }
    }
}
