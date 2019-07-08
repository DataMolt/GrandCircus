using System;
using Xunit;
using FizzBuzzWoofLab;

namespace FizzBuzzWoofTest
{
    public class FizzBuzzWoofTest
    {
        [Theory]
        [InlineData(31)]
        [InlineData(9)]

        public void CheckForThree(int value)
        {
            // arrange

            // act
            var sut = new FizzBuzzLogicChecking();
            var num = sut.ThreePrintsFizz(value);

            // assert
            Assert.True(num);
        }

        [Theory]
        [InlineData(51)]
        [InlineData(25)]

        public void CheckForFive(int value)
        {
            // arrange

            // act
            var sut = new FizzBuzzLogicChecking();
            var num = sut.FivePrintsBuzz(value);

            // assert
            Assert.True(num);
        }

        [Theory]
        [InlineData(71)]
        [InlineData(49)]

        public void CheckForSeven(int value)
        {
            // arrange

            // act
            var sut = new FizzBuzzLogicChecking();
            var num = sut.SevenPrintsWoof(value);

            // assert
            Assert.True(num);
        }

        [Theory]
        [InlineData(60)]
        [InlineData(53)]
        public void CheckForThreeAndFive(int value)
        {
            // arrange

            // act
            var sut = new FizzBuzzLogicChecking();
            var num = sut.ThreeAndFive(value);

            // assert
            Assert.True(num);
        }

        [Theory]
        [InlineData(21)]
        [InlineData(73)]
        public void CheckForThreeAndSeven(int value)
        {
            // arrange

            // act
            var sut = new FizzBuzzLogicChecking();
            var num = sut.ThreeAndSeven(value);

            // assert
            Assert.True(num);
        }

        [Theory]
        [InlineData(57)]
        [InlineData(35)]
        public void CheckForFiveAndSeven(int value)
        {
            // arrange

            // act
            var sut = new FizzBuzzLogicChecking();
            var num = sut.FiveAndSeven(value);

            // assert
            Assert.True(num);
        }

        [Theory]
        [InlineData(753)]
        [InlineData(105)]
        public void CheckForAll(int value)
        {
            // arrange

            // act
            var sut = new FizzBuzzLogicChecking();
            var num = sut.ThreeFiveAndSeven(value);

            // assert
            Assert.True(num);
        }
    }
}
