using Shouldly;

namespace TDD_Communication.Tests;

public class SumASCIITests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("A", 65)]
    [TestCase("a", 97)]
    public void SumASCIICodes_ShouldReturnASCIIValue_WhenPassedOneChar(string input, int expected)
    {
        int output = SumASCII.SumASCIICodes(input);
        output.ShouldBe(expected);
    }
    [TestCase("northcoders", 1195)]
    [TestCase("Northcoders", 1163)]
    public void SumASCIICodes_ShouldReturnASCIIValue_WhenPassedAString(string input, int expected)
    {
        int output = SumASCII.SumASCIICodes(input);

        output.ShouldBe(expected);
    }

}
