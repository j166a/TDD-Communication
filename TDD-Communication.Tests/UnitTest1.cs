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
            int[] numbers = [5, 2, 6, 10, 22];

            int[] output = SumNumbers(numbers);

            output.ShouldBe([2, 5, 6, 10, 22]);
        }
    }
}