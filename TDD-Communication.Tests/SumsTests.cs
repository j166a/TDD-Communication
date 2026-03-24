using Shouldly;

namespace TDD_Communication.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SumNumbers_ReturnsZero_WhenEmptyArray()
        {
            int[] input = [];
            int output = Sums.SumNumbers(input);

            output.ShouldBe(0);
        }

        [Test]
        public void SumNumbers_ReturnsZero_WhenArrayLengthOne()
        {
            int[] input = [1];
            int output = Sums.SumNumbers(input);

            output.ShouldBe(0);
        }

        [Test]
        public void SumNumbers_ReturnsZero_WhenArrayLengthTwo()
        {
            int[] input = [1, 2];
            int output = Sums.SumNumbers(input);

            output.ShouldBe(0);
        }

        [Test]
        public void SumNumbers_ShouldReturnSumOfOrderedNums_WhileExcludingFirstAndLast()
        {
            int[] input = [5, 2, 6, 10, 22];

            int output = Sums.SumNumbers(input);

            output.ShouldBe(21);
        }

        
    }
}