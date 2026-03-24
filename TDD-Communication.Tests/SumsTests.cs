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
        public void SumNumbers_ShouldReturnOrderedNumberArray()
        {
            int[] input = [5, 2, 6, 10, 22];

            int[] output = Sums.SumNumbers(input);

            output.ShouldBe([2, 5, 6, 10, 22]);
        }

        [Test]
        public void SumNumbers_ReturnsZero_WhenEmptyArray()
        {
            int[] input = [];
            int[] output = Sums.SumNumbers(input);

            output.Length.ShouldBe(0);
        }
    }
}